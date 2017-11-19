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
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_ChkAV = new System.Windows.Forms.DateTimePicker();
            this.dgv_NURonDuty = new System.Windows.Forms.DataGridView();
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
            this.panel1.Location = new System.Drawing.Point(27, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 351);
            this.panel1.TabIndex = 0;
            // 
            // btn_CheckGPav
            // 
            this.btn_CheckGPav.Location = new System.Drawing.Point(33, 260);
            this.btn_CheckGPav.Name = "btn_CheckGPav";
            this.btn_CheckGPav.Size = new System.Drawing.Size(262, 48);
            this.btn_CheckGPav.TabIndex = 6;
            this.btn_CheckGPav.Text = "Check GP Availability";
            this.btn_CheckGPav.UseVisualStyleBackColor = true;
            this.btn_CheckGPav.Click += new System.EventHandler(this.btn_CheckGPav_Click);
            // 
            // btn_CheckNurseAv
            // 
            this.btn_CheckNurseAv.Location = new System.Drawing.Point(351, 260);
            this.btn_CheckNurseAv.Name = "btn_CheckNurseAv";
            this.btn_CheckNurseAv.Size = new System.Drawing.Size(262, 48);
            this.btn_CheckNurseAv.TabIndex = 5;
            this.btn_CheckNurseAv.Text = "Check Nurse Availability";
            this.btn_CheckNurseAv.UseVisualStyleBackColor = true;
            this.btn_CheckNurseAv.Click += new System.EventHandler(this.Btn_CheckAv_Click);
            // 
            // txt_NurName
            // 
            this.txt_NurName.Location = new System.Drawing.Point(185, 135);
            this.txt_NurName.Name = "txt_NurName";
            this.txt_NurName.Size = new System.Drawing.Size(251, 31);
            this.txt_NurName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nurse Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "GP Name:";
            // 
            // txt_GPName
            // 
            this.txt_GPName.Location = new System.Drawing.Point(185, 67);
            this.txt_GPName.Name = "txt_GPName";
            this.txt_GPName.Size = new System.Drawing.Size(251, 31);
            this.txt_GPName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check GP or Nurse Availability";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtp_ChkALL);
            this.panel2.Controls.Add(this.btn_Checkduty);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(27, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 248);
            this.panel2.TabIndex = 1;
            // 
            // dtp_ChkALL
            // 
            this.dtp_ChkALL.Location = new System.Drawing.Point(185, 87);
            this.dtp_ChkALL.Name = "dtp_ChkALL";
            this.dtp_ChkALL.Size = new System.Drawing.Size(404, 31);
            this.dtp_ChkALL.TabIndex = 5;
            // 
            // btn_Checkduty
            // 
            this.btn_Checkduty.Location = new System.Drawing.Point(185, 181);
            this.btn_Checkduty.Name = "btn_Checkduty";
            this.btn_Checkduty.Size = new System.Drawing.Size(138, 46);
            this.btn_Checkduty.TabIndex = 4;
            this.btn_Checkduty.Text = "Check";
            this.btn_Checkduty.UseVisualStyleBackColor = true;
            this.btn_Checkduty.Click += new System.EventHandler(this.btn_Checkduty_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Check ALL the GPs and nurses on duty";
            // 
            // dgv_GPav
            // 
            this.dgv_GPav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GPav.Location = new System.Drawing.Point(719, 30);
            this.dgv_GPav.Name = "dgv_GPav";
            this.dgv_GPav.RowTemplate.Height = 33;
            this.dgv_GPav.Size = new System.Drawing.Size(583, 282);
            this.dgv_GPav.TabIndex = 2;
            // 
            // dgv_GPonDuty
            // 
            this.dgv_GPonDuty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GPonDuty.Location = new System.Drawing.Point(719, 389);
            this.dgv_GPonDuty.Name = "dgv_GPonDuty";
            this.dgv_GPonDuty.RowTemplate.Height = 33;
            this.dgv_GPonDuty.Size = new System.Drawing.Size(583, 282);
            this.dgv_GPonDuty.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date:";
            // 
            // dtp_ChkAV
            // 
            this.dtp_ChkAV.Location = new System.Drawing.Point(185, 204);
            this.dtp_ChkAV.Name = "dtp_ChkAV";
            this.dtp_ChkAV.Size = new System.Drawing.Size(404, 31);
            this.dtp_ChkAV.TabIndex = 7;
            // 
            // dgv_NURonDuty
            // 
            this.dgv_NURonDuty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NURonDuty.Location = new System.Drawing.Point(719, 700);
            this.dgv_NURonDuty.Name = "dgv_NURonDuty";
            this.dgv_NURonDuty.RowTemplate.Height = 33;
            this.dgv_NURonDuty.Size = new System.Drawing.Size(583, 294);
            this.dgv_NURonDuty.TabIndex = 4;
            // 
            // CheckEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 1032);
            this.Controls.Add(this.dgv_NURonDuty);
            this.Controls.Add(this.dgv_GPonDuty);
            this.Controls.Add(this.dgv_GPav);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
    }
}