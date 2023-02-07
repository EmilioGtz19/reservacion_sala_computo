using reservacion_sala_computo.Connection;
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
            loadInfoDtl();
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

        private void loadInfoDtl()
        {
            cbCompuDt.Items.AddRange(ConnectionDB.Instance.getComputer());
        }
    }
}
