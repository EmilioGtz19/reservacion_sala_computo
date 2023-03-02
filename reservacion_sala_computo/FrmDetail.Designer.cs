namespace reservacion_sala_computo
{
    partial class FrmDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEditDt = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNoteDt = new System.Windows.Forms.TextBox();
            this.dtpDateDt = new System.Windows.Forms.DateTimePicker();
            this.dtpInDt = new System.Windows.Forms.DateTimePicker();
            this.dtpOutDt = new System.Windows.Forms.DateTimePicker();
            this.cbComputerDt = new System.Windows.Forms.ComboBox();
            this.cbCareersDt = new System.Windows.Forms.ComboBox();
            this.txtNumberDt = new System.Windows.Forms.TextBox();
            this.txtNameDt = new System.Windows.Forms.TextBox();
            this.lblTitleHourOut = new System.Windows.Forms.Label();
            this.lblTitleHourIn = new System.Windows.Forms.Label();
            this.lblTitleDate = new System.Windows.Forms.Label();
            this.lblTitleComputer = new System.Windows.Forms.Label();
            this.lblTitleCareer = new System.Windows.Forms.Label();
            this.lblTitleNumber = new System.Windows.Forms.Label();
            this.lblTitleName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditDt
            // 
            this.btnEditDt.Location = new System.Drawing.Point(232, 334);
            this.btnEditDt.Name = "btnEditDt";
            this.btnEditDt.Size = new System.Drawing.Size(154, 28);
            this.btnEditDt.TabIndex = 19;
            this.btnEditDt.Text = "Guardar reservacion";
            this.btnEditDt.Click += new System.EventHandler(this.btnEditDt_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(14, 334);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 28);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1347, 511);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 28);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvReservations
            // 
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(445, 57);
            this.dgvReservations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.RowTemplate.Height = 24;
            this.dgvReservations.Size = new System.Drawing.Size(1027, 350);
            this.dgvReservations.TabIndex = 9;
            this.dgvReservations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservations_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reservaciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNotes);
            this.groupBox1.Controls.Add(this.txtNoteDt);
            this.groupBox1.Controls.Add(this.dtpDateDt);
            this.groupBox1.Controls.Add(this.dtpInDt);
            this.groupBox1.Controls.Add(this.dtpOutDt);
            this.groupBox1.Controls.Add(this.cbComputerDt);
            this.groupBox1.Controls.Add(this.cbCareersDt);
            this.groupBox1.Controls.Add(this.txtNumberDt);
            this.groupBox1.Controls.Add(this.txtNameDt);
            this.groupBox1.Controls.Add(this.lblTitleHourOut);
            this.groupBox1.Controls.Add(this.lblTitleHourIn);
            this.groupBox1.Controls.Add(this.lblTitleDate);
            this.groupBox1.Controls.Add(this.lblTitleComputer);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.lblTitleCareer);
            this.groupBox1.Controls.Add(this.btnEditDt);
            this.groupBox1.Controls.Add(this.lblTitleNumber);
            this.groupBox1.Controls.Add(this.lblTitleName);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(405, 378);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de reservación:";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(64, 294);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(43, 16);
            this.lblNotes.TabIndex = 18;
            this.lblNotes.Text = "Notas";
            // 
            // txtNoteDt
            // 
            this.txtNoteDt.Location = new System.Drawing.Point(165, 291);
            this.txtNoteDt.Name = "txtNoteDt";
            this.txtNoteDt.Size = new System.Drawing.Size(160, 22);
            this.txtNoteDt.TabIndex = 17;
            // 
            // dtpDateDt
            // 
            this.dtpDateDt.CustomFormat = "dd/MM/yyyy";
            this.dtpDateDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateDt.Location = new System.Drawing.Point(165, 177);
            this.dtpDateDt.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateDt.Name = "dtpDateDt";
            this.dtpDateDt.Size = new System.Drawing.Size(160, 22);
            this.dtpDateDt.TabIndex = 14;
            // 
            // dtpInDt
            // 
            this.dtpInDt.CustomFormat = "HH:mm";
            this.dtpInDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInDt.Location = new System.Drawing.Point(165, 213);
            this.dtpInDt.Margin = new System.Windows.Forms.Padding(4);
            this.dtpInDt.Name = "dtpInDt";
            this.dtpInDt.ShowUpDown = true;
            this.dtpInDt.Size = new System.Drawing.Size(160, 22);
            this.dtpInDt.TabIndex = 13;
            // 
            // dtpOutDt
            // 
            this.dtpOutDt.CustomFormat = "HH:mm";
            this.dtpOutDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOutDt.Location = new System.Drawing.Point(165, 251);
            this.dtpOutDt.Margin = new System.Windows.Forms.Padding(4);
            this.dtpOutDt.Name = "dtpOutDt";
            this.dtpOutDt.ShowUpDown = true;
            this.dtpOutDt.Size = new System.Drawing.Size(160, 22);
            this.dtpOutDt.TabIndex = 12;
            // 
            // cbComputerDt
            // 
            this.cbComputerDt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComputerDt.FormattingEnabled = true;
            this.cbComputerDt.Location = new System.Drawing.Point(165, 144);
            this.cbComputerDt.Margin = new System.Windows.Forms.Padding(4);
            this.cbComputerDt.Name = "cbComputerDt";
            this.cbComputerDt.Size = new System.Drawing.Size(160, 24);
            this.cbComputerDt.TabIndex = 11;
            // 
            // cbCareersDt
            // 
            this.cbCareersDt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCareersDt.FormattingEnabled = true;
            this.cbCareersDt.Location = new System.Drawing.Point(165, 112);
            this.cbCareersDt.Margin = new System.Windows.Forms.Padding(4);
            this.cbCareersDt.Name = "cbCareersDt";
            this.cbCareersDt.Size = new System.Drawing.Size(160, 24);
            this.cbCareersDt.TabIndex = 10;
            // 
            // txtNumberDt
            // 
            this.txtNumberDt.Location = new System.Drawing.Point(165, 41);
            this.txtNumberDt.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumberDt.Name = "txtNumberDt";
            this.txtNumberDt.Size = new System.Drawing.Size(132, 22);
            this.txtNumberDt.TabIndex = 9;
            this.txtNumberDt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberDt_KeyPress);
            // 
            // txtNameDt
            // 
            this.txtNameDt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNameDt.Location = new System.Drawing.Point(165, 76);
            this.txtNameDt.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameDt.Name = "txtNameDt";
            this.txtNameDt.Size = new System.Drawing.Size(132, 22);
            this.txtNameDt.TabIndex = 8;
            this.txtNameDt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameDt_KeyPress);
            // 
            // lblTitleHourOut
            // 
            this.lblTitleHourOut.AutoSize = true;
            this.lblTitleHourOut.Location = new System.Drawing.Point(20, 258);
            this.lblTitleHourOut.Name = "lblTitleHourOut";
            this.lblTitleHourOut.Size = new System.Drawing.Size(99, 16);
            this.lblTitleHourOut.TabIndex = 6;
            this.lblTitleHourOut.Text = "Hora de salida:";
            // 
            // lblTitleHourIn
            // 
            this.lblTitleHourIn.AutoSize = true;
            this.lblTitleHourIn.Location = new System.Drawing.Point(11, 220);
            this.lblTitleHourIn.Name = "lblTitleHourIn";
            this.lblTitleHourIn.Size = new System.Drawing.Size(108, 16);
            this.lblTitleHourIn.TabIndex = 5;
            this.lblTitleHourIn.Text = "Hora de entrada:";
            // 
            // lblTitleDate
            // 
            this.lblTitleDate.AutoSize = true;
            this.lblTitleDate.Location = new System.Drawing.Point(71, 186);
            this.lblTitleDate.Name = "lblTitleDate";
            this.lblTitleDate.Size = new System.Drawing.Size(48, 16);
            this.lblTitleDate.TabIndex = 4;
            this.lblTitleDate.Text = "Fecha:";
            // 
            // lblTitleComputer
            // 
            this.lblTitleComputer.AutoSize = true;
            this.lblTitleComputer.Location = new System.Drawing.Point(27, 154);
            this.lblTitleComputer.Name = "lblTitleComputer";
            this.lblTitleComputer.Size = new System.Drawing.Size(92, 16);
            this.lblTitleComputer.TabIndex = 3;
            this.lblTitleComputer.Text = "Computadora:";
            // 
            // lblTitleCareer
            // 
            this.lblTitleCareer.AutoSize = true;
            this.lblTitleCareer.Location = new System.Drawing.Point(64, 121);
            this.lblTitleCareer.Name = "lblTitleCareer";
            this.lblTitleCareer.Size = new System.Drawing.Size(55, 16);
            this.lblTitleCareer.TabIndex = 2;
            this.lblTitleCareer.Text = "Carrera:";
            // 
            // lblTitleNumber
            // 
            this.lblTitleNumber.AutoSize = true;
            this.lblTitleNumber.Location = new System.Drawing.Point(51, 49);
            this.lblTitleNumber.Name = "lblTitleNumber";
            this.lblTitleNumber.Size = new System.Drawing.Size(64, 16);
            this.lblTitleNumber.TabIndex = 1;
            this.lblTitleNumber.Text = "Matrícula:";
            // 
            // lblTitleName
            // 
            this.lblTitleName.AutoSize = true;
            this.lblTitleName.Location = new System.Drawing.Point(60, 85);
            this.lblTitleName.Name = "lblTitleName";
            this.lblTitleName.Size = new System.Drawing.Size(59, 16);
            this.lblTitleName.TabIndex = 0;
            this.lblTitleName.Text = "Nombre:";
            // 
            // FrmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDetail";
            this.Text = "Detalles de reservación";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditDt;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitleCareer;
        private System.Windows.Forms.Label lblTitleNumber;
        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.Label lblTitleDate;
        private System.Windows.Forms.Label lblTitleComputer;
        private System.Windows.Forms.Label lblTitleHourOut;
        private System.Windows.Forms.Label lblTitleHourIn;
        private System.Windows.Forms.TextBox txtNumberDt;
        private System.Windows.Forms.TextBox txtNameDt;
        private System.Windows.Forms.DateTimePicker dtpDateDt;
        private System.Windows.Forms.DateTimePicker dtpInDt;
        private System.Windows.Forms.DateTimePicker dtpOutDt;
        private System.Windows.Forms.ComboBox cbComputerDt;
        private System.Windows.Forms.ComboBox cbCareersDt;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNoteDt;
    }
}