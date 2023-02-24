using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservacion_sala_computo.Model
{
    public class Reservation
    {
        public int id_reservation { get; set; }

        public int student_number { get; set; }

        public string student_name { get; set; }

        public string note { get; set; }

        public string day { get; set; }

        public string hour_in { get; set; }

        public string hour_out { get; set; }
        
        public int id_career { get; set; }

        public int id_computer { get; set; }

    }

    public class ReservationList
    {
        public int id_reservation { get; set; }

        public int student_number { get; set; }

        public string student_name { get; set; }

        public string career_name { get; set; }

        public int computer_number { get; set; }

        public string day { get; set; }

        public string hour_in { get; set; }

        public string hour_out { get; set; }

       
    }
}
