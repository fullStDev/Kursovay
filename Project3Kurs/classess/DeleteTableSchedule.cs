using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows;
using System.Data;

namespace Project3Kurs.classess
{
    class DeleteTableSchedule 
    {
        public void MethodDeleteTableSchedule(PrimaryWindow onePrimaryWindow)
        {
            dynamic itemSelectList = onePrimaryWindow.ListPrimaryShedule.SelectedItem;
            var id = itemSelectList.id_Visit;
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection("server=FULLDEV\\SQLEXPRESS;Trusted_Connection=Yes;DataBase=ProjectKurs3;");
            sqlConnection.Open();                                           // открываем базу данных
            SqlCommand sqlCommand = sqlConnection.CreateCommand();          // создаём команду
            sqlCommand.CommandText = "DELETE FROM schedule WHERE [id_Visit] = @id";
            sqlCommand.Parameters.AddWithValue("@id", id); // присваиваем команде текст
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
            sqlDataAdapter.Fill(dataTable);;
            onePrimaryWindow.ListPrimaryShedule.Items.Clear();
            classess.CompetitionTableShedule oneCompetitionTableShedule = new classess.CompetitionTableShedule();
            oneCompetitionTableShedule.MethodCompetitionTableShedule(onePrimaryWindow);
        }
    }
}
