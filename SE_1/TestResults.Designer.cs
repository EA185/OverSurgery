namespace SE_1
{
    partial class TestResults
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
            this.dgv_test = new System.Windows.Forms.DataGridView();
            this.txt_Results = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_test)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_test
            // 
            this.dgv_test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_test.Location = new System.Drawing.Point(204, 23);
            this.dgv_test.Name = "dgv_test";
            this.dgv_test.Size = new System.Drawing.Size(313, 199);
            this.dgv_test.TabIndex = 0;
            // 
            // txt_Results
            // 
            this.txt_Results.Location = new System.Drawing.Point(73, 61);
            this.txt_Results.Name = "txt_Results";
            this.txt_Results.Size = new System.Drawing.Size(100, 20);
            this.txt_Results.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patient ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Results);
            this.Controls.Add(this.dgv_test);
            this.Name = "TestResults";
            this.Text = "TestResults";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_test)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_test;
        private System.Windows.Forms.TextBox txt_Results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}