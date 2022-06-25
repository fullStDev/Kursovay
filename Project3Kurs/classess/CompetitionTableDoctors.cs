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
    class CompetitionTableDoctors
    {
        internal class Rents
        {
            public string id_Doctor { get; set; }
            public string DoctorFIO { get; set; }
            public string DoctorPosition { get; set; }
            public string DoctorCabinet { get; set; }

        }
        public void MethodCompetitionTableDoctors(PrimaryWindow onePrimaryWindow)
        {
            onePrimaryWindow.ListPrimaryPatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.ButtonAddPatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.ButtonDeletePatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.PatientFIOPatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.PatientAgePatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.PatientDateOfBirthPatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.PatientPolPatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.PatientTelephoneNumberPatients.Visibility = Visibility.Hidden;

            onePrimaryWindow.ListPrimaryServices.Visibility = Visibility.Hidden;
            onePrimaryWindow.JobTitleServices.Visibility = Visibility.Hidden;
            onePrimaryWindow.ServiceTitleServices.Visibility = Visibility.Hidden;
            onePrimaryWindow.ButtonAddServices.Visibility = Visibility.Hidden;
            onePrimaryWindow.ButtonDeleteServices.Visibility = Visibility.Hidden;

            onePrimaryWindow.ListPrimaryShedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.ButtonAddSchedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.ButtonDeleteSchedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.DateVisitShedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.DoctorCabinetSchedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.PatientFioSchedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.DoctorFioSchedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.DoctorPositionSchedule.Visibility = Visibility.Hidden;
            onePrimaryWindow.ServiceSchedule.Visibility = Visibility.Hidden;

            onePrimaryWindow.ListPrimaryDoctors.Items.Clear();
            onePrimaryWindow.DoctorFIODoctors.Text = null;
            onePrimaryWindow.DoctorPositionDoctors.Text = null;
            onePrimaryWindow.DoctorCabinetDoctors.Text = null;
            onePrimaryWindow.ListPrimaryDoctors.Visibility = Visibility.Visible;
            onePrimaryWindow.DoctorFIODoctors.Visibility = Visibility.Visible;
            onePrimaryWindow.DoctorPositionDoctors.Visibility = Visibility.Visible;
            onePrimaryWindow.DoctorCabinetDoctors.Visibility = Visibility.Visible;
            onePrimaryWindow.ButtonAddDoctors.Visibility = Visibility.Visible;
            onePrimaryWindow.ButtonDeleteDoctors.Visibility = Visibility.Visible;
            classess.FirstConnectClass firstConnect = new classess.FirstConnectClass();
            DataTable dt_StroyCompany = firstConnect.Select("SELECT * FROM [dbo].[doctors]"); // данные из БД
            for (int i = 0; i < dt_StroyCompany.Rows.Count; i++) // перебираем данные
            {
                Rents Lol = new Rents() // создаём экземпляр класса
                {
                    id_Doctor = dt_StroyCompany.Rows[i][0].ToString(),
                    DoctorFIO = dt_StroyCompany.Rows[i][1].ToString(), // указываем изображение из таблицы
                    DoctorPosition = dt_StroyCompany.Rows[i][2].ToString(), // указываем название товара
                    DoctorCabinet = dt_StroyCompany.Rows[i][3].ToString(), // указываем описание
                };
                onePrimaryWindow.ListPrimaryDoctors.Items.Add(Lol); // выводим строку в список
            }
        }
    }
}
