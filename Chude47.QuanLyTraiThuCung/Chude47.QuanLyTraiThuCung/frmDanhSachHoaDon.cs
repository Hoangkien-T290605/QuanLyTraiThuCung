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
    public partial class frmDanhSachHoaDon : Form
    {
        public frmDanhSachHoaDon()
        {
            InitializeComponent();
        }

        private void frmDanhSachHoaDon_Load(object sender, EventArgs e)
        {
            vw_DanhSachSuDungDVTableAdapter.Fill(
       quanLyTraiThuCungDataSet.vw_DanhSachSuDungDV);

            // ComboBox chỉ lấy MaCS (DISTINCT)
            cboMaCS.DataSource = quanLyTraiThuCungDataSet.vw_DanhSachSuDungDV
                .DefaultView.ToTable(true, "MaCS");

            cboMaCS.DisplayMember = "MaCS";
            cboMaCS.ValueMember = "MaCS";
            cboMaCS.SelectedIndex = -1;

            // Reset form
            dgvHoaDon.DataSource = null;
            txtTenTC.Clear();
            txtTenCN.Clear();
            txtNgayCS.Clear();
            txtTongTien.Clear();
        }

        private void cboMaCS_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string maCS = cboMaCS.SelectedValue.ToString();

            // LẤY ĐÚNG DỮ LIỆU THEO MaCS
            DataRow[] rows = quanLyTraiThuCungDataSet.vw_DanhSachSuDungDV
                .Select($"MaCS = '{maCS}'");

            if (rows.Length == 0)
            {
                dgvHoaDon.DataSource = null;
                return;
            }

            //  ĐỔ DỊCH VỤ + GIÁ VÀO DGV
            dgvHoaDon.DataSource = rows.CopyToDataTable();

            //  ĐỔ THÔNG TIN CHUNG
            txtTenTC.Text = rows[0]["TenTC"].ToString();
            txtTenCN.Text = rows[0]["TenCN"].ToString();
            txtNgayCS.Text = Convert.ToDateTime(rows[0]["NgayCS"])
                                .ToString("dd/MM/yyyy");

            //  TÍNH TỔNG TIỀN
            decimal tongTien = rows.Sum(r => Convert.ToDecimal(r["Gia"]));
            txtTongTien.Text = $"{tongTien:#,##0} đ";
        }

        private void dgvHoaDon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // ======= Giá =======
            if (dgvHoaDon.Columns["Gia"] != null)
            {
                dgvHoaDon.Columns["Gia"].HeaderText = "Giá Tiền";
                dgvHoaDon.Columns["Gia"].DefaultCellStyle.Format = "#,##0'đ'";
                dgvHoaDon.Columns["Gia"].DefaultCellStyle.ForeColor = Color.DarkGreen;
            }
        }
    }
}
