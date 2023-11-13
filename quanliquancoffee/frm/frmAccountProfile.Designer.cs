namespace quanliquancoffee.frm
{
    partial class frmAccountProfile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CCCV = new System.Windows.Forms.Panel();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbReEnterPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExitaccount = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.CCCV.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Cá Nhân ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbUserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 54);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(221, 15);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ReadOnly = true;
            this.txbUserName.Size = new System.Drawing.Size(457, 26);
            this.txbUserName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Đăng Nhập:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // CCCV
            // 
            this.CCCV.Controls.Add(this.txbDisplayName);
            this.CCCV.Controls.Add(this.label3);
            this.CCCV.Location = new System.Drawing.Point(12, 118);
            this.CCCV.Name = "CCCV";
            this.CCCV.Size = new System.Drawing.Size(776, 63);
            this.CCCV.TabIndex = 3;
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Location = new System.Drawing.Point(221, 15);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(457, 26);
            this.txbDisplayName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(13, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Hiển Thị:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbPassWord);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 71);
            this.panel2.TabIndex = 4;
            // 
            // txbPassWord
            // 
            this.txbPassWord.Location = new System.Drawing.Point(221, 25);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(457, 26);
            this.txbPassWord.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(22, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật Khẩu:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbNewPass);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(12, 264);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 60);
            this.panel3.TabIndex = 5;
            // 
            // txbNewPass
            // 
            this.txbNewPass.Location = new System.Drawing.Point(221, 18);
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.Size = new System.Drawing.Size(457, 26);
            this.txbNewPass.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(22, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mật Khẩu Mới:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbReEnterPass);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(12, 343);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 51);
            this.panel4.TabIndex = 6;
            // 
            // txbReEnterPass
            // 
            this.txbReEnterPass.Location = new System.Drawing.Point(221, 13);
            this.txbReEnterPass.Name = "txbReEnterPass";
            this.txbReEnterPass.Size = new System.Drawing.Size(457, 26);
            this.txbReEnterPass.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(22, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhập Lại Mật Khẩu Mới:";
            // 
            // btnExitaccount
            // 
            this.btnExitaccount.BackColor = System.Drawing.Color.Red;
            this.btnExitaccount.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExitaccount.Location = new System.Drawing.Point(638, 400);
            this.btnExitaccount.Name = "btnExitaccount";
            this.btnExitaccount.Size = new System.Drawing.Size(150, 38);
            this.btnExitaccount.TabIndex = 7;
            this.btnExitaccount.Text = "Thoát";
            this.btnExitaccount.UseVisualStyleBackColor = false;
            this.btnExitaccount.Click += new System.EventHandler(this.btnExitaccount_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdate.Location = new System.Drawing.Point(414, 400);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(188, 38);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "Cập Nhật";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // frmAccountProfile
            // 
            this.AcceptButton = this.btnupdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExitaccount;
            this.ClientSize = new System.Drawing.Size(1256, 784);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnExitaccount);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CCCV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmAccountProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Cá Nhân";
            this.Load += new System.EventHandler(this.frmAccountProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CCCV.ResumeLayout(false);
            this.CCCV.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Panel CCCV;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbReEnterPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExitaccount;
        private System.Windows.Forms.Button btnupdate;
    }
}