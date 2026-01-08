namespace Chude47.QuanLyTraiThuCung
{
    partial class frmDanhSachDungDV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbChamSoc = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.vw_DanhSachSuDungDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyTraiThuCungDataSet = new Chude47.QuanLyTraiThuCung.QuanLyTraiThuCungDataSet();
            this.gbChanSoc = new System.Windows.Forms.GroupBox();
            this.clbDichVu = new System.Windows.Forms.CheckedListBox();
            this.btnXoaCS = new System.Windows.Forms.Button();
            this.btnSuaCS = new System.Windows.Forms.Button();
            this.cboMaCS = new System.Windows.Forms.ComboBox();
            this.btnThemCS = new System.Windows.Forms.Button();
            this.lblMaCS = new System.Windows.Forms.Label();
            this.suDungDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suDungDVTableAdapter = new Chude47.QuanLyTraiThuCung.QuanLyTraiThuCungDataSetTableAdapters.SuDungDVTableAdapter();
            this.tableAdapterManager = new Chude47.QuanLyTraiThuCung.QuanLyTraiThuCungDataSetTableAdapters.TableAdapterManager();
            this.dichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dichVuTableAdapter = new Chude47.QuanLyTraiThuCung.QuanLyTraiThuCungDataSetTableAdapters.DichVuTableAdapter();
            this.vw_DanhSachSuDungDVTableAdapter = new Chude47.QuanLyTraiThuCung.QuanLyTraiThuCungDataSetTableAdapters.vw_DanhSachSuDungDVTableAdapter();
            this.chamSocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chamSocTableAdapter = new Chude47.QuanLyTraiThuCung.QuanLyTraiThuCungDataSetTableAdapters.ChamSocTableAdapter();
            this.MaCS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbChamSoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_DanhSachSuDungDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTraiThuCungDataSet)).BeginInit();
            this.gbChanSoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suDungDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamSocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbChamSoc
            // 
            this.gbChamSoc.Controls.Add(this.dgvDanhSach);
            this.gbChamSoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChamSoc.Location = new System.Drawing.Point(4, 173);
            this.gbChamSoc.Name = "gbChamSoc";
            this.gbChamSoc.Size = new System.Drawing.Size(996, 300);
            this.gbChamSoc.TabIndex = 10;
            this.gbChamSoc.TabStop = false;
            this.gbChamSoc.Text = "Danh Sách Sử Dụng Dịch Vụ";
            // 
            // dgvDanhSach
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvDanhSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSach.AutoGenerateColumns = false;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCS,
            this.TenTC,
            this.Loai,
            this.TenCN,
            this.SDT,
            this.NgayCS,
            this.MaDV,
            this.TenDV,
            this.Gia});
            this.dgvDanhSach.DataSource = this.vw_DanhSachSuDungDVBindingSource;
            this.dgvDanhSach.Location = new System.Drawing.Point(6, 26);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(983, 268);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            this.dgvDanhSach.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDanhSach_DataBindingComplete);
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
            // gbChanSoc
            // 
            this.gbChanSoc.Controls.Add(this.clbDichVu);
            this.gbChanSoc.Controls.Add(this.btnXoaCS);
            this.gbChanSoc.Controls.Add(this.btnSuaCS);
            this.gbChanSoc.Controls.Add(this.cboMaCS);
            this.gbChanSoc.Controls.Add(this.btnThemCS);
            this.gbChanSoc.Controls.Add(this.lblMaCS);
            this.gbChanSoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChanSoc.Location = new System.Drawing.Point(4, -2);
            this.gbChanSoc.Name = "gbChanSoc";
            this.gbChanSoc.Size = new System.Drawing.Size(1009, 318);
            this.gbChanSoc.TabIndex = 9;
            this.gbChanSoc.TabStop = false;
            this.gbChanSoc.Text = "Thông Tin Dịch Vụ Chăm Sóc";
            this.gbChanSoc.Enter += new System.EventHandler(this.gbChanSoc_Enter);
            // 
            // clbDichVu
            // 
            this.clbDichVu.FormattingEnabled = true;
            this.clbDichVu.Location = new System.Drawing.Point(503, 26);
            this.clbDichVu.Name = "clbDichVu";
            this.clbDichVu.Size = new System.Drawing.Size(486, 136);
            this.clbDichVu.TabIndex = 8;
            // 
            // btnXoaCS
            // 
            this.btnXoaCS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCS.Location = new System.Drawing.Point(318, 91);
            this.btnXoaCS.Name = "btnXoaCS";
            this.btnXoaCS.Size = new System.Drawing.Size(90, 51);
            this.btnXoaCS.TabIndex = 7;
            this.btnXoaCS.Text = "Xóa";
            this.btnXoaCS.UseVisualStyleBackColor = true;
            this.btnXoaCS.Click += new System.EventHandler(this.btnXoaCS_Click);
            // 
            // btnSuaCS
            // 
            this.btnSuaCS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCS.Location = new System.Drawing.Point(192, 91);
            this.btnSuaCS.Name = "btnSuaCS";
            this.btnSuaCS.Size = new System.Drawing.Size(90, 51);
            this.btnSuaCS.TabIndex = 6;
            this.btnSuaCS.Text = "Sửa";
            this.btnSuaCS.UseVisualStyleBackColor = true;
            this.btnSuaCS.Click += new System.EventHandler(this.btnSuaCS_Click);
            // 
            // cboMaCS
            // 
            this.cboMaCS.FormattingEnabled = true;
            this.cboMaCS.Location = new System.Drawing.Point(181, 26);
            this.cboMaCS.Name = "cboMaCS";
            this.cboMaCS.Size = new System.Drawing.Size(227, 28);
            this.cboMaCS.TabIndex = 5;
            // 
            // btnThemCS
            // 
            this.btnThemCS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCS.Location = new System.Drawing.Point(66, 91);
            this.btnThemCS.Name = "btnThemCS";
            this.btnThemCS.Size = new System.Drawing.Size(90, 51);
            this.btnThemCS.TabIndex = 5;
            this.btnThemCS.Text = "Thêm";
            this.btnThemCS.UseVisualStyleBackColor = true;
            this.btnThemCS.Click += new System.EventHandler(this.btnThemCS_Click);
            // 
            // lblMaCS
            // 
            this.lblMaCS.AutoSize = true;
            this.lblMaCS.Location = new System.Drawing.Point(68, 36);
            this.lblMaCS.Name = "lblMaCS";
            this.lblMaCS.Size = new System.Drawing.Size(107, 20);
            this.lblMaCS.TabIndex = 1;
            this.lblMaCS.Text = "Mã Chăm Sóc:";
            // 
            // suDungDVBindingSource
            // 
            this.suDungDVBindingSource.DataMember = "SuDungDV";
            this.suDungDVBindingSource.DataSource = this.quanLyTraiThuCungDataSet;
            // 
            // suDungDVTableAdapter
            // 
            this.suDungDVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChamSocTableAdapter = null;
            this.tableAdapterManager.ChuNhanTableAdapter = null;
            this.tableAdapterManager.DichVuTableAdapter = null;
            this.tableAdapterManager.SuDungDVTableAdapter = this.suDungDVTableAdapter;
            this.tableAdapterManager.ThuCungTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Chude47.QuanLyTraiThuCung.QuanLyTraiThuCungDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dichVuBindingSource
            // 
            this.dichVuBindingSource.DataMember = "DichVu";
            this.dichVuBindingSource.DataSource = this.quanLyTraiThuCungDataSet;
            // 
            // dichVuTableAdapter
            // 
            this.dichVuTableAdapter.ClearBeforeFill = true;
            // 
            // vw_DanhSachSuDungDVTableAdapter
            // 
            this.vw_DanhSachSuDungDVTableAdapter.ClearBeforeFill = true;
            // 
            // chamSocBindingSource
            // 
            this.chamSocBindingSource.DataMember = "ChamSoc";
            this.chamSocBindingSource.DataSource = this.quanLyTraiThuCungDataSet;
            // 
            // chamSocTableAdapter
            // 
            this.chamSocTableAdapter.ClearBeforeFill = true;
            // 
            // MaCS
            // 
            this.MaCS.DataPropertyName = "MaCS";
            this.MaCS.HeaderText = "Mã Chăm Sóc";
            this.MaCS.MinimumWidth = 6;
            this.MaCS.Name = "MaCS";
            // 
            // TenTC
            // 
            this.TenTC.DataPropertyName = "TenTC";
            this.TenTC.HeaderText = "Tên Thú Cưng";
            this.TenTC.MinimumWidth = 6;
            this.TenTC.Name = "TenTC";
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "Loai";
            this.Loai.HeaderText = "Loại";
            this.Loai.MinimumWidth = 6;
            this.Loai.Name = "Loai";
            // 
            // TenCN
            // 
            this.TenCN.DataPropertyName = "TenCN";
            this.TenCN.HeaderText = "Tên Chủ Nhân";
            this.TenCN.MinimumWidth = 6;
            this.TenCN.Name = "TenCN";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // NgayCS
            // 
            this.NgayCS.DataPropertyName = "NgayCS";
            this.NgayCS.HeaderText = "Ngày Chăm Sóc";
            this.NgayCS.MinimumWidth = 6;
            this.NgayCS.Name = "NgayCS";
            // 
            // MaDV
            // 
            this.MaDV.DataPropertyName = "MaDV";
            this.MaDV.HeaderText = "Mã Dịch Vụ";
            this.MaDV.MinimumWidth = 6;
            this.MaDV.Name = "MaDV";
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
            this.Gia.HeaderText = "Giá Tiền";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            // 
            // frmDanhSachDungDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 473);
            this.Controls.Add(this.gbChamSoc);
            this.Controls.Add(this.gbChanSoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDanhSachDungDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDanhSachDungDV";
            this.Load += new System.EventHandler(this.frmDanhSachDungDV_Load);
            this.gbChamSoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_DanhSachSuDungDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTraiThuCungDataSet)).EndInit();
            this.gbChanSoc.ResumeLayout(false);
            this.gbChanSoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suDungDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamSocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbChamSoc;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox gbChanSoc;
        private System.Windows.Forms.CheckedListBox clbDichVu;
        private System.Windows.Forms.Button btnXoaCS;
        private System.Windows.Forms.Button btnSuaCS;
        private System.Windows.Forms.ComboBox cboMaCS;
        private System.Windows.Forms.Button btnThemCS;
        private System.Windows.Forms.Label lblMaCS;
        private QuanLyTraiThuCungDataSet quanLyTraiThuCungDataSet;
        private System.Windows.Forms.BindingSource suDungDVBindingSource;
        private QuanLyTraiThuCungDataSetTableAdapters.SuDungDVTableAdapter suDungDVTableAdapter;
        private QuanLyTraiThuCungDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource dichVuBindingSource;
        private QuanLyTraiThuCungDataSetTableAdapters.DichVuTableAdapter dichVuTableAdapter;
        private System.Windows.Forms.BindingSource vw_DanhSachSuDungDVBindingSource;
        private QuanLyTraiThuCungDataSetTableAdapters.vw_DanhSachSuDungDVTableAdapter vw_DanhSachSuDungDVTableAdapter;
        private System.Windows.Forms.BindingSource chamSocBindingSource;
        private QuanLyTraiThuCungDataSetTableAdapters.ChamSocTableAdapter chamSocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
    }
}