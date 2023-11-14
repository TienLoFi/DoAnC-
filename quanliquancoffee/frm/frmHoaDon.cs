using quanliquancoffee.DAO;
using quanliquancoffee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanliquancoffee.frm
{
    public partial class frmHoaDon : Form
    {
        public int TableID { get; set; }
        private int discount;

        private double discountedTotalPrice;
        public void ShowBill(int id, int discount)
        {
            lsvBill1.Items.Clear();
            List<quanliquancoffee.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (quanliquancoffee.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());

                totalPrice += item.TotalPrice;
                lsvBill1.Items.Add(lsvItem);
            }


            //  Thread.CurrentThread.CurrentCulture = culture;

            float discountedTotalPrice = (totalPrice - (totalPrice / 100) * discount);

            CultureInfo culture = new CultureInfo("vi-VN");

            txbThanhTien.Text = totalPrice.ToString("c", culture);
            txbTongTien.Text = discountedTotalPrice.ToString("c", culture);

            txbDiscount.Text = discount.ToString();

            this.discount = discount;
            this.discountedTotalPrice = discountedTotalPrice;
        }
        public frmHoaDon()
        {
            InitializeComponent();

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {

        }
        void LoadListBill()

        {

        }
        private void lsvBillCheck_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(TableID);
            if (idBill != -1)
            {
                if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)discountedTotalPrice);
                    frmMainInterface mainForm = frmMainInterface.CurrentInstance;

                    // Kiểm tra xem mainForm có tồn tại không
                    if (mainForm != null)
                    {
                        MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Gọi lại các hàm từ form chính
                        mainForm.ShowBill(TableID);
                        mainForm.LoadTable();
                        // Hiển thị thông báo thanh toán thành công

                    }

                    // Đóng form thanh toán hoặc thực hiện các thao tác khác
                    this.Close();
                }


            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelCheck_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            float targetWidth = 752f;
            float targetHeight = 750f;

            // Tạo Bitmap mới với kích thước đã xác định
            Bitmap bmp = new Bitmap((int)targetWidth, (int)targetHeight);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Chụp hình ảnh của phần chứa hóa đơn
                this.panelContainingInvoice.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            }

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (s, pe) =>
            {
                // Vẽ hình ảnh lên trang in
                pe.Graphics.DrawImage(bmp, 0, 0, targetWidth, targetHeight);
            };

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
                MessageBox.Show("Quá trình in hoàn thành.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
