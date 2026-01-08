using Chude47.QuanLyTraiThuCung.QuanLyTraiThuCungDataSetTableAdapters;
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
    public partial class frmDanhSachDungDV : Form
    {
        public frmDanhSachDungDV()
        {
            InitializeComponent();
        }
        private void frmDanhSachDungDV_Load(object sender, EventArgs e)
        {
            //  Load dữ liệu gốc
            chamSocTableAdapter.Fill(quanLyTraiThuCungDataSet.ChamSoc);
            dichVuTableAdapter.Fill(quanLyTraiThuCungDataSet.DichVu);
            suDungDVTableAdapter.Fill(quanLyTraiThuCungDataSet.SuDungDV);

            // Load VIEW hiển thị
            vw_DanhSachSuDungDVTableAdapter.Fill(
                quanLyTraiThuCungDataSet.vw_DanhSachSuDungDV);

            // Bind ComboBox Mã Chăm Sóc
            cboMaCS.DataSource = chamSocBindingSource;
            cboMaCS.DisplayMember = "MaCS";
            cboMaCS.ValueMember = "MaCS";
            cboMaCS.SelectedIndex = -1;

            //  Bind CheckedListBox Dịch Vụ
            clbDichVu.DataSource = dichVuBindingSource;
            clbDichVu.DisplayMember = "TenDV";
            clbDichVu.ValueMember = "MaDV";

            // Bind DataGridView (VIEW)
            dgvDanhSach.DataSource = vw_DanhSachSuDungDVBindingSource;

            //  Sắp xếp các dòng cùng MaCS
            if (dgvDanhSach.Columns["MaCS"] != null)
            {
                dgvDanhSach.Sort(
                    dgvDanhSach.Columns["MaCS"],
                    ListSortDirection.Ascending);
            }
        }
        private void ReloadData()
        {
            quanLyTraiThuCungDataSet.SuDungDV.Clear();
            quanLyTraiThuCungDataSet.DichVu.Clear();

            suDungDVTableAdapter.Fill(quanLyTraiThuCungDataSet.SuDungDV);
            dichVuTableAdapter.Fill(quanLyTraiThuCungDataSet.DichVu);

            vw_DanhSachSuDungDVTableAdapter.Fill(
                quanLyTraiThuCungDataSet.vw_DanhSachSuDungDV);
        }
        private void dgvDanhSach_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // ======= Auto size tổng =======
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvDanhSach.AllowUserToResizeRows = false;

            // ======= MaCS =======
            if (dgvDanhSach.Columns["MaCS"] != null)
            {
                dgvDanhSach.Columns["MaCS"].HeaderText = "Mã Chăm Sóc";
                dgvDanhSach.Columns["MaCS"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }
            // ======= Ngày CS =======
            if (dgvDanhSach.Columns["NgayCS"] != null)
            {
                dgvDanhSach.Columns["NgayCS"].HeaderText = "Ngày Chăm Sóc";
                dgvDanhSach.Columns["NgayCS"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }


            // ======= Giá =======
            if (dgvDanhSach.Columns["Gia"] != null)
            {
                dgvDanhSach.Columns["Gia"].HeaderText = "Giá Tiền";
                dgvDanhSach.Columns["Gia"].DefaultCellStyle.Format = "#,##0'đ'";
                dgvDanhSach.Columns["Gia"].DefaultCellStyle.ForeColor = Color.DarkGreen;
            }
        }
        // ================= THÊM DỊCH VỤ =================
        private void btnThemCS_Click(object sender, EventArgs e)
        {
            if (cboMaCS.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn mã chăm sóc!");
                return;
            }

            string maCS = cboMaCS.SelectedValue.ToString();

            foreach (DataRowView item in clbDichVu.CheckedItems)
            {
                string maDV = item["MaDV"].ToString();

                var dt = new QuanLyTraiThuCungDataSet.SuDungDVDataTable();
                suDungDVTableAdapter.FillByCheckExist(dt, maCS, maDV);

                if (dt.Rows.Count == 0)
                {
                    suDungDVTableAdapter.Insert(maCS, maDV);
                }
            }

            vw_DanhSachSuDungDVTableAdapter.Fill(
                quanLyTraiThuCungDataSet.vw_DanhSachSuDungDV);
            ReloadData();
        }

        private void btnSuaCS_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
                return;
            }

            if (clbDichVu.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ mới!");
                return;
            }

            string maCS = dgvDanhSach.CurrentRow.Cells["MaCS"].Value.ToString();
            string maDV_Cu = dgvDanhSach.CurrentRow.Cells["MaDV"].Value.ToString();

            DataRowView item = clbDichVu.CheckedItems[0] as DataRowView;
            string maDV_Moi = item["MaDV"].ToString();

            if (maDV_Cu == maDV_Moi) return;

            suDungDVTableAdapter.Delete(maCS, maDV_Cu);
            suDungDVTableAdapter.Insert(maCS, maDV_Moi);

            ReloadData();

            MessageBox.Show("Đã sửa dịch vụ!");
        }

        private void btnXoaCS_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            string maCS = dgvDanhSach.CurrentRow.Cells["MaCS"].Value.ToString();
            string maDV = dgvDanhSach.CurrentRow.Cells["MaDV"].Value.ToString();

            DialogResult r = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa dịch vụ này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r != DialogResult.Yes) return;

            //  CHỈ XÓA
            suDungDVTableAdapter.Delete(maCS, maDV);
            //  LOAD LẠI DỮ LIỆU
            ReloadData();

            MessageBox.Show("Đã xóa dịch vụ!");
        }
         
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string maCS = dgvDanhSach.Rows[e.RowIndex]
                .Cells["MaCS"].Value.ToString();

            // set combobox
            cboMaCS.SelectedValue = maCS;

            // bỏ tick toàn bộ
            for (int i = 0; i < clbDichVu.Items.Count; i++)
                clbDichVu.SetItemChecked(i, false);

            // lấy danh sách DV theo MaCS
            DataRow[] rows = quanLyTraiThuCungDataSet.SuDungDV
                .Select($"MaCS = '{maCS}'");
            
            foreach (DataRow r in rows)
            {
                string maDV = r["MaDV"].ToString();

                for (int i = 0; i < clbDichVu.Items.Count; i++)
                {
                    DataRowView dv = clbDichVu.Items[i] as DataRowView;
                    if (dv["MaDV"].ToString() == maDV)
                    {
                        clbDichVu.SetItemChecked(i, true);
                        break;
                    }
                }
            }
        }

        private void gbChanSoc_Enter(object sender, EventArgs e)
        {

        }
    }
}
