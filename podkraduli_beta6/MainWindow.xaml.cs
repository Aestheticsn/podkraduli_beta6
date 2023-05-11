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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace podkraduli_beta6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass = passBox.Password.Trim();
            string pass_2 = passBox_2.Password.Trim();
            string email = textBoxEmail.Text.ToLower().Trim();
            if (login.Length < 5)
            {
                textBoxLogin.ToolTip = "неверно";
                textBoxLogin.Background = Brushes.DarkRed;
            }
            else if (pass.Length < 5)
            {
                passBox.ToolTip = "неверно";
                passBox.Background = Brushes.DarkRed;
            }
            else if (pass != pass_2)
            {
                passBox_2.ToolTip = "неверно";
                passBox_2.Background = Brushes.DarkRed;

            }
            else if (email.Length < 5)
            {
                textBoxEmail.ToolTip = "неверно";
                textBoxEmail.Background = Brushes.DarkRed;
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox_2.Background = Brushes.Transparent;
                passBox_2.ToolTip = "";
                passBox_2.Background = Brushes.Transparent;
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;
                MessageBox.Show("Процесс регистрации");

                user User = new user();
                User.login = textBoxLogin.Text;
                User.password = passBox.Password.ToString();
                User.email = textBoxEmail.Text;
                User.role_Id = 0;
                

                AppData.db.user.Add(User);
                AppData.db.SaveChanges();
                MessageBox.Show("Пользователь был добавлен в базу, теперь вы можете войти");
                
            }
        }

        private void Button_Window_Auth_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            this.Hide();
        }

       
    }
}

