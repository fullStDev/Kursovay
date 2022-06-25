using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project3Kurs.classess
{
    internal class DeleteTableDoctors
    {
        public void MethodDeleteTableDoctors(PrimaryWindow onePrimaryWindow)
        {
            dynamic itemSelectList = onePrimaryWindow.ListPrimaryDoctors.SelectedItem;
            var id = itemSelectList.id_Doctor;
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection("server=FULLDEV\\SQLEXPRESS;Trusted_Connection=Yes;DataBase=ProjectKurs3;");
            sqlConnection.Open();                                           // открываем базу данных
            SqlCommand sqlCommand = sqlConnection.CreateCommand();          // создаём команду
            sqlCommand.CommandText = "DELETE FROM doctors WHERE [id_Doctor] = @id";
            sqlCommand.Parameters.AddWithValue("@id", id); // присваиваем команде текст
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
            sqlDataAdapter.Fill(dataTable); ;
            onePrimaryWindow.ListPrimaryDoctors.Items.Clear();
            classess.CompetitionTableDoctors oneCompetitionTableDoctors = new classess.CompetitionTableDoctors();
            oneCompetitionTableDoctors.MethodCompetitionTableDoctors(onePrimaryWindow);
        }
    }
}
