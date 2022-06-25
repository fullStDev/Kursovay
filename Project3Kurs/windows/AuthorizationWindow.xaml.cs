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

        private void ButtonCloseAuthorizationWindow_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void ButtonShowPassAuthorizationWindow_Click(object sender, RoutedEventArgs e)
        {
            classess.ShowHidePassClass oneShowHidePassClass = new classess.ShowHidePassClass();
            oneShowHidePassClass.ShowPassClick(this);
            Button buttonShowHidePass = sender as Button;
            buttonShowHidePass.Click -= new RoutedEventHandler(ButtonShowPassAuthorizationWindow_Click);
            buttonShowHidePass.Click += new RoutedEventHandler(ButtonShowPassAuthorizationWindow_Click_1);
        }

        public void ButtonShowPassAuthorizationWindow_Click_1(object sender, RoutedEventArgs e)
        {
            classess.ShowHidePassClass oneShowHidePassClass = new classess.ShowHidePassClass();
            oneShowHidePassClass.HidePassClick(this);
            Button buttonShowHidePass = sender as Button;
            buttonShowHidePass.Click += new RoutedEventHandler(ButtonShowPassAuthorizationWindow_Click);
            buttonShowHidePass.Click -= new RoutedEventHandler(ButtonShowPassAuthorizationWindow_Click_1);
        }

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            classess.CheckLogPassClass oneCheckLogPassClass = new classess.CheckLogPassClass();
            oneCheckLogPassClass.CheckLogPass(this);
        }

    }
}
