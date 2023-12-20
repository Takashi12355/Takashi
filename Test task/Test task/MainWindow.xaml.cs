using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Test_task;

namespace Test_task
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SQL sql = new SQL();
        List<string> sites = new List<string>() { "Moscow", "Kiev" };// Коллекция для ComboBox для первой части задания
        List<string> tasks = new List<string>() { "Менеджера у которых есть номера телефонов", 
            "Кол-во продаж за 20 июня 2021",
            "Средняя сумма продажи с товаром Фанера",
            "Фамилии менежрево и общая сумма продаж для товара ОСБ",
            "Менеджера и товар который продали 22 августа 2021",
            "Товары Фанера и цена не ниже 1750",
            "Вывести историю продажи товаров, группируя по месяцу и наименованию",
            "Количество повторяющихся значений Товаров, где кол-во пов. больше 1"}; // Коллекция для ComboBox для второй части задания
        public MainWindow()
        {
            InitializeComponent();
            SitesComboBox.ItemsSource = sites;
            TasksComboBox.ItemsSource = tasks;
        }

        public async void Button_Click(object sender, RoutedEventArgs e)//При нажатии выводит значение полученные по API
        {
            if (SitesComboBox.Text != "")
            {
                string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q=" + SitesComboBox.Text + "&units=metric&APPID=273255c7079b5bee2bc01ff671ab0216";
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        JObject data = JObject.Parse(json);
                        double temperature = (double)data["main"]["temp"];
                        string description = (string)data["weather"][0]["description"];
                        double windSpeed = (double)data["wind"]["speed"];
                        TemperatureLabel.Content = $"{temperature}°C";
                        DescriptionLabel.Content = description;
                        WindSpeedLabel.Content = $"{windSpeed} m/s";
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка при получении данных: {response.StatusCode}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Не выбран город");
            }
        }

        private void TasksComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)//При выборе значения выбирвется запрос
        {
            switch (e.AddedItems[0].ToString())
            {
                case "Менеджера у которых есть номера телефонов":
                    TableTasksDataGrid.ItemsSource = null;
                    TableTasksDataGrid.ItemsSource = sql.CommandSelectCondition("*", "Managers", "Phone IS NOT NULL").DefaultView;
                    break;
                case "Кол-во продаж за 20 июня 2021":
                    TableTasksDataGrid.ItemsSource = null;
                    TableTasksDataGrid.ItemsSource = sql.CommandSelectCondition("*", "Sells", "Date = '2021-06-21'").DefaultView;
                    break;
                case "Средняя сумма продажи с товаром Фанера":
                    TableTasksDataGrid.ItemsSource = null;
                    TableTasksDataGrid.ItemsSource = sql.CommandSelectCondition("AVG(Sum) AS AverageValue", "Sells", "Id_Products =1").DefaultView;
                    break;
                case "Фамилии менежрево и общая сумма продаж для товара ОСБ":
                    TableTasksDataGrid.ItemsSource = null;
                    TableTasksDataGrid.ItemsSource = sql.CommandSelectCondition("FIO, Sum(Sells.Sum)", "Managers,Sells", "Managers.Id = Sells.Id_Managers and Sells.Id_Products =2 Group by FIO ").DefaultView;
                    break;
                case "Менеджера и товар который продали 22 августа 2021":
                    TableTasksDataGrid.ItemsSource = null;
                    TableTasksDataGrid.ItemsSource = sql.CommandSelect("Select Managers.FIO, Products.Name From Sells Inner JOIN Products on Id_Products = Products.Id Inner JOIN Managers on Id_Managers = Managers.Id Where Sells.Date = '2021-08-22' Order BY Managers.FIO ").DefaultView;
                    break;
                case "Товары Фанера и цена не ниже 1750":
                    TableTasksDataGrid.ItemsSource = null;
                    TableTasksDataGrid.ItemsSource = sql.CommandSelectCondition("*", "Products", "Name LIKE 'Фанера%' and Cost >= 1750").DefaultView;
                    break;
                case "Вывести историю продажи товаров, группируя по месяцу и наименованию":
                    TableTasksDataGrid.ItemsSource = null;
                    TableTasksDataGrid.ItemsSource = sql.CommandSelect("Select Products.Name , Count, Sum,Date From Sells  INNER JOIN Products on Sells.Id_Products = Products.Id Order BY Date, Products.Name").DefaultView;
                    break;
                case "Количество повторяющихся значений Товаров, где кол-во пов. больше 1":
                    TableTasksDataGrid.ItemsSource = null;
                    TableTasksDataGrid.ItemsSource = sql.CommandSelect("Select Products.Name, COUNT(Id_Products) as repeat From Sells INNER JOIN Products on Sells.Id_Products = Products.Id Group by Id_Products, Products.Name Having COUNT(Id_Products)>1").DefaultView;
                    break;
            }
        }
    }
}