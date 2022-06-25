using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Project3Kurs.classess
{
    internal class AddTableSchedule
    {
        public void MethodAddTableSchedule(PrimaryWindow onePrimaryWindow)
        {
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection("server=FULLDEV\\SQLEXPRESS;Trusted_Connection=Yes;DataBase=ProjectKurs3;");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "Insert into schedule (DateVisit,DoctorCabinet,PatientFio,DoctorFio,DoctorPosition,Service)values(@DateVisit,@DoctorCabinet,@PatientFio,@DoctorFio,@DoctorPosition,@Service)";
            sqlCommand.Parameters.AddWithValue("@DateVisit", onePrimaryWindow.DateVisitShedule.Text);
            sqlCommand.Parameters.AddWithValue("@DoctorCabinet", onePrimaryWindow.DoctorCabinetSchedule.Text);
            sqlCommand.Parameters.AddWithValue("@PatientFio", onePrimaryWindow.PatientFioSchedule.Text);
            sqlCommand.Parameters.AddWithValue("@DoctorFio", onePrimaryWindow.DoctorFioSchedule.Text);
            sqlCommand.Parameters.AddWithValue("@DoctorPosition", onePrimaryWindow.DoctorPositionSchedule.Text);
            sqlCommand.Parameters.AddWithValue("@Service", onePrimaryWindow.ServiceSchedule.Text);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            classess.CompetitionTableShedule oneCompetitionTableShedule = new classess.CompetitionTableShedule();
            oneCompetitionTableShedule.MethodCompetitionTableShedule(onePrimaryWindow);
        }
    }
}
