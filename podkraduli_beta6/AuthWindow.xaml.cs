using podkraduli_beta6;
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

namespace podkraduli_beta3
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }
        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass = passBox.Password.Trim();


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

            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;

              

                var CurrentUser = AppData.db.user.FirstOrDefault(u => u.login == textBoxLogin.Text && u.password == passBox.Password);
               

                
                if (CurrentUser != null)
                {
                    if (CurrentUser.role_Id == 1)
                    {
                        MessageBox.Show("ОК");
                        UserPageWindow userPageWindow = new UserPageWindow();
                        userPageWindow.Show();
                        Hide();
                    }
                    else
                    {
                        ShopWindow shopPanel = new ShopWindow();
                        shopPanel.Show();
                        Hide();
                    }
                }

                else
                    MessageBox.Show("Не удалось");



            }
        }
            private void Button_Reg_Click(object sender, RoutedEventArgs e)
            {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    }
}
  