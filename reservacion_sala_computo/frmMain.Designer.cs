namespace reservacion_sala_computo
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblComputers = new System.Windows.Forms.Label();
            this.cbComputers = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.dtpIn = new System.Windows.Forms.DateTimePicker();
            this.dtpOut = new System.Windows.Forms.DateTimePicker();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lvInfo = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(75, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(69, 71);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(64, 16);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Matricula:";
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Location = new System.Drawing.Point(169, 12);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(444, 22);
            this.txtName.TabIndex = 2;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(169, 69);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(171, 22);
            this.txtNumber.TabIndex = 3;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // lblComputers
            // 
            this.lblComputers.AutoSize = true;
            this.lblComputers.Location = new System.Drawing.Point(35, 142);
            this.lblComputers.Name = "lblComputers";
            this.lblComputers.Size = new System.Drawing.Size(99, 16);
            this.lblComputers.TabIndex = 4;
            this.lblComputers.Text = "Computadoras:";
            // 
            // cbComputers
            // 
            this.cbComputers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComputers.FormattingEnabled = true;
            this.cbComputers.Location = new System.Drawing.Point(169, 139);
            this.cbComputers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbComputers.Name = "cbComputers";
            this.cbComputers.Size = new System.Drawing.Size(121, 24);
            this.cbComputers.TabIndex = 5;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(492, 71);
            this.cbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 24);
            this.cbType.TabIndex = 6;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(407, 75);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(55, 16);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Carrera:";
            // 
            // dtpIn
            // 
            this.dtpIn.CustomFormat = "HH:mm";
            this.dtpIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIn.Location = new System.Drawing.Point(169, 199);
            this.dtpIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpIn.Name = "dtpIn";
            this.dtpIn.ShowUpDown = true;
            this.dtpIn.Size = new System.Drawing.Size(143, 22);
            this.dtpIn.TabIndex = 8;
            // 
            // dtpOut
            // 
            this.dtpOut.CustomFormat = "HH:mm";
            this.dtpOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOut.Location = new System.Drawing.Point(169, 250);
            this.dtpOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpOut.Name = "dtpOut";
            this.dtpOut.ShowUpDown = true;
            this.dtpOut.Size = new System.Drawing.Size(143, 22);
            this.dtpOut.TabIndex = 9;
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Location = new System.Drawing.Point(11, 206);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(123, 16);
            this.lblIn.TabIndex = 10;
            this.lblIn.Text = "Horario de entrada:";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(19, 255);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(114, 16);
            this.lblOut.TabIndex = 11;
            this.lblOut.Text = "Horario de salida:";
            // 
            // btnReservation
            // 
            this.btnReservation.Location = new System.Drawing.Point(39, 363);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(144, 23);
            this.btnReservation.TabIndex = 12;
            this.btnReservation.Text = "Ver Reservaciones";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(220, 363);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(644, 415);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(407, 139);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(181, 16);
            this.lblInfo.TabIndex = 15;
            this.lblInfo.Text = "Información de computadora:";
            // 
            // lvInfo
            // 
            this.lvInfo.HideSelection = false;
            this.lvInfo.Location = new System.Drawing.Point(411, 174);
            this.lvInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(255, 212);
            this.lvInfo.TabIndex = 16;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.dtpOut);
            this.Controls.Add(this.dtpIn);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbComputers);
            this.Controls.Add(this.lblComputers);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "Sala de Cómputo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblComputers;
        private System.Windows.Forms.ComboBox cbComputers;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.DateTimePicker dtpIn;
        private System.Windows.Forms.DateTimePicker dtpOut;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ListView lvInfo;
    }
}

