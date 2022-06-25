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
using System.Data;
using System.Data.SqlClient;

namespace Project3Kurs
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ButtonExitAuthorizationWindow_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void ButtonShowPassAuthorizationWindow_Click(object sender, RoutedEventArgs e)
        {
            ShowHidePassClass oneShowHidePassClass = new classes.ShowHidePassClass();
            oneShowHidePassClass.ShowPassClick(this);
            Button buttonShowPass = sender as Button;
            buttonShowPass.Click -= new RoutedEventHandler(ButtonShowPassAuthorizationWindow_Click);
            buttonShowPass.Click += new RoutedEventHandler(ButtonShowPassAuthorizationWindow_Click_1);
        }

        public void ButtonShowPassAuthorizationWindow_Click_1(object sender, RoutedEventArgs e)
        {
            classes.ShowHidePassClass oneShowHidePassClass = new classes.ShowHidePassClass();
            oneShowHidePassClass.HidePassClick(this);
            Button buttonShowPass = sender as Button;
            buttonShowPass.Click += new RoutedEventHandler(ButtonShowPassAuthorizationWindow_Click);
            buttonShowPass.Click -= new RoutedEventHandler(ButtonShowPassAuthorizationWindow_Click_1);
        }

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            /*  if (PasswordAuthorizationTextBox.Text.Length > 0)
              {
                  PasswordAuthorizationPasswordBox.Password = PasswordAuthorizationTextBox.Text;
              }

              Class.FirstConnectClass firstConnect = new Class.FirstConnectClass();
              DataTable dt_StroyCompany = firstConnect.Select("SELECT * FROM [dbo].[users] WHERE [login] = '" + LoginAuthorizationTextBox.Text + "' AND [password] = '" + PasswordAuthorizationPasswordBox.Password + "'");
              if (LoginAuthorizationTextBox.Text.Length <= 0)
              {
                  MessageBox.Show("Вы не ввели логин!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
              }
              else if (PasswordAuthorizationPasswordBox.Password.Length <= 0)
              {
                  MessageBox.Show("Вы не ввели пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                  LoginAuthorizationTextBox.Clear();
              }
              else if (dt_StroyCompany.Rows.Count > 0)
              {
                  PrimaryWindow onePrimaryWindow = new PrimaryWindow();
                  onePrimaryWindow.Owner = this;

                  oneCatalog.LabelCatalogFirstNameAcc.Content = dt_StroyCompany.Rows[0][5].ToString();
                   oneCatalog.LabelCatalogLastNameAcc.Content = dt_StroyCompany.Rows[0][6].ToString();
                   oneCatalog.LabelCatalogPositionAcc.Content = dt_StroyCompany.Rows[0][1].ToString();
                   oneCatalog.ImageCatalogAcc.Source = new BitmapImage(new Uri(dt_StroyCompany.Rows[0][4].ToString()));
                  onePrimaryWindow.Show();
                  this.Hide();
              }
              else
              {
                  MessageBox.Show("Неверные данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                  PasswordAuthorizationTextBox.Clear();
                  LoginAuthorizationTextBox.Clear();
                  PasswordAuthorizationPasswordBox.Clear();
              }

            
            classes.CheckLogPassClass oneCheckLogPassClass = new classes.CheckLogPassClass();
            int result = oneCheckLogPassClass.CheckLogPass(x);*/
            
        }
    }
}
