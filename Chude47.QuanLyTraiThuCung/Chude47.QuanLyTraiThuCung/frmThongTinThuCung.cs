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
    public partial class frmThongTinThuCung : Form
    {
        public frmThongTinThuCung()
        {
            InitializeComponent();
        }

        private void frmThongTinThuCung_Load(object sender, EventArgs e)
        {
            // Load dữ liệu
            this.thuCungTableAdapter.Fill(this.quanLyTraiThuCungDataSet.ThuCung);
            this.chuNhanTableAdapter.Fill(this.quanLyTraiThuCungDataSet.ChuNhan);

            // Gán BindingSource cho DataGridView
            dgvThuCung.DataSource = thuCungBindingSource;
            dgvChuNhan.DataSource = chuNhanBindingSource;
        }
        // ================= THÚ CƯNG =================
        private void btnThem_Click(object sender, EventArgs e)
        {
            thuCungBindingSource.AddNew();

            // tránh NULL MaTC
            DataRowView row = thuCungBindingSource.Current as DataRowView;
            row["MaTC"] = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Validate();
            thuCungBindingSource.EndEdit();

            //  LƯU VÀO DB
            thuCungTableAdapter.Update(quanLyTraiThuCungDataSet.ThuCung);

            //  LOAD LẠI → form khác dùng được
            thuCungTableAdapter.Fill(quanLyTraiThuCungDataSet.ThuCung);

            MessageBox.Show("Đã lưu thú cưng!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa thú cưng này?","Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                thuCungBindingSource.RemoveCurrent();
                thuCungTableAdapter.Update(quanLyTraiThuCungDataSet.ThuCung);
                thuCungTableAdapter.Fill(quanLyTraiThuCungDataSet.ThuCung);
            }
        }
        // ================= CHỦ NHÂN =================
        private void btnThemCN_Click(object sender, EventArgs e)
        {
            chuNhanBindingSource.AddNew();

            // tránh NULL MaCN
            DataRowView row = chuNhanBindingSource.Current as DataRowView;
            row["MaCN"] = "";
        }

        private void btnSuaCN_Click(object sender, EventArgs e)
        {
            this.Validate();
            chuNhanBindingSource.EndEdit();

            //  LƯU DB
            chuNhanTableAdapter.Update(quanLyTraiThuCungDataSet.ChuNhan);

            //  LOAD LẠI → frmChamSocDichVu thấy ngay
            chuNhanTableAdapter.Fill(quanLyTraiThuCungDataSet.ChuNhan);

            MessageBox.Show("Đã lưu chủ nhân!");
        }

        private void btnXoaCN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa chủ nhân này?",
            "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                chuNhanBindingSource.RemoveCurrent();
                chuNhanTableAdapter.Update(quanLyTraiThuCungDataSet.ChuNhan);
                chuNhanTableAdapter.Fill(quanLyTraiThuCungDataSet.ChuNhan);
            }
        }
    }
}
