using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project3Kurs.classess
{
    internal class AddTableDoctors
    {
        public void MethodAddTableDoctors(PrimaryWindow onePrimaryWindow)
        {
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection("server=FULLDEV\\SQLEXPRESS;Trusted_Connection=Yes;DataBase=ProjectKurs3;");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "Insert into doctors (DoctorFIO,DoctorPosition,DoctorCabinet)values(@DoctorFIO,@DoctorPosition,@DoctorCabinet)";
            sqlCommand.Parameters.AddWithValue("@DoctorFIO", onePrimaryWindow.DoctorFIODoctors.Text);
            sqlCommand.Parameters.AddWithValue("@DoctorPosition", onePrimaryWindow.DoctorPositionDoctors.Text);
            sqlCommand.Parameters.AddWithValue("@DoctorCabinet", onePrimaryWindow.DoctorCabinetDoctors.Text);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            classess.CompetitionTableDoctors oneCompetitionTableDoctors = new classess.CompetitionTableDoctors();
            oneCompetitionTableDoctors.MethodCompetitionTableDoctors(onePrimaryWindow);
        }
    }
}
