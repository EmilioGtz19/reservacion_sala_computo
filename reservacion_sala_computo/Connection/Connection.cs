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
        private static string conn = "Data Source = C:/Users/Tyler/Desktop/reservaciones/reservacion_sala_computo/reservacion_sala_computo/DB_SALA_COMPUTO.db";

        private static ConnectionDB _instance = null;

        //constructor
        public ConnectionDB()
        {
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


        //Se guarda en la base de datos, debe ir en ReservationLogic
        public bool saveReservation(Reservation reservation)
        {
            bool res = true;
            using (SQLiteConnection connection = new SQLiteConnection(conn))
            {
                connection.Open();
                string query = "INSERT INTO reservation(student_number, student_name, note, day, hour_in, hour_out, id_career, id_computer) values (@student_number, @student_name, @note, @day, @hour_in, @hour_out, @id_career, @id_computer)";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.Add(new SQLiteParameter("@id_reservation", reservation.id_reservation));
                cmd.Parameters.Add(new SQLiteParameter("@student_number", reservation.student_number));
                cmd.Parameters.Add(new SQLiteParameter("@student_name", reservation.student_name));
                cmd.Parameters.Add(new SQLiteParameter("@note", reservation.note));
                cmd.Parameters.Add(new SQLiteParameter("@day", reservation.day));
                cmd.Parameters.Add(new SQLiteParameter("@hour_in", reservation.hour_in));
                cmd.Parameters.Add(new SQLiteParameter("@hour_out", reservation.hour_out));
                cmd.Parameters.Add(new SQLiteParameter("@id_career", reservation.id_career));
                cmd.Parameters.Add(new SQLiteParameter("@id_computer", reservation.id_computer));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    res = false;
                }
            }

            return res;
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

        public object[] getCareer()
        {

            using (SQLiteConnection connection = new SQLiteConnection(conn))
            {
                object[] career = new object[6];

                connection.Open();
                string query = "SELECT career_name FROM career";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    int i = 0;

                    while(reader.Read())
                    {
                        career[i] = reader["career_name"].ToString();
                        i++;
                    }

                }

                return career;

            }
        }

        public object[] getComputer()
        {

            using (SQLiteConnection connection = new SQLiteConnection(conn))
            {
                object[] computer = new object[10];

                connection.Open();
                string query = "SELECT computer_number FROM computer";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    int i = 0;

                    while (reader.Read())
                    {
                        computer[i] = reader["computer_number"].ToString();
                        i++;
                    }

                }

                return computer;

            }
        }



    }
}
