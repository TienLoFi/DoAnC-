namespace quanliquancoffee.frm
{
    partial class frmBaoCaoThang
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.uSPGetListBillByDateReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnprint = new System.Windows.Forms.Button();
            this.USP_GetListBillByDateReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiQuanCafeDataSet1 = new quanliquancoffee.QuanLiQuanCafeDataSet1();
            this.quanLiQuanCafeDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_GetListBillByDateReportTableAdapter = new quanliquancoffee.QuanLiQuanCafeDataSet1TableAdapters.USP_GetListBillByDateReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiQuanCafeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiQuanCafeDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uSPGetListBillByDateReportBindingSource
            // 
            this.uSPGetListBillByDateReportBindingSource.DataMember = "USP_GetListBillByDateReport";
            this.uSPGetListBillByDateReportBindingSource.DataSource = this.quanLiQuanCafeDataSet1BindingSource;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_GetListBillByDateReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "quanliquancoffee.frm.baocao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-5, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(803, 446);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(889, 150);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(76, 40);
            this.btnprint.TabIndex = 1;
            this.btnprint.Text = "load";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // USP_GetListBillByDateReportBindingSource
            // 
            this.USP_GetListBillByDateReportBindingSource.DataMember = "USP_GetListBillByDateReport";
            this.USP_GetListBillByDateReportBindingSource.DataSource = this.quanLiQuanCafeDataSet1;
            // 
            // quanLiQuanCafeDataSet1
            // 
            this.quanLiQuanCafeDataSet1.DataSetName = "QuanLiQuanCafeDataSet1";
            this.quanLiQuanCafeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLiQuanCafeDataSet1BindingSource
            // 
            this.quanLiQuanCafeDataSet1BindingSource.DataSource = this.quanLiQuanCafeDataSet1;
            this.quanLiQuanCafeDataSet1BindingSource.Position = 0;
            // 
            // uSP_GetListBillByDateReportTableAdapter
            // 
            this.uSP_GetListBillByDateReportTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 845);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBaoCaoThang";
            this.Text = "frmBaoCaoThang";
            this.Load += new System.EventHandler(this.frmBaoCaoThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiQuanCafeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiQuanCafeDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPGetListBillByDateReportBindingSource;
        private System.Windows.Forms.BindingSource quanLiQuanCafeDataSet1BindingSource;
        private QuanLiQuanCafeDataSet1 quanLiQuanCafeDataSet1;
        private QuanLiQuanCafeDataSet1TableAdapters.USP_GetListBillByDateReportTableAdapter uSP_GetListBillByDateReportTableAdapter;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.BindingSource USP_GetListBillByDateReportBindingSource;
    }
}