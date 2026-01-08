using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chude47.QuanLyTraiThuCung
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }
        private void SetTitle(string title)
        {
            lblTrang.Text = title;// Cập nhật tiêu đề
                                  // 2. Cập nhật lại layout ngay
            lblTrang.Refresh();

            // 3. Gạch chân chạy theo chữ
            picUnderline.Width = lblTrang.Width;
            picUnderline.Left = lblTrang.Left;
            picUnderline.Top = lblTrang.Bottom + 2;

        }
        private void LoadFormToPanel(Form f)
        {
            // 1. ẨN HOME
            panelHome.Visible = false;

            // 2. Xóa form con cũ
            panelContent.Controls.Clear();

            // 3. Nhúng form mới
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            panelContent.Controls.Add(f);
            f.Show();
        }
        // Sự kiện load form
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            panelHome.BringToFront();
            SetTitle("Trang chủ – Quản Lý Trại Thú Cưng");
        }
        // Sự kiện nút Home
        private void btnHome_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            panelHome.Visible = true;
            panelHome.BringToFront();
            SetTitle("Trang chủ – Quản Lý Trại Thú Cưng");
        }
        // Sự kiện nút Thông tin thú cưng
        private void btnThongTinThuCung_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new frmThongTinThuCung());
            SetTitle("Thông tin thú cưng");
        }
        // Sự kiện nút Chăm sóc dịch vụ
        private void btnChamSocDichVu_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new frmChamSocDichVu());
            SetTitle("Chăm sóc và Dịch vụ");
        }
        // Sự kiện nút Danh sách
        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new frmDanhSachDungDV());
            SetTitle("Danh sách thống kê sử dụng dịch vụ");
        }
        // Sự kiện nút Hóa đơn
        private void btHoaDon_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new frmDanhSachHoaDon());
            SetTitle("Bảng thanh toán hóa đơn");
        }
        // Sự kiện nút Báo cáo thống kê
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // 1. Đóng tất cả form con đang nằm trong panelContent
            foreach (Control ctrl in panelContent.Controls)
            {
                if (ctrl is Form)
                {
                    ((Form)ctrl).Close();
                }
            }

            // 2. Mở lại form Login
            frmLogin login = new frmLogin();
            login.Show();

            // 3. Đóng form Trang Chủ
            this.Close();
        }

        private void picAnhNguon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
