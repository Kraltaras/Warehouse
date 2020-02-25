using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Warehouse
{
    public class QueryManipulation
    {
        private string _connectString;
        private SqlConnection _myConnection;

        public QueryManipulation()
        {
            _connectString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Warehouse_db.mdf;Integrated Security=True";
            //_connectString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\C# Projects\\Warehouse\\Warehouse\\Warehouse_db.mdf\";Integrated Security=True";
            _myConnection = new SqlConnection(_connectString);
        }

        public void GridShow(string query, DataGridView gridView)
        {
            _myConnection.Open();

            SqlCommand command = new SqlCommand(query, _myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            reader.Close();
            _myConnection.Close();

            gridView.Rows.Clear();
            foreach (string[] s in data)
            {
                gridView.Rows.Add(s);
            }
        }

        public void GridShow(string query, DataGridView gridView, DateTime dateStart, DateTime dateEnd)
        {
            _myConnection.Open();

            SqlCommand command = new SqlCommand(query, _myConnection);
            command.Parameters.AddWithValue("@DateStart", dateStart);
            command.Parameters.AddWithValue("@DateEnd", dateEnd);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            reader.Close();
            _myConnection.Close();

            gridView.Rows.Clear();
            foreach (string[] s in data)
            {
                gridView.Rows.Add(s);
            }
        }

        public void InsertData(string textBoxText)
        {
            _myConnection.Open();

            Form1.WareNumber++;

            string query = "INSERT INTO Товары (ID, Товар, Статус, [Дата изменения статуса]) VALUES ( '"+ Form1.WareNumber +"', N'"+ textBoxText +"', N'Принят', @Date)";

            SqlCommand command = new SqlCommand(query, _myConnection);
            command.Parameters.AddWithValue("@Date", DateTime.Now);
            command.ExecuteNonQuery();

            _myConnection.Close();
        }

        public void ChangeStatus(string setStatus, int idNumber)
        {
            _myConnection.Open();

            string query = "UPDATE Товары SET Статус = N'"+ setStatus +"', [Дата изменения статуса] = @Date WHERE ID = '"+ idNumber +"'";
            SqlCommand command = new SqlCommand(query, _myConnection);
            command.Parameters.AddWithValue("@Date", DateTime.Now);
            command.ExecuteNonQuery();

            _myConnection.Close();
        }
    }
}
