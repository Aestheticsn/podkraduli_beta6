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
    /// Логика взаимодействия для userPageWindow.xaml
    /// </summary>
    public partial class UserPageWindow : Window
    {
        public UserPageWindow()
        {
            InitializeComponent();
        }

       

        private void Button_Click_exit(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UsersGrid.ItemsSource = AppData.db.user.ToList();
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            newUserWindow newuserWindow = new newUserWindow();
            newuserWindow.Show();
            Hide();
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить данного пользователя", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var CurrentUser = UsersGrid.SelectedItem as user;
                AppData.db.user.Remove(CurrentUser);
                AppData.db.SaveChanges();
                UsersGrid.ItemsSource = AppData.db.user.ToList();
                MessageBox.Show("Успех");
            }
        }

       

        private void Button_Click_tovar(object sender, RoutedEventArgs e)
        {
            TovarWindow tovarWindow = new TovarWindow();
            tovarWindow.Show();
            Hide();

        }
    }
}
