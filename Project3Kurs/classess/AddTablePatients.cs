using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project3Kurs.classess
{
    internal class AddTablePatients
    {
        public void MethodAddTablePatients(PrimaryWindow onePrimaryWindow)
        {
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection("server=FULLDEV\\SQLEXPRESS;Trusted_Connection=Yes;DataBase=ProjectKurs3;");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "Insert into patients (PatientFIO,PatientPol,PatientDateOfBirth,PatientAge,PatientTelephoneNumber)values(@PatientFIO,@PatientPol,@PatientDateOfBirth,@PatientAge,@PatientTelephoneNumber)";
            sqlCommand.Parameters.AddWithValue("@PatientFIO", onePrimaryWindow.PatientFIOPatients.Text);
            sqlCommand.Parameters.AddWithValue("@PatientPol", onePrimaryWindow.PatientPolPatients.Text);
            sqlCommand.Parameters.AddWithValue("@PatientDateOfBirth", onePrimaryWindow.PatientDateOfBirthPatients.Text);
            sqlCommand.Parameters.AddWithValue("@PatientAge", onePrimaryWindow.PatientAgePatients.Text);
            sqlCommand.Parameters.AddWithValue("@PatientTelephoneNumber", onePrimaryWindow.PatientTelephoneNumberPatients.Text);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            classess.CompetitionTablePatients oneCompletionTablePatient = new classess.CompetitionTablePatients();
            oneCompletionTablePatient.MethodCompetitionTablePatient(onePrimaryWindow);
        }
    }
}
