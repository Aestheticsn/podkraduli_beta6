using podkraduli_beta3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace podkraduli_beta6
{
    /// <summary>
    /// Логика взаимодействия для TovarWindow.xaml
    /// </summary>
    public partial class TovarWindow : Window
    {
        public TovarWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_exit(object sender, RoutedEventArgs e)
        {
            UserPageWindow userPageWindow = new UserPageWindow();
            userPageWindow.Show();
            Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ProductGrid.ItemsSource = AppData.db.podkradulya.ToList();
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            NewTovarWindow newTovarWindow = new NewTovarWindow();
            newTovarWindow.Show();
            Hide();
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            var CurrentProduct = ProductGrid.SelectedItem as podkradulya;
            AppData.db.podkradulya.Remove(CurrentProduct);
            AppData.db.SaveChanges();
            ProductGrid.ItemsSource = AppData.db.podkradulya.ToList();
            MessageBox.Show("Успех");
        }

        private void Button_Click_shop(object sender, RoutedEventArgs e)
        {
            ShopWindow shopPanel = new ShopWindow();
            shopPanel.Show();
            Hide();
        }

        private void Button_Click_tovar(object sender, RoutedEventArgs e)
        {

        }
    }
}
