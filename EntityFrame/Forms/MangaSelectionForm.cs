using EntityFrame.Entities;
using EntityFrame.Persistence.Repositories;
using System.Data;

namespace EntityFrame.Forms
{
    public partial class MangaSelectionForm : Form
    {
        private Customer _customer;
        private readonly MangaRepository _mangaRepository;
        private readonly OrdersRepository _ordersRepository;
        private readonly OrderDetailsRepository _orderDetailsRepository;

        public MangaSelectionForm(Customer customer, MangaRepository mangaRepository, OrdersRepository ordersRepository, OrderDetailsRepository orderDetailsRepository)
        {
            InitializeComponent();
            _customer = customer;
            _mangaRepository = mangaRepository;
            _ordersRepository = ordersRepository;
            lblCustomerName.Text = $"Ласкаво просимо, {_customer.Name}";
            _orderDetailsRepository = orderDetailsRepository;
        }

        private async void MangaSelectionForm_Load(object sender, EventArgs e)
        {
            await InitManga();
            await InitOrders();
        }

        private async Task ShowOrderDetails(int orderId)
        {
            OrderDetailsForm detailsForm = new OrderDetailsForm(orderId, _orderDetailsRepository, _ordersRepository);
            detailsForm.ShowDialog();
        }

        private async void btnViewOrderDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.CurrentRow is not null)
            {
                int orderId = Convert.ToInt32(dataGridViewOrders.CurrentRow.Cells["OrderID"].Value);
                await ShowOrderDetails(orderId);
            }
        }

        private async Task InitManga()
        {
            var mangas = await _mangaRepository.GetMangaIncludeAllAsync();
            dataGridViewManga.DataSource = mangas.Select(m => new
            {
                m.MangaID,
                m.Title,
                AuthorName = m.Author.Name,
                PublisherName = m.Publisher.Name,
                m.Genre.Description,
                m.PublicationDate,
                m.Price
            }).ToList();
        }

        private async Task InitOrders()
        {

            var orders = await _ordersRepository.GetOrdersByCustomerId(_customer.CustomerID);

            dataGridViewOrders.DataSource = orders
                .Where(o => o.CustomerID == _customer.CustomerID)
                .Select(o => new { o.OrderID, o.OrderDate, o.TotalAmount }).ToList();
        }

        private async void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewManga.CurrentRow is not null)
            {
                int mangaId = Convert.ToInt32(dataGridViewManga.CurrentRow.Cells["MangaID"].Value);
                await CreateOrderForManga(mangaId);
            }
        }

        private async Task CreateOrderForManga(int mangaId)
        {
            var existingManga = await _mangaRepository.GetByIdAsync(mangaId);

            if (existingManga is null)
            {
                throw new Exception("CreateOrderForManga. Manga is null");
            }

            var existingOrder = (await _ordersRepository.GetOrdersByCustomerId(_customer.CustomerID)).FirstOrDefault();

            if (existingOrder is null)
            {
                existingOrder = new Order { CustomerID = _customer.CustomerID, OrderDate = DateTime.Now, TotalAmount = 0 };
                await _ordersRepository.AddAsync(existingOrder);
            }

            var existingOrderDetail = (await _orderDetailsRepository
                .GetOrderDetailsByOrderId(existingOrder.OrderID))
                .FirstOrDefault(detail => detail.MangaID == mangaId);

            if (existingOrderDetail is null)
            {
                var orderDetail = new OrderDetail
                {
                    OrderID = existingOrder.OrderID,
                    MangaID = mangaId,
                    Quantity = 1,
                    PricePerItem = existingManga.Price
                };

                await _orderDetailsRepository.AddAsync(orderDetail);
            }
            else
            {
                existingOrderDetail.Quantity++;
                await _orderDetailsRepository.UpdateAsync(existingOrderDetail);

            }

            existingOrder.TotalAmount += existingManga.Price;
            await _ordersRepository.UpdateAsync(existingOrder);

            await InitOrders();
        }

        private async void updateOrders_Click(object sender, EventArgs e)
        {
            await InitOrders();
        }
    }
}
