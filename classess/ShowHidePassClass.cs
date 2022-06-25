using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Project3Kurs.Class
{
    internal class ShowHidePassClass
    {
        public void ShowPassClick(AuthorizationWindow authorizationWindow)
        {
            authorizationWindow.EyeWindow.Kind = MaterialDesignThemes.Wpf.PackIconKind.EyeOff;
            authorizationWindow.PasswordAuthorizationTextBox.Text = authorizationWindow.PasswordAuthorizationPasswordBox.Password;
            authorizationWindow.PasswordAuthorizationTextBox.Visibility = Visibility.Visible;
            authorizationWindow.PasswordAuthorizationPasswordBox.Visibility = Visibility.Hidden;
        }

        public void HidePassClick(AuthorizationWindow authorizationWindow)
        {
            authorizationWindow.EyeWindow.Kind = MaterialDesignThemes.Wpf.PackIconKind.Eye;
            authorizationWindow.PasswordAuthorizationPasswordBox.Password = authorizationWindow.PasswordAuthorizationTextBox.Text;
            authorizationWindow.PasswordAuthorizationTextBox.Visibility = Visibility.Hidden;
            authorizationWindow.PasswordAuthorizationPasswordBox.Visibility = Visibility.Visible;
        }
    }
}
