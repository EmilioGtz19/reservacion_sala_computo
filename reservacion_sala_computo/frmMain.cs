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
using Excel = Microsoft.Office.Interop.Excel;


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
            string career;
            string computer;
            string name = txtName.Text;
            string number = txtNumber.Text;
            string hourIn = dtpIn.Value.ToString("HH:mm");
            string hourOut = dtpOut.Value.ToString("HH:mm");

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

            if (cbType.SelectedIndex == -1)
            {
                validate = false;
                error += "Favor de llenar el campo carrera \n";
            }
            else
            {
                career = cbType.SelectedItem.ToString();
            }

            if (cbComputers.SelectedIndex == -1)
            {
                validate = false;
                error += "Favor de llenar el campo computadora \n";
            }
            else
            {
                computer = cbComputers.SelectedItem.ToString();
            }

            if(DateTime.Parse(hourIn) < DateTime.Parse("08:00"))
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
                MessageBox.Show("Registro completado", "Reservacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //intento de registro en excel
                Excel.Application appExcel = new Excel.Application();
                if (appExcel != null)
                {
                    Excel.Workbook wb = appExcel.Workbooks.Add();
                    Excel.Worksheet ws = (Excel.Worksheet)wb.Sheets.Add();

                    ws.Cells[1, 1] = name;
                    ws.Cells[1, 2] = number;

                    appExcel.ActiveWorkbook.SaveAs(@"C:\Users\j-emi\OneDrive\Escritorio\ejemplo.xls", Excel.XlFileFormat.xlWorkbookNormal);

                    wb.Close();
                    appExcel.Quit();
                }

            }
            else
            {
                MessageBox.Show(error, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void loadInfo()
        {
            StreamReader file;
            string path = @" D:\Proyectos\carreras.txt";
            string line = "";

            file = new StreamReader(path);
            {
                while ((line = file.ReadLine()) != null)
                {
                    cbType.Items.Add(line);
                }

            }

            path = @" D:\Proyectos\computadoras.txt";

            file = new StreamReader(path);
            {
                while ((line = file.ReadLine()) != null)
                {
                    cbComputers.Items.Add(line);
                }

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
    }
}
