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
    /// Логика взаимодействия для newUserWindow.xaml
    /// </summary>
    public partial class newUserWindow : Window
    {
        public newUserWindow()
        {
            InitializeComponent();
            
        }

        private void Save_admin_Button_Click(object sender, RoutedEventArgs e)
        {
            user people = new user();
            people.login = Login_TextBox.Text; 
            people.password = Password_TextBox.Text;
            people.email = Email_TextBox.Text;
            people.role_Id = 1;
           AppData.db.user.Add(people);
           AppData.db.SaveChanges();
            UserPageWindow userPageWindow = new UserPageWindow();
            userPageWindow.Show();
            Hide();
        }

        private void Save_user_Button_Click(object sender, RoutedEventArgs e)
        {
            user people = new user();
            people.login = Login_TextBox.Text;
            people.password = Password_TextBox.Text;
            people.email = Email_TextBox.Text;
            people.role_Id = 0;
            AppData.db.user.Add(people);
            AppData.db.SaveChanges();
            UserPageWindow userPageWindow = new UserPageWindow();
            userPageWindow.Show();
            Hide();
        }

        private void Button_Click_exit(object sender, RoutedEventArgs e)
        {
            UserPageWindow userPageWindow = new UserPageWindow();
            userPageWindow.Show();
            Hide();
        }
    }
}
