namespace SE_1
{
    partial class Booking
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_AppGpNa = new System.Windows.Forms.TextBox();
            this.btn_ChangeAP = new System.Windows.Forms.Button();
            this.dtp_App = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_AppPN = new System.Windows.Forms.TextBox();
            this.txt_AppPID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 379);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(101, 31);
            this.btn_back.TabIndex = 24;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(799, 379);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(101, 31);
            this.btn_exit.TabIndex = 23;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_AppGpNa
            // 
            this.txt_AppGpNa.Location = new System.Drawing.Point(407, 247);
            this.txt_AppGpNa.Margin = new System.Windows.Forms.Padding(2);
            this.txt_AppGpNa.Name = "txt_AppGpNa";
            this.txt_AppGpNa.Size = new System.Drawing.Size(238, 25);
            this.txt_AppGpNa.TabIndex = 35;
            // 
            // btn_ChangeAP
            // 
            this.btn_ChangeAP.Location = new System.Drawing.Point(690, 379);
            this.btn_ChangeAP.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ChangeAP.Name = "btn_ChangeAP";
            this.btn_ChangeAP.Size = new System.Drawing.Size(91, 31);
            this.btn_ChangeAP.TabIndex = 34;
            this.btn_ChangeAP.Text = "Change";
            this.btn_ChangeAP.UseVisualStyleBackColor = true;
            this.btn_ChangeAP.Click += new System.EventHandler(this.btn_ChangeAP_Click);
            // 
            // dtp_App
            // 
            this.dtp_App.Location = new System.Drawing.Point(407, 209);
            this.dtp_App.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_App.Name = "dtp_App";
            this.dtp_App.Size = new System.Drawing.Size(238, 25);
            this.dtp_App.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "OR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Patient Name:";
            // 
            // txt_AppPN
            // 
            this.txt_AppPN.Location = new System.Drawing.Point(407, 172);
            this.txt_AppPN.Margin = new System.Windows.Forms.Padding(2);
            this.txt_AppPN.Name = "txt_AppPN";
            this.txt_AppPN.Size = new System.Drawing.Size(238, 25);
            this.txt_AppPN.TabIndex = 29;
            // 
            // txt_AppPID
            // 
            this.txt_AppPID.Location = new System.Drawing.Point(407, 137);
            this.txt_AppPID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_AppPID.Name = "txt_AppPID";
            this.txt_AppPID.Size = new System.Drawing.Size(238, 25);
            this.txt_AppPID.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "GP Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Appointment Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Patient ID:";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 421);
            this.Controls.Add(this.txt_AppGpNa);
            this.Controls.Add(this.btn_ChangeAP);
            this.Controls.Add(this.dtp_App);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_AppPN);
            this.Controls.Add(this.txt_AppPID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_exit);
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_AppGpNa;
        private System.Windows.Forms.Button btn_ChangeAP;
        private System.Windows.Forms.DateTimePicker dtp_App;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_AppPN;
        private System.Windows.Forms.TextBox txt_AppPID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}