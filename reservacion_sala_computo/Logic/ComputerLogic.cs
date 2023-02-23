using reservacion_sala_computo.Connection;
using reservacion_sala_computo.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservacion_sala_computo.Logic
{
    public class ComputerLogic
    {
        SQLiteConnection conn;

        public ComputerLogic()
        {
            ConnectionDB instance = ConnectionDB.Instance;
            conn = instance.GetConnection();
        }

        public List<Computer> GetComputers()
        {
            List<Computer> computersList = new List<Computer>();

            using (SQLiteConnection connection = new SQLiteConnection(conn))
            {
                connection.Open();
                string query = "SELECT computer_number FROM computer";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.CommandType = System.Data.CommandType.Text;
            
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        computersList.Add(new Computer()
                        {
                            computer_number = Int32.Parse(reader["computer_number"].ToString())
                        });
                    }
                }
            }

            return computersList;
        }

    }

}
