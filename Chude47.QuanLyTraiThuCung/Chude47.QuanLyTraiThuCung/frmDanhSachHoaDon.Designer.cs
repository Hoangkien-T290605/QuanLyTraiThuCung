namespace Chude47.QuanLyTraiThuCung
{
    partial class frmDanhSachHoaDon
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
            this.lblMaCS = new System.Windows.Forms.Label();
            this.cboMaCS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.vw_DanhSachSuDungDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyTraiThuCungDataSet = new Chude47.QuanLyTraiThuCung.QuanLyTraiThuCungDataSet();
            this.vw_DanhSachSuDungDVTableAdapter = new Chude47.QuanLyTraiThuCung.QuanLyTraiThuCungDataSetTableAdapters.vw_DanhSachSuDungDVTableAdapter();
            this.tableAdapterManager = new Chude47.QuanLyTraiThuCung.QuanLyTraiThuCungDataSetTableAdapters.TableAdapterManager();
            this.lblTenThuCung = new System.Windows.Forms.Label();
            this.lblChuNhan = new System.Windows.Forms.Label();
            this.lblNgayCS = new System.Windows.Forms.Label();
            this.lblTổngBill = new System.Windows.Forms.Label();
            this.txtTenTC = new System.Windows.Forms.TextBox();
            this.txtTenCN = new System.Windows.Forms.TextBox();
            this.txtNgayCS = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_DanhSachSuDungDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTraiThuCungDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaCS
            // 
            this.lblMaCS.AutoSize = true;
            this.lblMaCS.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCS.Location = new System.Drawing.Point(299, 84);
            this.lblMaCS.Name = "lblMaCS";
            this.lblMaCS.Size = new System.Drawing.Size(176, 25);
            this.lblMaCS.TabIndex = 0;
            this.lblMaCS.Text = "Chọn mã chăm sóc:";
            // 
            // cboMaCS
            // 
            this.cboMaCS.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaCS.FormattingEnabled = true;
            this.cboMaCS.Location = new System.Drawing.Point(493, 84);
            this.cboMaCS.Name = "cboMaCS";
            this.cboMaCS.Size = new System.Drawing.Size(166, 33);
            this.cboMaCS.TabIndex = 1;
            this.cboMaCS.SelectionChangeCommitted += new System.EventHandler(this.cboMaCS_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hóa Đơn Thanh Toán";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Orange;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1012, 10);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Orange;
            this.pictureBox2.Location = new System.Drawing.Point(370, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(222, 2);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Orange;
            this.pictureBox3.Location = new System.Drawing.Point(313, 112);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(162, 2);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // vw_DanhSachSuDungDVBindingSource
            // 
            this.vw_DanhSachSuDungDVBindingSource.DataMember = "vw_DanhSachSuDungDV";
            this.vw_DanhSachSuDungDVBindingSource.DataSource = this.quanLyTraiThuCungDataSet;
            // 
            // quanLyTraiThuCungDataSet
            // 
            this.quanLyTraiThuCungDataSet.DataSetName = "QuanLyTraiThuCungDataSet";
            this.quanLyTraiThuCungDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_DanhSachSuDungDVTableAdapter
            // 
            this.vw_DanhSachSuDungDVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChamSocTableAdapter = null;
            this.tableAdapterManager.ChuNhanTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DichVuTableAdapter = null;
            this.tableAdapterManager.SuDungDVTableAdapter = null;
            this.tableAdapterManager.ThuCungTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Chude47.QuanLyTraiThuCung.QuanLyTraiThuCungDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblTenThuCung
            // 
            this.lblTenThuCung.AutoSize = true;
            this.lblTenThuCung.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenThuCung.Location = new System.Drawing.Point(301, 128);
            this.lblTenThuCung.Name = "lblTenThuCung";
            this.lblTenThuCung.Size = new System.Drawing.Size(135, 25);
            this.lblTenThuCung.TabIndex = 6;
            this.lblTenThuCung.Text = "Tên Thú Cưng:";
            // 
            // lblChuNhan
            // 
            this.lblChuNhan.AutoSize = true;
            this.lblChuNhan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuNhan.Location = new System.Drawing.Point(301, 173);
            this.lblChuNhan.Name = "lblChuNhan";
            this.lblChuNhan.Size = new System.Drawing.Size(101, 25);
            this.lblChuNhan.TabIndex = 7;
            this.lblChuNhan.Text = "Chủ Nhân:";
            // 
            // lblNgayCS
            // 
            this.lblNgayCS.AutoSize = true;
            this.lblNgayCS.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayCS.Location = new System.Drawing.Point(301, 217);
            this.lblNgayCS.Name = "lblNgayCS";
            this.lblNgayCS.Size = new System.Drawing.Size(150, 25);
            this.lblNgayCS.TabIndex = 8;
            this.lblNgayCS.Text = "Ngày Chăm Sóc:";
            // 
            // lblTổngBill
            // 
            this.lblTổngBill.AutoSize = true;
            this.lblTổngBill.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTổngBill.Location = new System.Drawing.Point(301, 376);
            this.lblTổngBill.Name = "lblTổngBill";
            this.lblTổngBill.Size = new System.Drawing.Size(141, 25);
            this.lblTổngBill.TabIndex = 10;
            this.lblTổngBill.Text = "Tổng Hóa Đơn:";
            // 
            // txtTenTC
            // 
            this.txtTenTC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTC.Location = new System.Drawing.Point(442, 123);
            this.txtTenTC.Name = "txtTenTC";
            this.txtTenTC.Size = new System.Drawing.Size(217, 30);
            this.txtTenTC.TabIndex = 11;
            // 
            // txtTenCN
            // 
            this.txtTenCN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCN.Location = new System.Drawing.Point(409, 168);
            this.txtTenCN.Name = "txtTenCN";
            this.txtTenCN.Size = new System.Drawing.Size(249, 30);
            this.txtTenCN.TabIndex = 12;
            // 
            // txtNgayCS
            // 
            this.txtNgayCS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayCS.Location = new System.Drawing.Point(457, 212);
            this.txtNgayCS.Name = "txtNgayCS";
            this.txtNgayCS.Size = new System.Drawing.Size(201, 30);
            this.txtNgayCS.TabIndex = 13;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.DarkRed;
            this.txtTongTien.Location = new System.Drawing.Point(448, 375);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(211, 30);
            this.txtTongTien.TabIndex = 14;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Orange;
            this.pictureBox4.Location = new System.Drawing.Point(304, 405);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(138, 2);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvHoaDon);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(304, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 121);
            this.panel1.TabIndex = 16;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoGenerateColumns = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDV,
            this.Gia});
            this.dgvHoaDon.DataSource = this.vw_DanhSachSuDungDVBindingSource;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(355, 121);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // TenDV
            // 
            this.TenDV.DataPropertyName = "TenDV";
            this.TenDV.HeaderText = "Tên Dịch Vụ";
            this.TenDV.MinimumWidth = 6;
            this.TenDV.Name = "TenDV";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Gía Tiền";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            // 
            // frmDanhSachHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtNgayCS);
            this.Controls.Add(this.txtTenCN);
            this.Controls.Add(this.txtTenTC);
            this.Controls.Add(this.lblTổngBill);
            this.Controls.Add(this.lblNgayCS);
            this.Controls.Add(this.lblChuNhan);
            this.Controls.Add(this.lblTenThuCung);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMaCS);
            this.Controls.Add(this.lblMaCS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDanhSachHoaDon";
            this.Text = "frmDanhSachHoaDon";
            this.Load += new System.EventHandler(this.frmDanhSachHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_DanhSachSuDungDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTraiThuCungDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaCS;
        private System.Windows.Forms.ComboBox cboMaCS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private QuanLyTraiThuCungDataSet quanLyTraiThuCungDataSet;
        private System.Windows.Forms.BindingSource vw_DanhSachSuDungDVBindingSource;
        private QuanLyTraiThuCungDataSetTableAdapters.vw_DanhSachSuDungDVTableAdapter vw_DanhSachSuDungDVTableAdapter;
        private QuanLyTraiThuCungDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblTenThuCung;
        private System.Windows.Forms.Label lblChuNhan;
        private System.Windows.Forms.Label lblNgayCS;
        private System.Windows.Forms.Label lblTổngBill;
        private System.Windows.Forms.TextBox txtTenTC;
        private System.Windows.Forms.TextBox txtTenCN;
        private System.Windows.Forms.TextBox txtNgayCS;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
    }
}