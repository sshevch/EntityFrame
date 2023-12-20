using EntityFrame.Entities;
using EntityFrame.Forms;
using EntityFrame.Persistence.Repositories;
using EntityFrame.Persistence;

namespace EntityFrame
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var dbContext = new MangaStoreDbContext();
            var customerRepository = new GenericRepository<Customer>(dbContext);
            var mangaRepository = new MangaRepository(dbContext);
            var ordersRepository = new OrdersRepository(dbContext);
            var orderDetailsRepository = new OrderDetailsRepository(dbContext);

            Application.Run(new LoginForm(customerRepository, mangaRepository, ordersRepository, orderDetailsRepository));
        }
    }
}