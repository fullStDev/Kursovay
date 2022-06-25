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
    internal class DeleteTablePatients
    {
        public void MethodDeleteTablePatients(PrimaryWindow onePrimaryWindow)
        {
            dynamic itemSelectList = onePrimaryWindow.ListPrimaryPatients.SelectedItem;
            var id = itemSelectList.id_Patient;
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection("server=FULLDEV\\SQLEXPRESS;Trusted_Connection=Yes;DataBase=ProjectKurs3;");
            sqlConnection.Open();                                           // открываем базу данных
            SqlCommand sqlCommand = sqlConnection.CreateCommand();          // создаём команду
            sqlCommand.CommandText = "DELETE FROM patients WHERE [id_Patient] = @id";
            sqlCommand.Parameters.AddWithValue("@id", id); // присваиваем команде текст
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
            sqlDataAdapter.Fill(dataTable);
            onePrimaryWindow.ListPrimaryPatients.Items.Clear();
            classess.CompetitionTablePatients oneCompletionTablePatient = new classess.CompetitionTablePatients();
            oneCompletionTablePatient.MethodCompetitionTablePatient(onePrimaryWindow);
        }
    }
}
