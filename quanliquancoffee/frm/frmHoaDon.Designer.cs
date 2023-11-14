namespace quanliquancoffee.frm
{
    partial class frmHoaDon
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
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancelCheck = new System.Windows.Forms.Button();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lsvBill1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbThanhTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelContainingInvoice = new System.Windows.Forms.Panel();
            this.panelContainingInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHILL COFFE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(143, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "56 Tăng Nhơn Phú , P . Tăng Nhơn Phú B , Thành Phố Thủ Đức";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(230, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phiếu Thanh Toán";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(597, 720);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(135, 33);
            this.btnThanhToan.TabIndex = 6;
            this.btnThanhToan.Text = "Thanh Toán ";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(289, 720);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(114, 33);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "In Hóa Đơn";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancelCheck
            // 
            this.btnCancelCheck.Location = new System.Drawing.Point(40, 720);
            this.btnCancelCheck.Name = "btnCancelCheck";
            this.btnCancelCheck.Size = new System.Drawing.Size(112, 33);
            this.btnCancelCheck.TabIndex = 8;
            this.btnCancelCheck.Text = "Hủy";
            this.btnCancelCheck.UseVisualStyleBackColor = true;
            this.btnCancelCheck.Click += new System.EventHandler(this.btnCancelCheck_Click);
            // 
            // txbTongTien
            // 
            this.txbTongTien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbTongTien.Location = new System.Drawing.Point(172, 609);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.ReadOnly = true;
            this.txbTongTien.Size = new System.Drawing.Size(239, 26);
            this.txbTongTien.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 611);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tổng Tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(443, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cảm Ơn Quý Khách Và Hẹn Gặp Lại";
            // 
            // lsvBill1
            // 
            this.lsvBill1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lsvBill1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill1.HideSelection = false;
            this.lsvBill1.Location = new System.Drawing.Point(51, 180);
            this.lsvBill1.Name = "lsvBill1";
            this.lsvBill1.Size = new System.Drawing.Size(669, 335);
            this.lsvBill1.TabIndex = 13;
            this.lsvBill1.UseCompatibleStateImageBehavior = false;
            this.lsvBill1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 130;
            // 
            // txbDiscount
            // 
            this.txbDiscount.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbDiscount.Location = new System.Drawing.Point(172, 565);
            this.txbDiscount.Name = "txbDiscount";
            this.txbDiscount.ReadOnly = true;
            this.txbDiscount.Size = new System.Drawing.Size(38, 26);
            this.txbDiscount.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(64, 567);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Giảm Giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(216, 566);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "%";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txbThanhTien
            // 
            this.txbThanhTien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbThanhTien.Location = new System.Drawing.Point(172, 526);
            this.txbThanhTien.Name = "txbThanhTien";
            this.txbThanhTien.ReadOnly = true;
            this.txbThanhTien.Size = new System.Drawing.Size(239, 26);
            this.txbThanhTien.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(60, 527);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Thành Tiền";
            // 
            // panelContainingInvoice
            // 
            this.panelContainingInvoice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContainingInvoice.Controls.Add(this.label1);
            this.panelContainingInvoice.Controls.Add(this.lsvBill1);
            this.panelContainingInvoice.Controls.Add(this.label2);
            this.panelContainingInvoice.Controls.Add(this.label8);
            this.panelContainingInvoice.Controls.Add(this.label3);
            this.panelContainingInvoice.Controls.Add(this.txbThanhTien);
            this.panelContainingInvoice.Controls.Add(this.txbTongTien);
            this.panelContainingInvoice.Controls.Add(this.label7);
            this.panelContainingInvoice.Controls.Add(this.label4);
            this.panelContainingInvoice.Controls.Add(this.label6);
            this.panelContainingInvoice.Controls.Add(this.label5);
            this.panelContainingInvoice.Controls.Add(this.txbDiscount);
            this.panelContainingInvoice.Location = new System.Drawing.Point(12, 12);
            this.panelContainingInvoice.Name = "panelContainingInvoice";
            this.panelContainingInvoice.Size = new System.Drawing.Size(755, 695);
            this.panelContainingInvoice.TabIndex = 20;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 794);
            this.Controls.Add(this.btnCancelCheck);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.panelContainingInvoice);
            this.MaximumSize = new System.Drawing.Size(827, 850);
            this.Name = "frmHoaDon";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.panelContainingInvoice.ResumeLayout(false);
            this.panelContainingInvoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancelCheck;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView lsvBill1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txbDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbThanhTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelContainingInvoice;
    }
}