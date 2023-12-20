using EntityFrame.Entities;
using EntityFrame.Persistence.Interfaces;
using EntityFrame.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrame.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IGenericRepository<Customer> _customerRepository;
        private readonly MangaRepository _mangaRepository;
        private readonly OrdersRepository _ordersRepository;
        private readonly OrderDetailsRepository _orderDetailsRepository;

        public LoginForm(
            IGenericRepository<Customer> customerRepository,
            MangaRepository mangaRepository,
            OrdersRepository ordersRepository,
            OrderDetailsRepository orderDetailsRepository)
        {
            InitializeComponent();
            _customerRepository = customerRepository;
            _mangaRepository = mangaRepository;
            _ordersRepository = ordersRepository;
            _orderDetailsRepository = orderDetailsRepository;
        }

        private async void btnLogin_Click_1(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var customer = await _customerRepository.FindAsync(c => c.Email == email);

            if (customer != null)
            {
                MangaSelectionForm selectionForm = new MangaSelectionForm(customer, _mangaRepository, _ordersRepository, _orderDetailsRepository);
                this.Hide();
                selectionForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Користувача з таким email не знайдено.", "Помилка входу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

