using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows;

namespace Project3Kurs.classess
{
    internal class CompetitionTableServices
    {
        internal class Rents
        {
            public string id_Services { get; set; }
            public string JobTitle { get; set; }
            public string ServicesTitle { get; set; }

        }
        public void MethodCompetitionTableServices(PrimaryWindow onePrimaryWindow)
        {
            onePrimaryWindow.ListPrimaryDoctors.Visibility = Visibility.Hidden;
            onePrimaryWindow.DoctorFIODoctors.Visibility = Visibility.Hidden;
            onePrimaryWindow.DoctorPositionDoctors.Visibility = Visibility.Hidden;
            onePrimaryWindow.DoctorCabinetDoctors.Visibility = Visibility.Hidden;
            onePrimaryWindow.ButtonAddDoctors.Visibility = Visibility.Hidden;
            onePrimaryWindow.ButtonDeleteDoctors.Visibility = Visibility.Hidden;


            onePrimaryWindow.ListPrimaryShedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.ButtonAddSchedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.ButtonDeleteSchedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.DateVisitShedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.DoctorCabinetSchedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.PatientFioSchedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.DoctorFioSchedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.DoctorPositionSchedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.ServiceSchedule.Visibility = Visibility.Hidden;

            onePrimaryWindow.ListPrimaryPatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.ButtonAddPatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.ButtonDeletePatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.PatientFIOPatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.PatientAgePatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.PatientDateOfBirthPatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.PatientPolPatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.PatientTelephoneNumberPatients.Visibility = Visibility.Hidden;

            onePrimaryWindow.ListPrimaryServices.Items.Clear();
            onePrimaryWindow.JobTitleServices.Text = null;
            onePrimaryWindow.ServiceTitleServices.Text = null;

            onePrimaryWindow.ListPrimaryServices.Visibility = Visibility.Visible;
            onePrimaryWindow.JobTitleServices.Visibility = Visibility.Visible;
            onePrimaryWindow.ServiceTitleServices.Visibility = Visibility.Visible;
            onePrimaryWindow.ButtonAddServices.Visibility = Visibility.Visible;
            onePrimaryWindow.ButtonDeleteServices.Visibility = Visibility.Visible;
            classess.FirstConnectClass firstConnect = new classess.FirstConnectClass();
            DataTable dt_StroyCompany = firstConnect.Select("SELECT * FROM [dbo].[services]"); // данные из БД
            for (int i = 0; i < dt_StroyCompany.Rows.Count; i++) // перебираем данные
            {
                Rents Lol = new Rents() // создаём экземпляр класса
                {
                    id_Services = dt_StroyCompany.Rows[i][0].ToString(),
                    JobTitle = dt_StroyCompany.Rows[i][1].ToString(), // указываем изображение из таблицы
                    ServicesTitle = dt_StroyCompany.Rows[i][2].ToString(), // указываем название товара
                };
                onePrimaryWindow.ListPrimaryServices.Items.Add(Lol); // выводим строку в список
            }
        }
    }
}
