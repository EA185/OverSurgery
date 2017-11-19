namespace SE_1
{
    partial class CheckEmployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_ChkAV = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_CheckGPav = new System.Windows.Forms.Button();
            this.btn_CheckNurseAv = new System.Windows.Forms.Button();
            this.txt_NurName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_GPName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtp_ChkALL = new System.Windows.Forms.DateTimePicker();
            this.btn_Checkduty = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_GPav = new System.Windows.Forms.DataGridView();
            this.dgv_GPonDuty = new System.Windows.Forms.DataGridView();
            this.dgv_NURonDuty = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GPav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GPonDuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NURonDuty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_ChkAV);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_CheckGPav);
            this.panel1.Controls.Add(this.btn_CheckNurseAv);
            this.panel1.Controls.Add(this.txt_NurName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_GPName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 211);
            this.panel1.TabIndex = 0;
            // 
            // dtp_ChkAV
            // 
            this.dtp_ChkAV.Location = new System.Drawing.Point(123, 122);
            this.dtp_ChkAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_ChkAV.Name = "dtp_ChkAV";
            this.dtp_ChkAV.Size = new System.Drawing.Size(271, 25);
            this.dtp_ChkAV.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date:";
            // 
            // btn_CheckGPav
            // 
            this.btn_CheckGPav.Location = new System.Drawing.Point(22, 156);
            this.btn_CheckGPav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CheckGPav.Name = "btn_CheckGPav";
            this.btn_CheckGPav.Size = new System.Drawing.Size(175, 29);
            this.btn_CheckGPav.TabIndex = 6;
            this.btn_CheckGPav.Text = "Check GP Availability";
            this.btn_CheckGPav.UseVisualStyleBackColor = true;
            this.btn_CheckGPav.Click += new System.EventHandler(this.btn_CheckGPav_Click);
            // 
            // btn_CheckNurseAv
            // 
            this.btn_CheckNurseAv.Location = new System.Drawing.Point(234, 156);
            this.btn_CheckNurseAv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CheckNurseAv.Name = "btn_CheckNurseAv";
            this.btn_CheckNurseAv.Size = new System.Drawing.Size(175, 29);
            this.btn_CheckNurseAv.TabIndex = 5;
            this.btn_CheckNurseAv.Text = "Check Nurse Availability";
            this.btn_CheckNurseAv.UseVisualStyleBackColor = true;
            this.btn_CheckNurseAv.Click += new System.EventHandler(this.Btn_CheckAv_Click);
            // 
            // txt_NurName
            // 
            this.txt_NurName.Location = new System.Drawing.Point(123, 81);
            this.txt_NurName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_NurName.Name = "txt_NurName";
            this.txt_NurName.Size = new System.Drawing.Size(169, 25);
            this.txt_NurName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nurse Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "GP Name:";
            // 
            // txt_GPName
            // 
            this.txt_GPName.Location = new System.Drawing.Point(123, 40);
            this.txt_GPName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_GPName.Name = "txt_GPName";
            this.txt_GPName.Size = new System.Drawing.Size(169, 25);
            this.txt_GPName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check GP or Nurse Availability";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtp_ChkALL);
            this.panel2.Controls.Add(this.btn_Checkduty);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(18, 254);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 149);
            this.panel2.TabIndex = 1;
            // 
            // dtp_ChkALL
            // 
            this.dtp_ChkALL.Location = new System.Drawing.Point(123, 52);
            this.dtp_ChkALL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_ChkALL.Name = "dtp_ChkALL";
            this.dtp_ChkALL.Size = new System.Drawing.Size(271, 25);
            this.dtp_ChkALL.TabIndex = 5;
            // 
            // btn_Checkduty
            // 
            this.btn_Checkduty.Location = new System.Drawing.Point(123, 109);
            this.btn_Checkduty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Checkduty.Name = "btn_Checkduty";
            this.btn_Checkduty.Size = new System.Drawing.Size(92, 28);
            this.btn_Checkduty.TabIndex = 4;
            this.btn_Checkduty.Text = "Check";
            this.btn_Checkduty.UseVisualStyleBackColor = true;
            this.btn_Checkduty.Click += new System.EventHandler(this.btn_Checkduty_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Check ALL the GPs and nurses on duty";
            // 
            // dgv_GPav
            // 
            this.dgv_GPav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GPav.Location = new System.Drawing.Point(479, 18);
            this.dgv_GPav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_GPav.Name = "dgv_GPav";
            this.dgv_GPav.RowTemplate.Height = 33;
            this.dgv_GPav.Size = new System.Drawing.Size(389, 169);
            this.dgv_GPav.TabIndex = 2;
            // 
            // dgv_GPonDuty
            // 
            this.dgv_GPonDuty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GPonDuty.Location = new System.Drawing.Point(479, 233);
            this.dgv_GPonDuty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_GPonDuty.Name = "dgv_GPonDuty";
            this.dgv_GPonDuty.RowTemplate.Height = 33;
            this.dgv_GPonDuty.Size = new System.Drawing.Size(389, 169);
            this.dgv_GPonDuty.TabIndex = 3;
            // 
            // dgv_NURonDuty
            // 
            this.dgv_NURonDuty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NURonDuty.Location = new System.Drawing.Point(479, 420);
            this.dgv_NURonDuty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_NURonDuty.Name = "dgv_NURonDuty";
            this.dgv_NURonDuty.RowTemplate.Height = 33;
            this.dgv_NURonDuty.Size = new System.Drawing.Size(389, 176);
            this.dgv_NURonDuty.TabIndex = 4;
            this.dgv_NURonDuty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NURonDuty_CellContentClick);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 625);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(101, 31);
            this.btn_back.TabIndex = 26;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(799, 625);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(101, 31);
            this.btn_exit.TabIndex = 25;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // CheckEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 667);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.dgv_NURonDuty);
            this.Controls.Add(this.dgv_GPonDuty);
            this.Controls.Add(this.dgv_GPav);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CheckEmployee";
            this.Text = "CheckEmployee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GPav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GPonDuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NURonDuty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NurName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_GPName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_GPav;
        private System.Windows.Forms.Button btn_CheckNurseAv;
        private System.Windows.Forms.DataGridView dgv_GPonDuty;
        private System.Windows.Forms.Button btn_Checkduty;
        private System.Windows.Forms.DateTimePicker dtp_ChkALL;
        private System.Windows.Forms.Button btn_CheckGPav;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_ChkAV;
        private System.Windows.Forms.DataGridView dgv_NURonDuty;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_exit;
    }
}