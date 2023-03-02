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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTitleDate = new System.Windows.Forms.Label();
            this.lblTitleComputer = new System.Windows.Forms.Label();
            this.lblTitleCareer = new System.Windows.Forms.Label();
            this.lblTitleNumber = new System.Windows.Forms.Label();
            this.lblTitleName = new System.Windows.Forms.Label();
            this.lblTitleHourIn = new System.Windows.Forms.Label();
            this.lblTitleHourOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(7, 324);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(136, 28);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Editar reservación";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(263, 324);
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
            this.btnBack.Location = new System.Drawing.Point(1064, 513);
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
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.RowTemplate.Height = 24;
            this.dgvReservations.Size = new System.Drawing.Size(743, 349);
            this.dgvReservations.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reservaciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTitleHourOut);
            this.groupBox1.Controls.Add(this.lblTitleHourIn);
            this.groupBox1.Controls.Add(this.lblTitleDate);
            this.groupBox1.Controls.Add(this.lblTitleComputer);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.lblTitleCareer);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.lblTitleNumber);
            this.groupBox1.Controls.Add(this.lblTitleName);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 378);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de reservación:";
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
            this.lblTitleNumber.Location = new System.Drawing.Point(55, 86);
            this.lblTitleNumber.Name = "lblTitleNumber";
            this.lblTitleNumber.Size = new System.Drawing.Size(64, 16);
            this.lblTitleNumber.TabIndex = 1;
            this.lblTitleNumber.Text = "Matrícula:";
            // 
            // lblTitleName
            // 
            this.lblTitleName.AutoSize = true;
            this.lblTitleName.Location = new System.Drawing.Point(60, 56);
            this.lblTitleName.Name = "lblTitleName";
            this.lblTitleName.Size = new System.Drawing.Size(59, 16);
            this.lblTitleName.TabIndex = 0;
            this.lblTitleName.Text = "Nombre:";
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
            // lblTitleHourOut
            // 
            this.lblTitleHourOut.AutoSize = true;
            this.lblTitleHourOut.Location = new System.Drawing.Point(20, 258);
            this.lblTitleHourOut.Name = "lblTitleHourOut";
            this.lblTitleHourOut.Size = new System.Drawing.Size(99, 16);
            this.lblTitleHourOut.TabIndex = 6;
            this.lblTitleHourOut.Text = "Hora de salida:";
            // 
            // FrmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
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
        private System.Windows.Forms.Button btnEdit;
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
    }
}