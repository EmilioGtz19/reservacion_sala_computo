using reservacion_sala_computo.Connection;
using reservacion_sala_computo.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reservacion_sala_computo.Logic
{

    internal class ReservationLogic
    {

        SQLiteConnection conn;

        public ReservationLogic()
        {
            ConnectionDB instance = ConnectionDB.Instance;
            conn = instance.GetConnection();
        }


        public bool SaveReservation(Reservation reservation)
        {
            bool res = false;
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

                if (cmd.ExecuteNonQuery() > 0) { 
                    res = true;
                };
            }

            return res;
        }

     
        public List<ReservationList> GetReservations()
        {
            List<ReservationList> reservationList = new List<ReservationList>();

            using (SQLiteConnection connection = new SQLiteConnection(conn))
            {
                connection.Open();
                string query = "SELECT id_reservation," +
                    "student_number, " +
                    "student_name, " +
                    "career_name, " +
                    "computer_number," +
                    "day, " +
                    "hour_in, " +
                    "hour_out " +
                    "FROM reservation " +
                    "INNER JOIN career ON career.id_career = reservation.id_career " +
                    "INNER JOIN computer ON computer.id_computer = reservation.id_computer";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime hour_in_ = reader.GetDateTime(reader.GetOrdinal("hour_in"));
                        DateTime hour_out_ = reader.GetDateTime(reader.GetOrdinal("hour_out"));

                        reservationList.Add(new ReservationList()
                        {
                            id_reservation = reader.GetInt32(reader.GetOrdinal("id_reservation")),
                            student_number = reader.GetInt32(reader.GetOrdinal("student_number")),
                            student_name = reader.GetString(reader.GetOrdinal("student_name")),
                            career_name = reader.GetString(reader.GetOrdinal("career_name")),
                            computer_number = reader.GetInt32(reader.GetOrdinal("computer_number")),
                            day = reader.GetString(reader.GetOrdinal("day")),
                            hour_in = hour_in_.ToString("HH:mm"),
                            hour_out = hour_out_.ToString("HH:mm")
                        });
                    }
                }
            }

            return reservationList;

        }

        public bool EditReservation(Reservation reservation)
        {
            bool res = false;
            using (SQLiteConnection connection = new SQLiteConnection(conn))
            {
                connection.Open();
                string query = "UPDATE reservation set " +
                    "student_number = @student_number, " +
                    "student_name = @student_name, " +
                    "note = @note" +
                    "day = @day, " +
                    "hour_in = @hour_in, " +
                    "hour_out = @hour_out, " +
                    "id_career = @id_career, " +
                    "id_computer = @id_computer " +
                    "WHERE id_reservation = @id_reservation";

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

                if(cmd.ExecuteNonQuery() > 0)
                {
                    res = true;
                }


            }

            return res;
        }

        public bool DeleteReservation(Reservation reservation)
        {
            bool res = false;
            using (SQLiteConnection connection = new SQLiteConnection(conn))
            {
                connection.Open();
                string query = "DELETE from reservation " +
                    "WHERE id_reservation = @id_reservation";

                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.Add(new SQLiteParameter("@id_reservation", reservation.id_reservation));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    res = true;
                }


            }

            return res;
        }
    }
}
