using System.Linq;
using System.Windows.Controls;

namespace WindowCompanyApp
{
    public partial class OrdersPage : Page
    {
        private Галерея_оконEntities db = new Галерея_оконEntities();

        public OrdersPage()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var orders = db.orders
                .Select(o => new
                {
                    o.id,
                    Клиент = o.clients.full_name,
                    Менеджер = o.employees.full_name,
                    o.order_date,
                    o.total_price,
                    Статус = o.order_statuses.status_name
                })
                .ToList();
            dgOrders.ItemsSource = orders;
        }
    }
}