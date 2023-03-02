using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using reservacion_sala_computo.Model;
using reservacion_sala_computo.Logic;
using reservacion_sala_computo.Connection;

namespace reservacion_sala_computo
{
    public partial class frmMain : Form
    {
        bool validate = true;
        string error;

        public frmMain()
        {
            InitializeComponent();
            loadInfo();
            //Ahora si desde angus
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            error = "";
            validate = true;
            int career;
            int computer;
            string name = txtName.Text;
            string number = txtNumber.Text;
            string hourIn = dtpIn.Value.ToString("HH:mm");
            string hourOut = dtpOut.Value.ToString("HH:mm");
            DateTime today = DateTime.Today;
            Reservation reservation = new Reservation();


            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                validate = false;
                error += "Favor de llenar el campo nombre \n";
            }

            if (string.IsNullOrEmpty(number))
            {
                validate = false;
                error += "Favor de llenar el campo matricula \n";
            }

            if (cbCareers.SelectedIndex == -1)
            {
                validate = false;
                error += "Favor de llenar el campo carrera \n";
            }
            else
            {
                career = int.Parse(cbCareers.SelectedIndex.ToString()) + 1;
                reservation.id_career = career;

            }

            if (cbComputers.SelectedIndex == -1)
            {
                validate = false;
                error += "Favor de llenar el campo computadora \n";
            }
            else
            {
                computer = int.Parse(cbComputers.SelectedIndex.ToString()) + 1;
                reservation.id_computer = computer;

            }

            if (DateTime.Parse(hourIn) < DateTime.Parse("08:00"))
            {
                validate = false;
                error += "Seleccione hora de entrada valida \n";
            }

            if (DateTime.Parse(hourOut) > DateTime.Parse("20:00"))
            {
                validate = false;
                error += "Seleccione hora de salida valida \n";
            }

            if (DateTime.Parse(hourIn) >= DateTime.Parse(hourOut))
            {
                validate = false;
                error += "Seleccione un rango de hora valido \n";
            }

            if (validate)
            {


                reservation.student_number = int.Parse(number);
                reservation.student_name = name;
                reservation.day = today.ToString("dd/MM/yyyy");
                reservation.hour_in = hourIn;
                reservation.hour_out = hourOut;

                bool res = new ReservationLogic().SaveReservation(reservation);

                if (res)
                {
                    MessageBox.Show("Registro completado", "Reservacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //intento de vaciar campos.
                    clean();

                }
                else
                {
                    MessageBox.Show("Error al guardar en la base de datos", "Error base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show(error, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void loadInfo()
        {

            txtName.Text = "";
            txtNumber.Text = "";
            dtpIn.Value = DateTime.Now;
            dtpOut.Value = DateTime.Now;
            cbCareers.SelectedIndex = -1;
            cbComputers.SelectedIndex = -1;
            txtName.Focus();
            List<Computer> computers = new ComputerLogic().GetComputers();
            List<Career> careers = new CareerLogic().GetCareer();

           foreach(Computer computer in computers)
            {
                cbComputers.Items.Add(computer.computer_number);
            }

           
           foreach(Career career in careers)
            {
                cbCareers.Items.Add(career.career_name);
            }
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            FrmDetail frm = new FrmDetail();
            frm.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void clean()
        {
            txtName.Text = "";
            txtNumber.Text = "";
            dtpIn.Value = DateTime.Now;
            dtpOut.Value = DateTime.Now;
            cbCareers.SelectedIndex = -1;
            cbComputers.SelectedIndex = -1;
            txtName.Focus();
        }
    }
}
