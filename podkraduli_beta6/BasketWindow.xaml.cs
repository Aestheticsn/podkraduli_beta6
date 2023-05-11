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
    /// Логика взаимодействия для Basket.xaml
    /// </summary>
    public partial class BasketWindow : Window
    {
        public BasketWindow()
        {
            InitializeComponent();
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить данного пользователя", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                
            }
        }

        private void Button_Click_shop(object sender, RoutedEventArgs e)
        {
            ShopWindow shopWindow = new ShopWindow();
            shopWindow.Show();
            this.Hide();
        }
    }
}
