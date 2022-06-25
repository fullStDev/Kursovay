using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project3Kurs.classess
{
    internal class DeleteTableServices
    {
        public void MethodDeleteTableServices(PrimaryWindow onePrimaryWindow)
        {
            dynamic itemSelectList = onePrimaryWindow.ListPrimaryServices.SelectedItem;
            var id = itemSelectList.id_Services;
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection("server=FULLDEV\\SQLEXPRESS;Trusted_Connection=Yes;DataBase=ProjectKurs3;");
            sqlConnection.Open();                                           // открываем базу данных
            SqlCommand sqlCommand = sqlConnection.CreateCommand();          // создаём команду
            sqlCommand.CommandText = "DELETE FROM services WHERE [id_Service] = @id";
            sqlCommand.Parameters.AddWithValue("@id", id); // присваиваем команде текст
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
            sqlDataAdapter.Fill(dataTable); ;
            onePrimaryWindow.ListPrimaryServices.Items.Clear();
            classess.CompetitionTableServices oneCompetitionTableServices = new classess.CompetitionTableServices();
            oneCompetitionTableServices.MethodCompetitionTableServices(onePrimaryWindow);

        }
    }
}
