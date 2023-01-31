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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {

            //abrir detalles de reservación
            FrmDetail frmDetail = new FrmDetail();

            frmDetail.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //guardar reservación


            MessageBox.Show("Reservación hecha con éxito", "Reservación finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
