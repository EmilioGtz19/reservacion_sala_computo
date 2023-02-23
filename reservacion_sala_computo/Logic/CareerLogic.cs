using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using reservacion_sala_computo.Model;
using System.Data.SQLite;
using reservacion_sala_computo.Connection;

namespace reservacion_sala_computo.Logic
{

    public class CareerLogic
    {
        SQLiteConnection conn;

        public CareerLogic()
        {
            ConnectionDB instance = ConnectionDB.Instance;
            conn = instance.GetConnection();
        }

        public List<Career> GetCareer()
        {
            List<Career> careerList = new List<Career>();

            using (SQLiteConnection connection = new SQLiteConnection(conn))
            {
        
                connection.Open();
                string query = "SELECT career_name FROM career";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        careerList.Add(new Career()
                        {
                            career_name = reader["career_name"].ToString()
                        });
                    }
                }

                return careerList;

            }
        }

    }

}
