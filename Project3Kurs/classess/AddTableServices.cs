using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project3Kurs.classess
{
    internal class AddTableServices
    {
        public void MethodAddTableServices(PrimaryWindow onePrimaryWindow)
        {
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection("server=FULLDEV\\SQLEXPRESS;Trusted_Connection=Yes;DataBase=ProjectKurs3;");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "Insert into services (JobTitle,ServiceTitle)values(@JobTitle,@ServiceTitle)";
            sqlCommand.Parameters.AddWithValue("@JobTitle", onePrimaryWindow.JobTitleServices.Text);
            sqlCommand.Parameters.AddWithValue("@ServiceTitle", onePrimaryWindow.ServiceTitleServices.Text);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            classess.CompetitionTableServices oneCompetitionTableServices = new classess.CompetitionTableServices();
            oneCompetitionTableServices.MethodCompetitionTableServices(onePrimaryWindow);
        }
    }
}
