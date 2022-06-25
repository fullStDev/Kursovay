using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project3Kurs.windows
{
    internal class CheckLogPassClass
    {
        public int CheckLogPass(AuthorizationWindow authorizationWindow)
        {
              if (authorizationWindow.PasswordAuthorizationTextBox.Text.Length > 0)
              {
                authorizationWindow.PasswordAuthorizationPasswordBox.Password = authorizationWindow.PasswordAuthorizationTextBox.Text;
              }

              Class.FirstConnectClass firstConnect = new Class.FirstConnectClass();
              DataTable dt_StroyCompany = firstConnect.Select("SELECT * FROM [dbo].[users] WHERE [login] = '" + authorizationWindow.LoginAuthorizationTextBox.Text + "' AND [password] = '" + authorizationWindow.PasswordAuthorizationPasswordBox.Password + "'");
              if (authorizationWindow.LoginAuthorizationTextBox.Text.Length <= 0)
              {
                  //MessageBox.Show("Вы не ввели логин!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
              }
              else if (authorizationWindow.PasswordAuthorizationPasswordBox.Password.Length <= 0)
              {
                //MessageBox.Show("Вы не ввели пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                authorizationWindow.LoginAuthorizationTextBox.Clear();
              }
              else if (dt_StroyCompany.Rows.Count > 0)
              {
                  PrimaryWindow onePrimaryWindow = new PrimaryWindow();
                  onePrimaryWindow.Owner = authorizationWindow;

                   /*oneCatalog.LabelCatalogFirstNameAcc.Content = dt_StroyCompany.Rows[0][5].ToString();
                   oneCatalog.LabelCatalogLastNameAcc.Content = dt_StroyCompany.Rows[0][6].ToString();
                   oneCatalog.LabelCatalogPositionAcc.Content = dt_StroyCompany.Rows[0][1].ToString();
                   oneCatalog.ImageCatalogAcc.Source = new BitmapImage(new Uri(dt_StroyCompany.Rows[0][4].ToString()));
                  onePrimaryWindow.Show();*/
                  authorizationWindow.Hide();
              }
              else
              {
                 //MessageBox.Show("Неверные данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                 authorizationWindow.PasswordAuthorizationTextBox.Clear();
                 authorizationWindow.LoginAuthorizationTextBox.Clear();
                 authorizationWindow.PasswordAuthorizationPasswordBox.Clear();
              }
        }
    }
}
