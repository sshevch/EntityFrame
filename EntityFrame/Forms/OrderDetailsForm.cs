using EntityFrame.Entities;
using EntityFrame.Persistence.Interfaces;
using EntityFrame.Persistence.Repositories;
using System.Data;

namespace EntityFrame.Forms
{
    public partial class OrderDetailsForm : Form
    {
        private readonly int _orderId;
        private readonly OrderDetailsRepository _orderDetailsRepository;
        private readonly OrdersRepository _ordersRepository;

        public OrderDetailsForm(int orderId, OrderDetailsRepository orderDetailsRepository, OrdersRepository ordersRepository)
        {
            InitializeComponent();
            _orderId = orderId;
            _orderDetailsRepository = orderDetailsRepository;
            _ordersRepository = ordersRepository;
        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            InitDetails();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            int orderDetailId = Convert.ToInt32(dataGridViewOrderDetails.CurrentRow.Cells["Id"].Value);
            await DeleteOrderDetail(orderDetailId);
        }

        private async Task DeleteOrderDetail(int orderDetailId)
        {

            var orderDetail = await _orderDetailsRepository.GetOrderDetailsById(orderDetailId);

            if(orderDetail == null)
            {
                return;
            }

            var order = await _ordersRepository.GetByIdAsync(orderDetail.OrderID);

            if (order == null)
            {
                return;
            }

            order.TotalAmount -= orderDetail.PricePerItem * orderDetail.Quantity;

            await _orderDetailsRepository.DeleteAsync(orderDetailId);
            await InitDetails();

            await _ordersRepository.UpdateAsync(order);
        }

        private async Task InitDetails()
        {
            var orderDetails = await _orderDetailsRepository.GetOrderDetailsByOrderId(_orderId);

            dataGridViewOrderDetails.DataSource = orderDetails.Select(od => new
            {
                Id = od.OrderDetailID,
                MangaTitle = od.Manga.Title,
                Quantity = od.Quantity,
                PricePerItem = od.PricePerItem,
                TotalPrice = od.Quantity * od.PricePerItem
            }).ToList();
        }
    }
}
