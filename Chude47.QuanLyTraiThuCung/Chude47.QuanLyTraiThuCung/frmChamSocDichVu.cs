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
    public partial class frmChamSocDichVu : Form
    {
        string cheDo = "ChamSoc"; // mặc định

        public frmChamSocDichVu()
        {
            InitializeComponent();
        }

        private void frmChamSocDichVu_Load(object sender, EventArgs e)
        {
            thuCungTableAdapter.Fill(quanLyTraiThuCungDataSet.ThuCung);
            chuNhanTableAdapter.Fill(quanLyTraiThuCungDataSet.ChuNhan);
            dichVuTableAdapter.Fill(quanLyTraiThuCungDataSet.DichVu);

            chamSocTableAdapter.Fill(quanLyTraiThuCungDataSet.ChamSoc);
            vw_ChamSocFullTableAdapter.Fill(quanLyTraiThuCungDataSet.vw_ChamSocFull);

            // ComboBox
            cboMaTC.DataSource = quanLyTraiThuCungDataSet.ThuCung;
            cboMaTC.DisplayMember = "MaTC";
            cboMaTC.ValueMember = "MaTC";

            cboMaCN.DataSource = quanLyTraiThuCungDataSet.ChuNhan;
            cboMaCN.DisplayMember = "MaCN";
            cboMaCN.ValueMember = "MaCN";

            // DataGridView
            dgvChamSoc.DataSource = vw_ChamSocFullBindingSource;
            dgvDichVu.DataSource = dichVuBindingSource;
       
        }

        
        // ================= CHAM SOC =================
        private void dgvChamSoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            cheDo = "ChamSoc";

            DataRowView row = dgvChamSoc.Rows[e.RowIndex].DataBoundItem as DataRowView;

            cboMaTC.SelectedValue = row["MaTC"];
            cboMaCN.SelectedValue = row["MaCN"];
            dtpNgayCS.Value = Convert.ToDateTime(row["NgayCS"]);
        }

        private string TaoMaCS()
        {
            int so = quanLyTraiThuCungDataSet.ChamSoc.Rows.Count + 1;
            return "CS" + so.ToString("00");
        }

        private void ClearChamSoc()
        {
            cboMaTC.SelectedIndex = -1;
            cboMaCN.SelectedIndex = -1;
            dtpNgayCS.Value = DateTime.Now;
        }

        // ================= DICH VU =================
        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            cheDo = "DichVu";
        }

        // ================= BUTTON =================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cheDo == "ChamSoc")
            {
                chamSocTableAdapter.Insert(
                    TaoMaCS(),
                    cboMaTC.SelectedValue.ToString(),
                    cboMaCN.SelectedValue.ToString(),
                    dtpNgayCS.Value
                );

                vw_ChamSocFullTableAdapter.Fill(quanLyTraiThuCungDataSet.vw_ChamSocFull);
                ClearChamSoc();
            }
            else
            {
                dichVuBindingSource.AddNew();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Validate();

            if (cheDo == "ChamSoc")
            {
                chamSocBindingSource.EndEdit();
                chamSocTableAdapter.Update(quanLyTraiThuCungDataSet.ChamSoc);
                vw_ChamSocFullTableAdapter.Fill(quanLyTraiThuCungDataSet.vw_ChamSocFull);
            }
            else
            {
                dichVuBindingSource.EndEdit();
                dichVuTableAdapter.Update(quanLyTraiThuCungDataSet.DichVu);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cheDo == "ChamSoc")
            {
                if (dgvChamSoc.CurrentRow == null) return;

                DataRowView row =
                    dgvChamSoc.CurrentRow.DataBoundItem as DataRowView;

                string maCS = row["MaCS"].ToString();

                if (MessageBox.Show("Xóa lần chăm sóc này?",
                    "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                suDungDVTableAdapter.DeleteByMaCS(maCS);
                chamSocTableAdapter.DeleteByMaCS(maCS);

                vw_ChamSocFullTableAdapter.Fill(quanLyTraiThuCungDataSet.vw_ChamSocFull);
            }
            else
            {
                if (MessageBox.Show("Xóa dịch vụ này?",
                    "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                dichVuBindingSource.RemoveCurrent();
                dichVuTableAdapter.Update(quanLyTraiThuCungDataSet.DichVu);
            }
        }

        private void dgvChamSoc_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string[] cotAn = { "MaTC", "MaCN" };

            foreach (string c in cotAn)
            {
                if (dgvChamSoc.Columns[c] != null)
                    dgvChamSoc.Columns[c].Visible = false;
            }

            dgvChamSoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvDichVu_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDichVu.Columns["Gia"].HeaderText = "Giá Tiền";
            dgvDichVu.Columns["Gia"].DefaultCellStyle.Format = "#,##0'đ'";
            dgvDichVu.Columns["Gia"].DefaultCellStyle.ForeColor = Color.DarkGreen;
        }
    }
}
