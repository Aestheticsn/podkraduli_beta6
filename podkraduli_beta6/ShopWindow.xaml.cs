using podkraduli_beta3;
using podkraduli_beta6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
    /// Логика взаимодействия для ShopPanel.xaml
    /// </summary>
    public partial class ShopWindow : Window
    {
        public ShopWindow()
        {
            InitializeComponent();
        
        }

        private void Window_Loaded(Object sender, RoutedEventArgs e)
        { 
        product_listview.ItemsSource = AppData.db.podkradulya.ToList(); 
        }
        

        private void Basket_Button_Click(object sender, RoutedEventArgs e)
        {

            var CurrentProduct = product_listview.SelectedItem as podkradulya;
            var CurrentUser = AppData.db.user.FirstOrDefault();
            basket_podkradulya basket1 = new basket_podkradulya();
            basket1.podkradulya_Id = CurrentProduct.Id; 
            basket basket2 = new basket();
            basket2.user_Id = CurrentUser.Id;
            
            AppData.db.SaveChanges();
            
        }

        private void Open_Basket_Button_Click(object sender, RoutedEventArgs e)
        {
             BasketWindow basketWindow = new BasketWindow();
            basketWindow.Show();
            this.Hide();
        }

        private void Search_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                product_listview.ItemsSource = AppData.db.podkradulya.Where(item => item.name == Search_TextBox.Text || item.name.Contains(Search_TextBox.Text)).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
