namespace SE_1
{
    partial class Menu
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_exitM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(358, 115);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(255, 111);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register A Patient";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(691, 115);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(255, 111);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check Employee Availability";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(358, 292);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(255, 111);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find A Patient";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(691, 292);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(255, 111);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Book An Appointment";
            this.btnBook.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(358, 458);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(255, 111);
            this.button5.TabIndex = 4;
            this.button5.Text = "Print Prescriptiom";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(691, 458);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(255, 111);
            this.button6.TabIndex = 5;
            this.button6.Text = "Print Result";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btn_exitM
            // 
            this.btn_exitM.Location = new System.Drawing.Point(38, 595);
            this.btn_exitM.Name = "btn_exitM";
            this.btn_exitM.Size = new System.Drawing.Size(145, 53);
            this.btn_exitM.TabIndex = 7;
            this.btn_exitM.Text = "Exit";
            this.btn_exitM.UseVisualStyleBackColor = true;
            this.btn_exitM.Click += new System.EventHandler(this.btn_exitM_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 702);
            this.Controls.Add(this.btn_exitM);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnRegister);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_exitM;
    }
}