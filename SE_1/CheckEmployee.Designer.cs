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
            this.dtp_ChkALL = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_GPav = new System.Windows.Forms.DataGridView();
            this.dgv_GPonDuty = new System.Windows.Forms.DataGridView();
            this.dgv_NURonDuty = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_GPName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NurName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_ChkAV = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Checkduty = new System.Windows.Forms.Button();
            this.btn_CheckGPav = new System.Windows.Forms.Button();
            this.btn_CheckNurseAv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GPav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GPonDuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NURonDuty)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_ChkALL
            // 
            this.dtp_ChkALL.Location = new System.Drawing.Point(107, 528);
            this.dtp_ChkALL.Name = "dtp_ChkALL";
            this.dtp_ChkALL.Size = new System.Drawing.Size(404, 31);
            this.dtp_ChkALL.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Check ALL the GPs and nurses on duty";
            // 
            // dgv_GPav
            // 
            this.dgv_GPav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GPav.Location = new System.Drawing.Point(43, 214);
            this.dgv_GPav.Name = "dgv_GPav";
            this.dgv_GPav.RowTemplate.Height = 33;
            this.dgv_GPav.Size = new System.Drawing.Size(1201, 250);
            this.dgv_GPav.TabIndex = 2;
            // 
            // dgv_GPonDuty
            // 
            this.dgv_GPonDuty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GPonDuty.Location = new System.Drawing.Point(43, 833);
            this.dgv_GPonDuty.Name = "dgv_GPonDuty";
            this.dgv_GPonDuty.RowTemplate.Height = 33;
            this.dgv_GPonDuty.Size = new System.Drawing.Size(1210, 181);
            this.dgv_GPonDuty.TabIndex = 3;
            // 
            // dgv_NURonDuty
            // 
            this.dgv_NURonDuty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NURonDuty.Location = new System.Drawing.Point(43, 603);
            this.dgv_NURonDuty.Name = "dgv_NURonDuty";
            this.dgv_NURonDuty.RowTemplate.Height = 33;
            this.dgv_NURonDuty.Size = new System.Drawing.Size(1210, 204);
            this.dgv_NURonDuty.TabIndex = 4;
            this.dgv_NURonDuty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NURonDuty_CellContentClick);
            // 
            // btn_back
            // 
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Image = global::SE_1.Properties.Resources.turn_right;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_back.Location = new System.Drawing.Point(833, 491);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(202, 106);
            this.btn_back.TabIndex = 26;
            this.btn_back.Text = "Back";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Image = global::SE_1.Properties.Resources.login__2_;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_exit.Location = new System.Drawing.Point(1092, 491);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(161, 106);
            this.btn_exit.TabIndex = 25;
            this.btn_exit.Text = "Exit";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check GP or Nurse Availability";
            // 
            // txt_GPName
            // 
            this.txt_GPName.Location = new System.Drawing.Point(233, 82);
            this.txt_GPName.Name = "txt_GPName";
            this.txt_GPName.Size = new System.Drawing.Size(252, 31);
            this.txt_GPName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "GP Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nurse Name:";
            // 
            // txt_NurName
            // 
            this.txt_NurName.Location = new System.Drawing.Point(233, 128);
            this.txt_NurName.Name = "txt_NurName";
            this.txt_NurName.Size = new System.Drawing.Size(252, 31);
            this.txt_NurName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(543, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date:";
            // 
            // dtp_ChkAV
            // 
            this.dtp_ChkAV.Location = new System.Drawing.Point(631, 76);
            this.dtp_ChkAV.Name = "dtp_ChkAV";
            this.dtp_ChkAV.Size = new System.Drawing.Size(404, 31);
            this.dtp_ChkAV.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 22);
            this.panel1.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(24, 1090);
            this.panel3.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1344, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(22, 1090);
            this.panel4.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(24, 1095);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1320, 17);
            this.panel5.TabIndex = 30;
            // 
            // btn_Checkduty
            // 
            this.btn_Checkduty.FlatAppearance.BorderSize = 0;
            this.btn_Checkduty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Checkduty.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Checkduty.Image = global::SE_1.Properties.Resources.search;
            this.btn_Checkduty.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Checkduty.Location = new System.Drawing.Point(548, 487);
            this.btn_Checkduty.Name = "btn_Checkduty";
            this.btn_Checkduty.Size = new System.Drawing.Size(202, 90);
            this.btn_Checkduty.TabIndex = 4;
            this.btn_Checkduty.Text = "Check";
            this.btn_Checkduty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Checkduty.UseVisualStyleBackColor = true;
            this.btn_Checkduty.Click += new System.EventHandler(this.btn_Checkduty_Click);
            // 
            // btn_CheckGPav
            // 
            this.btn_CheckGPav.FlatAppearance.BorderSize = 0;
            this.btn_CheckGPav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CheckGPav.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckGPav.Image = global::SE_1.Properties.Resources.search;
            this.btn_CheckGPav.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CheckGPav.Location = new System.Drawing.Point(548, 128);
            this.btn_CheckGPav.Name = "btn_CheckGPav";
            this.btn_CheckGPav.Size = new System.Drawing.Size(304, 62);
            this.btn_CheckGPav.TabIndex = 6;
            this.btn_CheckGPav.Text = "Check GP Availability";
            this.btn_CheckGPav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CheckGPav.UseVisualStyleBackColor = true;
            this.btn_CheckGPav.Click += new System.EventHandler(this.btn_CheckGPav_Click);
            // 
            // btn_CheckNurseAv
            // 
            this.btn_CheckNurseAv.FlatAppearance.BorderSize = 0;
            this.btn_CheckNurseAv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CheckNurseAv.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckNurseAv.Image = global::SE_1.Properties.Resources.search;
            this.btn_CheckNurseAv.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CheckNurseAv.Location = new System.Drawing.Point(907, 128);
            this.btn_CheckNurseAv.Name = "btn_CheckNurseAv";
            this.btn_CheckNurseAv.Size = new System.Drawing.Size(338, 62);
            this.btn_CheckNurseAv.TabIndex = 5;
            this.btn_CheckNurseAv.Text = "Check Nurse Availability";
            this.btn_CheckNurseAv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CheckNurseAv.UseVisualStyleBackColor = true;
            this.btn_CheckNurseAv.Click += new System.EventHandler(this.Btn_CheckAv_Click);
            // 
            // CheckEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1366, 1112);
            this.Controls.Add(this.dtp_ChkALL);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btn_Checkduty);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtp_ChkAV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_CheckGPav);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_CheckNurseAv);
            this.Controls.Add(this.dgv_NURonDuty);
            this.Controls.Add(this.txt_NurName);
            this.Controls.Add(this.dgv_GPonDuty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_GPav);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_GPName);
            this.Controls.Add(this.label1);
            this.Name = "CheckEmployee";
            this.Text = "CheckEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GPav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GPonDuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NURonDuty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_GPav;
        private System.Windows.Forms.DataGridView dgv_GPonDuty;
        private System.Windows.Forms.Button btn_Checkduty;
        private System.Windows.Forms.DateTimePicker dtp_ChkALL;
        private System.Windows.Forms.DataGridView dgv_NURonDuty;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_GPName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NurName;
        private System.Windows.Forms.Button btn_CheckNurseAv;
        private System.Windows.Forms.Button btn_CheckGPav;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_ChkAV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}