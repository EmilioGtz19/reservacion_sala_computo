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

    }
}
