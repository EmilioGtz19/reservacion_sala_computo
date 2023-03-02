using reservacion_sala_computo.Connection;
using reservacion_sala_computo.Logic;
using reservacion_sala_computo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reservacion_sala_computo
{
    public partial class FrmDetail : Form
    {
        public FrmDetail()
        {
            InitializeComponent();
            loadInfo();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Está seguro que quiere borrar la reservación?", "Confirmar eliminación", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void loadInfo()
        {
            List<ReservationList> reservations = new ReservationLogic().GetReservations();

            dgvReservations.DataSource = reservations;

            dgvReservations.Columns["id_reservation"].Visible = false;
            dgvReservations.Columns["student_number"].HeaderText = "Matrícula";
            dgvReservations.Columns["student_name"].HeaderText = "Nombre";
            dgvReservations.Columns["career_name"].HeaderText = "Carrera";
            dgvReservations.Columns["computer_number"].HeaderText = "Computadora";
            dgvReservations.Columns["day"].HeaderText = "Fecha";
            dgvReservations.Columns["hour_in"].HeaderText = "Hora de entrada";
            dgvReservations.Columns["hour_out"].HeaderText = "Hora de salida";
        }
    }
}
