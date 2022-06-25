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
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Project3Kurs
{
    /// <summary>
    /// Логика взаимодействия для PrimaryWindow.xaml
    /// </summary>
    public partial class PrimaryWindow : Window
    {
        public PrimaryWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ButtonClosePrimaryWindow_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); 
        }

        private void ExitButtonToAuthorizationWindow_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow oneAuthorizationWindow = new AuthorizationWindow(); 
            oneAuthorizationWindow.Show();  
            this.Close();
        }

        private void ButtonPatients_Click(object sender, RoutedEventArgs e)
        {
            classess.CompetitionTablePatients oneCompletionTablePatient = new classess.CompetitionTablePatients();
            oneCompletionTablePatient.MethodCompetitionTablePatient(this);
        }

        private void ButtonDoctors_Click(object sender, RoutedEventArgs e)
        {
            classess.CompetitionTableDoctors oneCompetitionTableDoctors = new classess.CompetitionTableDoctors();
            oneCompetitionTableDoctors.MethodCompetitionTableDoctors(this);
        }

        private void ButtonServices_Click(object sender, RoutedEventArgs e)
        {
            classess.CompetitionTableServices oneCompetitionTableServices = new classess.CompetitionTableServices();
            oneCompetitionTableServices.MethodCompetitionTableServices(this);
        }

        private void ButtonShedule_Click(object sender, RoutedEventArgs e)
        {
            classess.CompetitionTableShedule oneCompetitionTableShedule = new classess.CompetitionTableShedule();
            oneCompetitionTableShedule.MethodCompetitionTableShedule(this);
        }

        private void ButtonDeleteSchedule_Click(object sender, RoutedEventArgs e)
        {
            dynamic itemSelectList = ListPrimaryShedule.SelectedItem;
            if (itemSelectList != null)
            {
                classess.DeleteTableSchedule oneDeleteTableSchedule = new classess.DeleteTableSchedule();
                oneDeleteTableSchedule.MethodDeleteTableSchedule(this);
            }
        }

        private void ListPrimaryShedule_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void ButtonAddSchedule_Click(object sender, RoutedEventArgs e)
        {
            classess.AddTableSchedule oneAddTableSchedule = new classess.AddTableSchedule();
            oneAddTableSchedule.MethodAddTableSchedule(this);

        }

        private void ButtonAddPatients_Click(object sender, RoutedEventArgs e)
        {
            classess.AddTablePatients oneAddTablePatients = new classess.AddTablePatients();
            oneAddTablePatients.MethodAddTablePatients(this);
        }

        private void ButtonDeletePatients_Click(object sender, RoutedEventArgs e)
        {
            dynamic itemSelectList = ListPrimaryPatients.SelectedItem;
            if (itemSelectList != null)
            {
                classess.DeleteTablePatients oneDeleteTablePatients = new classess.DeleteTablePatients();
                oneDeleteTablePatients.MethodDeleteTablePatients(this);
            }
        }

        private void ListPrimaryPatients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonAddDoctors_Click(object sender, RoutedEventArgs e)
        {
            classess.AddTableDoctors oneAddTableDoctors = new classess.AddTableDoctors();
            oneAddTableDoctors.MethodAddTableDoctors(this);
        }

        private void ButtonDeleteDoctors_Click(object sender, RoutedEventArgs e)
        {
            dynamic itemSelectList = ListPrimaryDoctors.SelectedItem;
            if (itemSelectList != null)
            {
                classess.DeleteTableDoctors oneDeleteTableDoctors = new classess.DeleteTableDoctors();
                oneDeleteTableDoctors.MethodDeleteTableDoctors(this);
            }
        }

        private void ButtonAddServices_Click(object sender, RoutedEventArgs e)
        {
            classess.AddTableServices oneAddTableServices = new classess.AddTableServices();
            oneAddTableServices.MethodAddTableServices(this);
        }

        private void ButtonDeleteServices_Click(object sender, RoutedEventArgs e)
        {
            dynamic itemSelectList = ListPrimaryServices.SelectedItem;
            if (itemSelectList != null)
            {
                classess.DeleteTableServices oneDeleteTableServices = new classess.DeleteTableServices();
                oneDeleteTableServices.MethodDeleteTableServices(this);
            }
        }
    }
}
