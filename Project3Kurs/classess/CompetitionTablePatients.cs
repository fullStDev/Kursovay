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
    internal class CompetitionTablePatients
    {
        internal class Rents
        {
            public string id_Patient { get; set; }
            public string PatientFIO { get; set; }
            public string PatientPol { get; set; }
            public string PatientDateOfBirth { get; set; }
            public string PatientAge { get; set; }
            public string PatientTelephoneNumber { get; set; }

        }
        public void MethodCompetitionTablePatient(PrimaryWindow onePrimaryWindow)
        {
            onePrimaryWindow.ButtonAddSchedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.ButtonDeleteSchedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.DateVisitShedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.DoctorCabinetSchedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.PatientFioSchedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.DoctorFioSchedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.DoctorPositionSchedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.ServiceSchedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.ListPrimaryShedule.Visibility = Visibility.Hidden;


            onePrimaryWindow.ListPrimaryDoctors.Visibility = Visibility.Hidden;
            onePrimaryWindow.DoctorFIODoctors.Visibility = Visibility.Hidden;
            onePrimaryWindow.DoctorPositionDoctors.Visibility = Visibility.Hidden;
            onePrimaryWindow.DoctorCabinetDoctors.Visibility = Visibility.Hidden;
            onePrimaryWindow.ButtonAddDoctors.Visibility = Visibility.Hidden;
            onePrimaryWindow.ButtonDeleteDoctors.Visibility = Visibility.Hidden;

            onePrimaryWindow.ListPrimaryServices.Visibility = Visibility.Hidden;
            onePrimaryWindow.JobTitleServices.Visibility = Visibility.Hidden;
            onePrimaryWindow.ServiceTitleServices.Visibility = Visibility.Hidden;
            onePrimaryWindow.ButtonAddServices.Visibility = Visibility.Hidden;
            onePrimaryWindow.ButtonDeleteServices.Visibility = Visibility.Hidden;

            onePrimaryWindow.ListPrimaryPatients.Items.Clear();
            onePrimaryWindow.PatientFIOPatients.Text = null;
            onePrimaryWindow.PatientAgePatients.Text = null;
            onePrimaryWindow.PatientDateOfBirthPatients.Text = null;
            onePrimaryWindow.PatientPolPatients.Text = null;
            onePrimaryWindow.PatientTelephoneNumberPatients.Text = null;

            onePrimaryWindow.ListPrimaryPatients.Visibility = Visibility.Visible;
            onePrimaryWindow.ButtonAddPatients.Visibility = Visibility.Visible;
            onePrimaryWindow.ButtonDeletePatients.Visibility = Visibility.Visible;
            onePrimaryWindow.PatientFIOPatients.Visibility = Visibility.Visible;
            onePrimaryWindow.PatientAgePatients.Visibility = Visibility.Visible;
            onePrimaryWindow.PatientDateOfBirthPatients.Visibility = Visibility.Visible;
            onePrimaryWindow.PatientPolPatients.Visibility = Visibility.Visible;
            onePrimaryWindow.PatientTelephoneNumberPatients.Visibility = Visibility.Visible;
            classess.FirstConnectClass firstConnect = new classess.FirstConnectClass();
            DataTable dt_StroyCompany = firstConnect.Select("SELECT * FROM [dbo].[patients]"); // данные из БД
            for (int i = 0; i < dt_StroyCompany.Rows.Count; i++) // перебираем данные
            {
                Rents Lol = new Rents() // создаём экземпляр класса
                {
                    id_Patient = dt_StroyCompany.Rows[i][0].ToString(),
                    PatientFIO = dt_StroyCompany.Rows[i][1].ToString(), // указываем изображение из таблицы
                    PatientPol = dt_StroyCompany.Rows[i][2].ToString(), // указываем название товара
                    PatientDateOfBirth = dt_StroyCompany.Rows[i][3].ToString(), // указываем описание
                    PatientAge = dt_StroyCompany.Rows[i][4].ToString(), // указываем наличие
                    PatientTelephoneNumber = dt_StroyCompany.Rows[i][5].ToString() // указываем наличие
               };
                Lol.PatientDateOfBirth = Lol.PatientDateOfBirth.TrimEnd(':', '0');
                onePrimaryWindow.ListPrimaryPatients.Items.Add(Lol); // выводим строку в список
            }
        }
    }
}
