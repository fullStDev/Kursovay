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
    internal class CompetitionTableShedule
    {
        internal class Rents
        {
            public string id_Visit { get; set; }
            public string DateVisit { get; set; }
            public string DoctorCabinet { get; set; }
            public string PatientFio { get; set; }
            public string DoctorFio { get; set; }
            public string DoctorPosition { get; set; }
            public string Services { get; set; }

        }
        public void MethodCompetitionTableShedule(PrimaryWindow onePrimaryWindow)
        {
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

            onePrimaryWindow.ListPrimaryPatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.ButtonAddPatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.ButtonDeletePatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.PatientFIOPatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.PatientAgePatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.PatientDateOfBirthPatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.PatientPolPatients.Visibility = Visibility.Hidden;
            onePrimaryWindow.PatientTelephoneNumberPatients.Visibility = Visibility.Hidden;


            onePrimaryWindow.DateVisitShedule.Text = null;
            onePrimaryWindow.ListPrimaryShedule.Items.Clear();
            onePrimaryWindow.DoctorCabinetSchedule.Items.Clear();
            onePrimaryWindow.PatientFioSchedule.Items.Clear();
            onePrimaryWindow.DoctorFioSchedule.Items.Clear();
            onePrimaryWindow.DoctorPositionSchedule.Items.Clear();
            onePrimaryWindow.ServiceSchedule.Items.Clear();
            onePrimaryWindow.DateVisitShedule.Visibility = Visibility.Visible;
            onePrimaryWindow.ListPrimaryShedule.Visibility = Visibility.Visible;
            onePrimaryWindow.DoctorCabinetSchedule.Visibility = Visibility.Visible;
            onePrimaryWindow.PatientFioSchedule.Visibility = Visibility.Visible;
            onePrimaryWindow.DoctorFioSchedule.Visibility = Visibility.Visible;
            onePrimaryWindow.DoctorPositionSchedule.Visibility = Visibility.Visible;
            onePrimaryWindow.ServiceSchedule.Visibility = Visibility.Visible;
            onePrimaryWindow.ButtonAddSchedule.Visibility = Visibility.Visible;
            onePrimaryWindow.ButtonDeleteSchedule.Visibility = Visibility.Visible;
            classess.FirstConnectClass firstConnect = new classess.FirstConnectClass();
            DataTable dt_schedule = firstConnect.Select("SELECT * FROM [dbo].[schedule]"); // данные из БД
            for (int i = 0; i < dt_schedule.Rows.Count; i++) // перебираем данные
            {
                Rents Lol = new Rents() // создаём экземпляр класса
                {
                    id_Visit = dt_schedule.Rows[i][0].ToString(),
                    DateVisit = dt_schedule.Rows[i][1].ToString(), // указываем изображение из таблицы
                    DoctorCabinet = dt_schedule.Rows[i][2].ToString(), // указываем название товара
                    PatientFio = dt_schedule.Rows[i][3].ToString(), // указываем описание
                    DoctorFio = dt_schedule.Rows[i][4].ToString(), // указываем наличие
                    DoctorPosition = dt_schedule.Rows[i][5].ToString(),
                    Services = dt_schedule.Rows[i][5].ToString()// указываем наличие
                };
                Lol.DateVisit = Lol.DateVisit.TrimEnd(':', '0');
                onePrimaryWindow.ListPrimaryShedule.Items.Add(Lol); // выводим строку в список
            }

            DataTable dt_doctors = firstConnect.Select("SELECT * FROM [dbo].[doctors]"); // данные из БД
            for (int i = 0; i < dt_doctors.Rows.Count; i++) // перебираем данные
            {
                onePrimaryWindow.DoctorFioSchedule.Items.Add(dt_doctors.Rows[i][1].ToString());
                onePrimaryWindow.DoctorPositionSchedule.Items.Add(dt_doctors.Rows[i][2].ToString());
                onePrimaryWindow.DoctorCabinetSchedule.Items.Add(dt_doctors.Rows[i][3].ToString()); 
            }

            DataTable dt_patients = firstConnect.Select("SELECT * FROM [dbo].[patients]"); // данные из БД
            for (int i = 0; i < dt_patients.Rows.Count; i++) // перебираем данные
            {
                onePrimaryWindow.PatientFioSchedule.Items.Add(dt_patients.Rows[i][1].ToString());
            }

            DataTable dt_services = firstConnect.Select("SELECT * FROM [dbo].[services]"); // данные из БД
            for (int i = 0; i < dt_services.Rows.Count; i++) // перебираем данные
            {
                onePrimaryWindow.ServiceSchedule.Items.Add(dt_services.Rows[i][2].ToString());
            }

        }
    }
}
