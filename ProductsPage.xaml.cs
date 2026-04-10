using System.Linq;
using System.Windows.Controls;

namespace WindowCompanyApp
{
    public partial class ProductsPage : Page
    {
        private Галерея_оконEntities db = new Галерея_оконEntities();

        public ProductsPage()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var products = db.products.ToList();
            dgProducts.ItemsSource = products;
        }
    }
}