using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace LikdensClinic.Database
{
    class DBUtils
    {
        public static DataSet GetAllDataFromTable(string tableName)
        {
            using (MySqlConnection _conn = MySQL_Connection.GetDBConnection())
            {
                _conn.Open();
                if (_conn != null && _conn.State != ConnectionState.Closed)
                {
                    using (var command = _conn.CreateCommand())
                    {
                        command.CommandText = $"SELECT * FROM {tableName}";

                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            DataSet _dataSet = new DataSet();
                            adapter.Fill(_dataSet, tableName);
                            _conn.Close();
                            return _dataSet;
                        }
                    }
                }
            }
            return null;
        }

        public static DataSet GetPatientDataFromTableByID(string tableName, string idPatient)
        {
            using (MySqlConnection _conn = MySQL_Connection.GetDBConnection())
            {
                _conn.Open();
                if (_conn != null && _conn.State != ConnectionState.Closed)
                {
                    using (var command = _conn.CreateCommand())
                    {
                        command.CommandText = $"SELECT * FROM {tableName} WHERE phone_number = {idPatient};";

                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            DataSet _dataSet = new DataSet();
                            adapter.Fill(_dataSet, tableName);
                            _conn.Close();
                            return _dataSet;
                        }
                    }
                }
            }
            return null;
        }
    }
}
