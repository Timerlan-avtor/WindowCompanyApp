using System;
using System.Linq;
using System.Windows.Controls;

namespace WindowCompanyApp
{
    public partial class ClientsPage : Page
    {
        private Галерея_оконEntities db = new Галерея_оконEntities();

        public ClientsPage()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Проверяем, есть ли подключение к БД
                DebugText.Text = "Загрузка данных...";

                var clients = db.clients.ToList();

                // Показываем, сколько записей найдено
                DebugText.Text = $"Найдено записей: {clients.Count}";

                if (clients.Count > 0)
                {
                    dgClients.ItemsSource = clients;
                }
                else
                {
                    DebugText.Text = "Нет данных в таблице clients!";
                }
            }
            catch (Exception ex)
            {
                DebugText.Text = $"Ошибка: {ex.Message}";
            }
        }
    }
}