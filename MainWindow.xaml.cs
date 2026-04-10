using System.Windows;

namespace WindowCompanyApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Загружаем страницу с клиентами по умолчанию
            MainFrame.Navigate(new ClientsPage());
            StatusText.Text = "Загружена страница клиентов";
        }

        private void btnClients_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ClientsPage());
            StatusText.Text = "📋 Показаны клиенты";
        }

        private void btnOrders_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new OrdersPage());
            StatusText.Text = "📦 Показаны заказы";
        }

        private void btnProducts_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductsPage());
            StatusText.Text = "🪟 Показана продукция";
        }

        private void btnEmployees_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new EmployeesPage());
            StatusText.Text = "👥 Показаны сотрудники";
        }
    }
}