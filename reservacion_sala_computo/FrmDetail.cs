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
        bool validate = true;
        string message;
        int reservationID = 0;
        public FrmDetail()
        {
            InitializeComponent();
            loadInfo();
            loadCb();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {   
            
            if(reservationID != 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que quiere borrar la reservación?", "Confirmar eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if(dialogResult == DialogResult.OK)
                {
                    bool res = new ReservationLogic().DeleteReservation(reservationID);

                    if (res)
                    {
                        cleanForm();
                        MessageBox.Show("Se ha eliminado la reservación.", "Éxito en la eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadInfo();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al eliminar la reservación.", "Error en la eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Seleccione una reservacion.", "Error en la eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void btnEditDt_Click(object sender, EventArgs e)
        {
            //se validan los datos, luego se guarda
            Reservation reservation = new Reservation();
            //reservation = getFormInfo();
            reservation = validation();

            if (reservation.id_reservation != 0)
            {

                bool res = new ReservationLogic().EditReservation(reservation);

                if (res)
                {
                    cleanForm();
                    MessageBox.Show("Se ha guardado la edición.", "Éxito en la edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadInfo();
                }
                else
                {
                    MessageBox.Show("Hubo un error al editar.", "Error en la edición", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
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
        private void dgvReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            reservationID = int.Parse(dgvReservations.CurrentRow.Cells[0].Value.ToString());
            txtNumberDt.Text = dgvReservations.CurrentRow.Cells[1].Value.ToString();
            txtNameDt.Text = dgvReservations.CurrentRow.Cells[2].Value.ToString();
            cbCareersDt.Text = dgvReservations.CurrentRow.Cells[3].Value.ToString();
            cbComputerDt.Text = dgvReservations.CurrentRow.Cells[4].Value.ToString();
            dtpDateDt.Text = dgvReservations.CurrentRow.Cells[5].Value.ToString();
            dtpInDt.Text = dgvReservations.CurrentRow.Cells[6].Value.ToString();
            dtpOutDt.Text = dgvReservations.CurrentRow.Cells[7].Value.ToString();
        }

        private Reservation validation()
        {
            Reservation reservation = new Reservation();

            if (reservationID != 0)
            {
                message = "";
                validate = true;
                int career;
                int computer;
                string name = txtNameDt.Text;
                string number = txtNumberDt.Text;
                string hourIn = dtpInDt.Text;
                string hourOut = dtpOutDt.Text;
                string date = dtpDateDt.Text;



                if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                {
                    validate = false;
                    message += "Favor de llenar el campo nombre \n";
                }

                if (string.IsNullOrEmpty(number))
                {
                    validate = false;
                    message += "Favor de llenar el campo matricula \n";
                }

                if (cbCareersDt.SelectedIndex == -1)
                {
                    validate = false;
                    message += "Favor de llenar el campo carrera \n";
                }
                else
                {
                    career = int.Parse(cbCareersDt.SelectedIndex.ToString()) + 1;
                    reservation.id_career = career;

                }

                if (cbComputerDt.SelectedIndex == -1)
                {
                    validate = false;
                    message += "Favor de llenar el campo computadora \n";
                }
                else
                {
                    computer = int.Parse(cbComputerDt.SelectedIndex.ToString()) + 1;
                    reservation.id_computer = computer;

                }

                if (DateTime.Parse(hourIn) < DateTime.Parse("08:00"))
                {
                    validate = false;
                    message += "Seleccione hora de entrada valida \n";
                }

                if (DateTime.Parse(hourOut) > DateTime.Parse("20:00"))
                {
                    validate = false;
                    message += "Seleccione hora de salida valida \n";
                }

                if (DateTime.Parse(hourIn) >= DateTime.Parse(hourOut))
                {
                    validate = false;
                    message += "Seleccione un rango de hora valido \n";
                }

                if (!validate)
                {
                    MessageBox.Show(message, "Reservacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    reservation.id_reservation = reservationID;
                    reservation.student_number = int.Parse(number);
                    reservation.student_name = name;
                    reservation.note = txtNoteDt.Text;
                    reservation.day = dtpDateDt.Text;
                    reservation.hour_in = hourIn;
                    reservation.hour_out = hourOut;
                }

                return reservation;

            }
            else
            {
                MessageBox.Show("Seleccione una reservacion.", "Reservacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return reservation;
            }
            

        }

        private void cleanForm()
        {
            txtNameDt.Text = "";
            txtNumberDt.Text = "";
            dtpInDt.Value = DateTime.Now;
            dtpOutDt.Value = DateTime.Now;
            cbCareersDt.SelectedIndex = -1;
            cbComputerDt.SelectedIndex = -1;
            txtNameDt.Focus();
        }

        private void txtNameDt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtNumberDt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void loadCb()
        {
            List<Computer> computers = new ComputerLogic().GetComputers();
            List<Career> careers = new CareerLogic().GetCareer();

            foreach (Computer computer in computers)
            {
                cbComputerDt.Items.Add(computer.computer_number);
            }

            foreach (Career career in careers)
            {
                cbCareersDt.Items.Add(career.career_name);
            }

        }
        
    }
}
