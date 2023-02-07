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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("chagi");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("emilio");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("rafa 7:00 am - 8:00am");
            this.lblComputer = new System.Windows.Forms.Label();
            this.cbCompuDt = new System.Windows.Forms.ComboBox();
            this.lvReservations = new System.Windows.Forms.ListView();
            this.lvInfo = new System.Windows.Forms.ListView();
            this.lblReservationDt = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblInfoDt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Location = new System.Drawing.Point(301, 25);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(70, 13);
            this.lblComputer.TabIndex = 0;
            this.lblComputer.Text = "Computadora";
            // 
            // cbCompuDt
            // 
            this.cbCompuDt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompuDt.FormattingEnabled = true;
            this.cbCompuDt.Location = new System.Drawing.Point(377, 22);
            this.cbCompuDt.Name = "cbCompuDt";
            this.cbCompuDt.Size = new System.Drawing.Size(67, 21);
            this.cbCompuDt.TabIndex = 1;
            // 
            // lvReservations
            // 
            this.lvReservations.HideSelection = false;
            this.lvReservations.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvReservations.Location = new System.Drawing.Point(65, 101);
            this.lvReservations.Name = "lvReservations";
            this.lvReservations.Size = new System.Drawing.Size(264, 251);
            this.lvReservations.TabIndex = 3;
            this.lvReservations.UseCompatibleStateImageBehavior = false;
            this.lvReservations.View = System.Windows.Forms.View.List;
            // 
            // lvInfo
            // 
            this.lvInfo.HideSelection = false;
            this.lvInfo.Location = new System.Drawing.Point(467, 101);
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(264, 251);
            this.lvInfo.TabIndex = 4;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            // 
            // lblReservationDt
            // 
            this.lblReservationDt.AutoSize = true;
            this.lblReservationDt.Location = new System.Drawing.Point(62, 73);
            this.lblReservationDt.Name = "lblReservationDt";
            this.lblReservationDt.Size = new System.Drawing.Size(169, 13);
            this.lblReservationDt.TabIndex = 5;
            this.lblReservationDt.Text = "Reservaciones de la computadora";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(123, 370);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(143, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Editar reservación";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(123, 399);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(695, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblInfoDt
            // 
            this.lblInfoDt.AutoSize = true;
            this.lblInfoDt.Location = new System.Drawing.Point(464, 73);
            this.lblInfoDt.Name = "lblInfoDt";
            this.lblInfoDt.Size = new System.Drawing.Size(62, 13);
            this.lblInfoDt.TabIndex = 9;
            this.lblInfoDt.Text = "Información";
            // 
            // FrmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfoDt);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblReservationDt);
            this.Controls.Add(this.lvInfo);
            this.Controls.Add(this.lvReservations);
            this.Controls.Add(this.cbCompuDt);
            this.Controls.Add(this.lblComputer);
            this.Name = "FrmDetail";
            this.Text = "Detalles de reservación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.ComboBox cbCompuDt;
        private System.Windows.Forms.ListView lvReservations;
        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.Label lblReservationDt;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblInfoDt;
    }
}