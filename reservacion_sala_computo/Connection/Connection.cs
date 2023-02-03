using reservacion_sala_computo.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace reservacion_sala_computo.Connection
{
    public class ConnectionDB
    {
        private static string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        private static ConnectionDB _instance = null;

        //constructor
        public ConnectionDB()
        {
        }

        public static ConnectionDB Instance()
        {
            if (_instance == null)
            {
                _instance = new ConnectionDB();
            }
            return _instance;
        }


        //Se guarda en la base de datos, debe ir en ReservationLogic
        public bool saveReservation(Reservation reservation)
        {
            bool respuesta = true;
            using (SQLiteConnection connection = new SQLiteConnection(conn))
            {
                connection.Open();
                string query = "INSERT INTO reservation(student_number, student_name, note, day, hour_in, hour_out, id_career, id_computer) values (@student_number, @student_name, @note, @day, @hour_in, @hour_out, @id_career, @id_computer)";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.Add(new SQLiteParameter("@student_number", reservation.student_number));
                cmd.Parameters.Add(new SQLiteParameter("@student_name", reservation.student_name));
                cmd.Parameters.Add(new SQLiteParameter("@note", reservation.note));
                cmd.Parameters.Add(new SQLiteParameter("@day", reservation.day));
                cmd.Parameters.Add(new SQLiteParameter("@hour_in", reservation.hour_in));
                cmd.Parameters.Add(new SQLiteParameter("@hour_out", reservation.hour_out));
                cmd.Parameters.Add(new SQLiteParameter("@id_career", reservation.id_career));
                cmd.Parameters.Add(new SQLiteParameter("@id_computer", reservation.id_computer));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() <= 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

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
                        });
                    }
                }
                
            }

            return reservationList;

        }
       
    }
}
