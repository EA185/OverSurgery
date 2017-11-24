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
            this.label1.Location = new System.Drawing.Point(63, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID:";
            // 
            // dgv_Appointment
            // 
            this.dgv_Appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Appointment.Location = new System.Drawing.Point(32, 328);
            this.dgv_Appointment.Name = "dgv_Appointment";
            this.dgv_Appointment.RowTemplate.Height = 33;
            this.dgv_Appointment.Size = new System.Drawing.Size(1283, 322);
            this.dgv_Appointment.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Appointment Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "GP Name:";
            // 
            // txt_AppPID
            // 
            this.txt_AppPID.Location = new System.Drawing.Point(289, 78);
            this.txt_AppPID.Name = "txt_AppPID";
            this.txt_AppPID.Size = new System.Drawing.Size(313, 31);
            this.txt_AppPID.TabIndex = 5;
            // 
            // txt_AppPN
            // 
            this.txt_AppPN.Location = new System.Drawing.Point(289, 136);
            this.txt_AppPN.Name = "txt_AppPN";
            this.txt_AppPN.Size = new System.Drawing.Size(313, 31);
            this.txt_AppPN.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Patient Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "OR";
            // 
            // btn_Book
            // 
            this.btn_Book.Location = new System.Drawing.Point(752, 209);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(132, 57);
            this.btn_Book.TabIndex = 10;
            this.btn_Book.Text = "Book";
            this.btn_Book.UseVisualStyleBackColor = true;
            // 
            // dtp_App
            // 
            this.dtp_App.Location = new System.Drawing.Point(289, 199);
            this.dtp_App.Name = "dtp_App";
            this.dtp_App.Size = new System.Drawing.Size(321, 31);
            this.dtp_App.TabIndex = 11;
            // 
            // btn_CancelB
            // 
            this.btn_CancelB.Location = new System.Drawing.Point(930, 209);
            this.btn_CancelB.Name = "btn_CancelB";
            this.btn_CancelB.Size = new System.Drawing.Size(132, 57);
            this.btn_CancelB.TabIndex = 12;
            this.btn_CancelB.Text = "Cancel";
            this.btn_CancelB.UseVisualStyleBackColor = true;
            // 
            // btn_ChangeAP
            // 
            this.btn_ChangeAP.Location = new System.Drawing.Point(1097, 209);
            this.btn_ChangeAP.Name = "btn_ChangeAP";
            this.btn_ChangeAP.Size = new System.Drawing.Size(132, 57);
            this.btn_ChangeAP.TabIndex = 13;
            this.btn_ChangeAP.Text = "Change";
            this.btn_ChangeAP.UseVisualStyleBackColor = true;
            // 
            // txt_AppGpNa
            // 
            this.txt_AppGpNa.Location = new System.Drawing.Point(289, 262);
            this.txt_AppGpNa.Name = "txt_AppGpNa";
            this.txt_AppGpNa.Size = new System.Drawing.Size(355, 31);
            this.txt_AppGpNa.TabIndex = 14;
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 702);
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