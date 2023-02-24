using reservacion_sala_computo.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace reservacion_sala_computo.Connection
{
    public class ConnectionDB
    {
        private static ConnectionDB _instance = null;
        private SQLiteConnection conn = null;

        //constructor
        private ConnectionDB()
        {
            string connString = ConfigurationManager.ConnectionStrings["SQLite"].ConnectionString;
            conn = new SQLiteConnection(connString);
        }

        public static ConnectionDB Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConnectionDB();
                }
                return _instance;
            }
        }

        public SQLiteConnection GetConnection()
        {
            return conn;
        }


        //Se guarda en la base de datos, debe ir en ReservationLogic
        public List<Reservation> getReservations()
        {
            List<Reservation> reservationList = new List<Reservation>();

            using (SQLiteConnection connection = new SQLiteConnection(conn))
            {
                connection.Open();
                string query = "SELECT * FROM reservation";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.CommandType = System.Data.CommandType.Text;

                using(SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reservationList.Add(new Reservation()
                        {
                            //todos los datos
                            id_reservation = int.Parse(reader["id_reservation"].ToString()),
                            student_number = int.Parse(reader["student_number"].ToString()),
                            student_name = reader["student_name"].ToString(),
                            note = reader["note"].ToString(),
                            // error ->>>>> day = reader["day"].ToString(),
                            hour_in = reader["hour_in"].ToString(),
                            hour_out = reader["hour_out"].ToString(),
                            id_career = int.Parse(reader["id_career"].ToString()),
                            id_computer = int.Parse(reader["id_computer"].ToString())
                        });
                    }
                }
            }

            return reservationList;

        }

    }
}
