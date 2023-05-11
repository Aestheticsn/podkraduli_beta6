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
    /// Логика взаимодействия для NewTovarWindow.xaml
    /// </summary>
    public partial class NewTovarWindow : Window
    {
        public NewTovarWindow()
        {
            InitializeComponent();
            Brand_ComboBox.ItemsSource = AppData.db.brand.ToList(); 
        }

       

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            podkradulya product = new podkradulya();
            product.name = TitleTextBox.Text;
            product.price = Price_TextBox.Text;
            
            var CurrentBrand = Brand_ComboBox.SelectedItem as brand;
            product.brand = CurrentBrand;
            AppData.db.podkradulya.Add(product);
            AppData.db.SaveChanges();
            UserPageWindow userPageWindow = new UserPageWindow();
            userPageWindow.Show();
            Hide();
        }

        private void Button_Click_exit(object sender, RoutedEventArgs e)
        {
            TovarWindow tovarWindow = new TovarWindow();
            tovarWindow.Show();
            Hide();
        }
    }
}
