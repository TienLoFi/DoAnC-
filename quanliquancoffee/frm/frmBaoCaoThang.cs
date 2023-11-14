using quanliquancoffee.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace quanliquancoffee.frm
{
    public partial class frmBaoCaoThang : Form
    {
        private DateTimePicker dtpkFromDate;
        private DateTimePicker dtpkToDate;
        public frmBaoCaoThang(DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            dtpkFromDate = new DateTimePicker();
            dtpkFromDate.Value = fromDate;

            dtpkToDate = new DateTimePicker();
            dtpkToDate.Value = toDate;
        }

      

        private void frmBaoCaoThang_Load(object sender, EventArgs e)
        {
           

            // Assuming that uSP_GetListBillByDateReportTableAdapter and reportViewer1 are related to your report
            this.uSP_GetListBillByDateReportTableAdapter.Fill(this.quanLiQuanCafeDataSet1.USP_GetListBillByDateReport, dtpkFromDate.Value, dtpkToDate.Value);

            this.reportViewer1.RefreshReport();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
          
        }
    }
}
