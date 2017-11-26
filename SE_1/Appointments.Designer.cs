namespace SE_1
{
    partial class Appointments
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Appointment = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AppPID = new System.Windows.Forms.TextBox();
            this.txt_AppPN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Book = new System.Windows.Forms.Button();
            this.dtp_App = new System.Windows.Forms.DateTimePicker();
            this.btn_CancelB = new System.Windows.Forms.Button();
            this.btn_ChangeAP = new System.Windows.Forms.Button();
            this.txt_AppGpNa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Appointment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID:";
            // 
            // dgv_Appointment
            // 
            this.dgv_Appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Appointment.Location = new System.Drawing.Point(21, 197);
            this.dgv_Appointment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Appointment.Name = "dgv_Appointment";
            this.dgv_Appointment.RowTemplate.Height = 33;
            this.dgv_Appointment.Size = new System.Drawing.Size(855, 193);
            this.dgv_Appointment.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Appointment Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "GP Name:";
            // 
            // txt_AppPID
            // 
            this.txt_AppPID.Location = new System.Drawing.Point(193, 47);
            this.txt_AppPID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_AppPID.Name = "txt_AppPID";
            this.txt_AppPID.Size = new System.Drawing.Size(210, 25);
            this.txt_AppPID.TabIndex = 5;
            // 
            // txt_AppPN
            // 
            this.txt_AppPN.Location = new System.Drawing.Point(193, 82);
            this.txt_AppPN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_AppPN.Name = "txt_AppPN";
            this.txt_AppPN.Size = new System.Drawing.Size(210, 25);
            this.txt_AppPN.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Patient Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "OR";
            // 
            // btn_Book
            // 
            this.btn_Book.Location = new System.Drawing.Point(501, 125);
            this.btn_Book.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(88, 34);
            this.btn_Book.TabIndex = 10;
            this.btn_Book.Text = "Book";
            this.btn_Book.UseVisualStyleBackColor = true;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // dtp_App
            // 
            this.dtp_App.Location = new System.Drawing.Point(193, 119);
            this.dtp_App.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_App.Name = "dtp_App";
            this.dtp_App.Size = new System.Drawing.Size(215, 25);
            this.dtp_App.TabIndex = 11;
            // 
            // btn_CancelB
            // 
            this.btn_CancelB.Location = new System.Drawing.Point(620, 125);
            this.btn_CancelB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CancelB.Name = "btn_CancelB";
            this.btn_CancelB.Size = new System.Drawing.Size(88, 34);
            this.btn_CancelB.TabIndex = 12;
            this.btn_CancelB.Text = "Cancel";
            this.btn_CancelB.UseVisualStyleBackColor = true;
            // 
            // btn_ChangeAP
            // 
            this.btn_ChangeAP.Location = new System.Drawing.Point(731, 125);
            this.btn_ChangeAP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ChangeAP.Name = "btn_ChangeAP";
            this.btn_ChangeAP.Size = new System.Drawing.Size(88, 34);
            this.btn_ChangeAP.TabIndex = 13;
            this.btn_ChangeAP.Text = "Change";
            this.btn_ChangeAP.UseVisualStyleBackColor = true;
            // 
            // txt_AppGpNa
            // 
            this.txt_AppGpNa.Location = new System.Drawing.Point(193, 157);
            this.txt_AppGpNa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_AppGpNa.Name = "txt_AppGpNa";
            this.txt_AppGpNa.Size = new System.Drawing.Size(238, 25);
            this.txt_AppGpNa.TabIndex = 14;
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 421);
            this.Controls.Add(this.txt_AppGpNa);
            this.Controls.Add(this.btn_ChangeAP);
            this.Controls.Add(this.btn_CancelB);
            this.Controls.Add(this.dtp_App);
            this.Controls.Add(this.btn_Book);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_AppPN);
            this.Controls.Add(this.txt_AppPID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Appointment);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Appointments";
            this.Text = "Appointments";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Appointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Appointment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_AppPID;
        private System.Windows.Forms.TextBox txt_AppPN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.DateTimePicker dtp_App;
        private System.Windows.Forms.Button btn_CancelB;
        private System.Windows.Forms.Button btn_ChangeAP;
        private System.Windows.Forms.TextBox txt_AppGpNa;
    }
}