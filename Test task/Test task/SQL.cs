using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Windows;
using System.Data;
using System.Xml;

namespace Test_task
{
    internal class SQL
    {
        static string derictory = Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length-25);
        DataTable table = new DataTable();
        List<string> list = new List<string>();
        string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={derictory}\Database1.mdf;Integrated Security=True";
        /// <summary>
        /// Запрос SQL 
        /// </summary>
        public DataTable CommandSelect(string commandText)
        {
            table = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = $"{commandText}";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            adapter.Dispose();
            connection.Close();
            return table;
        }
        /// <summary>
        /// Определеннй Запрос SQL WHERE 
        /// </summary>
        public DataTable CommandSelectCondition(string columsName, string tableName, string conditionName)
        {
            table = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = $"SELECT {columsName} FROM {tableName} Where {conditionName}";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            adapter.Dispose();
            connection.Close();
            return table;
        }
    }
}
