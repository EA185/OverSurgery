﻿namespace SE_1
{
    partial class FindPatient
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PatIDS = new System.Windows.Forms.TextBox();
            this.txt_PaFstNameS = new System.Windows.Forms.TextBox();
            this.txt_DOBS = new System.Windows.Forms.TextBox();
            this.txt_AddS = new System.Windows.Forms.TextBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find A Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patient First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Of Birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address:";
            // 
            // txt_PatIDS
            // 
            this.txt_PatIDS.Location = new System.Drawing.Point(300, 180);
            this.txt_PatIDS.Name = "txt_PatIDS";
            this.txt_PatIDS.Size = new System.Drawing.Size(304, 31);
            this.txt_PatIDS.TabIndex = 5;
            // 
            // txt_PaFstNameS
            // 
            this.txt_PaFstNameS.Location = new System.Drawing.Point(300, 243);
            this.txt_PaFstNameS.Name = "txt_PaFstNameS";
            this.txt_PaFstNameS.Size = new System.Drawing.Size(304, 31);
            this.txt_PaFstNameS.TabIndex = 6;
            // 
            // txt_DOBS
            // 
            this.txt_DOBS.Location = new System.Drawing.Point(300, 308);
            this.txt_DOBS.Name = "txt_DOBS";
            this.txt_DOBS.Size = new System.Drawing.Size(304, 31);
            this.txt_DOBS.TabIndex = 7;
            // 
            // txt_AddS
            // 
            this.txt_AddS.Location = new System.Drawing.Point(300, 367);
            this.txt_AddS.Name = "txt_AddS";
            this.txt_AddS.Size = new System.Drawing.Size(304, 31);
            this.txt_AddS.TabIndex = 8;
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(300, 458);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(162, 55);
            this.btn_Find.TabIndex = 9;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(630, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(652, 526);
            this.dataGridView1.TabIndex = 10;
            // 
            // FindPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 702);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.txt_AddS);
            this.Controls.Add(this.txt_DOBS);
            this.Controls.Add(this.txt_PaFstNameS);
            this.Controls.Add(this.txt_PatIDS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FindPatient";
            this.Text = "FindPatient";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_PatIDS;
        private System.Windows.Forms.TextBox txt_PaFstNameS;
        private System.Windows.Forms.TextBox txt_DOBS;
        private System.Windows.Forms.TextBox txt_AddS;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}