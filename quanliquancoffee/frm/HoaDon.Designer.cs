namespace quanliquancoffee.frm
{
    partial class HoaDon
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancelCheck = new System.Windows.Forms.Button();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 153);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(669, 440);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHILL COFFE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(115, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "56 Tăng Nhơn Phú , P . Tăng Nhơn Phú B , Thành Phố Thủ Đức";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phiếu Thanh Toán";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(557, 757);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(135, 33);
            this.btnThanhToan.TabIndex = 6;
            this.btnThanhToan.Text = "Thanh Toán ";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(424, 757);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(114, 33);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "In Hóa Đơn";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnCancelCheck
            // 
            this.btnCancelCheck.Location = new System.Drawing.Point(271, 757);
            this.btnCancelCheck.Name = "btnCancelCheck";
            this.btnCancelCheck.Size = new System.Drawing.Size(112, 33);
            this.btnCancelCheck.TabIndex = 8;
            this.btnCancelCheck.Text = "Hủy";
            this.btnCancelCheck.UseVisualStyleBackColor = true;
            // 
            // txbTongTien
            // 
            this.txbTongTien.Location = new System.Drawing.Point(202, 604);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.Size = new System.Drawing.Size(100, 26);
            this.txbTongTien.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News706 BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 599);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tổng Tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(450, 640);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cảm Ơn Quý Khách Hẹn Gặp Lại";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 802);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbTongTien);
            this.Controls.Add(this.btnCancelCheck);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancelCheck;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}