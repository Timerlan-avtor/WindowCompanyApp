using System.Linq;
using System.Windows.Controls;

namespace WindowCompanyApp
{
    public partial class EmployeesPage : Page
    {
        private Галерея_оконEntities db = new Галерея_оконEntities();

        public EmployeesPage()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var employees = db.employees.ToList();
            dgEmployees.ItemsSource = employees;
        }
    }
}