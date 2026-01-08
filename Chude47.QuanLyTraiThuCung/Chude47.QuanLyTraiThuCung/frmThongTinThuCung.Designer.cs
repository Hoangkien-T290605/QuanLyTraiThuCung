namespace Chude47.QuanLyTraiThuCung
{
    partial class frmThongTinThuCung
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
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenCN = new System.Windows.Forms.TextBox();
            this.txtMaCN = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoaCN = new System.Windows.Forms.Button();
            this.btnSuaCN = new System.Windows.Forms.Button();
            this.btnThemCN = new System.Windows.Forms.Button();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTenCN = new System.Windows.Forms.Label();
            this.lblMaCN = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.thuCungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyTraiThuCungDataSet = new Chude47.QuanLyTraiThuCung.QuanLyTraiThuCungDataSet();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.txtTenTC = new System.Windows.Forms.TextBox();
            this.txtMaTC = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblTenTC = new System.Windows.Forms.Label();
            this.lblMaTC = new System.Windows.Forms.Label();
            this.dgvThuCung = new System.Windows.Forms.DataGridView();
            this.MaTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvChuNhan = new System.Windows.Forms.DataGridView();
            this.MaCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabChuNhan = new System.Windows.Forms.TabPage();
            this.btnThem = new System.Windows.Forms.Button();
            this.tabThongTin = new System.Windows.Forms.TabControl();
            this.tabThuCung = new System.Windows.Forms.TabPage();
            this.thuCungTableAdapter = new Chude47.QuanLyTraiThuCung.QuanLyTraiThuCungDataSetTableAdapters.ThuCungTableAdapter();
            this.tableAdapterManager = new Chude47.QuanLyTraiThuCung.QuanLyTraiThuCungDataSetTableAdapters.TableAdapterManager();
            this.chuNhanTableAdapter = new Chude47.QuanLyTraiThuCung.QuanLyTraiThuCungDataSetTableAdapters.ChuNhanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.thuCungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTraiThuCungDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuNhanBindingSource)).BeginInit();
            this.tabChuNhan.SuspendLayout();
            this.tabThongTin.SuspendLayout();
            this.tabThuCung.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(183, 101);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(199, 27);
            this.txtSDT.TabIndex = 8;
            // 
            // txtTenCN
            // 
            this.txtTenCN.Location = new System.Drawing.Point(183, 59);
            this.txtTenCN.Name = "txtTenCN";
            this.txtTenCN.Size = new System.Drawing.Size(199, 27);
            this.txtTenCN.TabIndex = 7;
            // 
            // txtMaCN
            // 
            this.txtMaCN.Location = new System.Drawing.Point(183, 19);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Size = new System.Drawing.Size(199, 27);
            this.txtMaCN.TabIndex = 6;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(214, 174);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXoaCN
            // 
            this.btnXoaCN.Location = new System.Drawing.Point(291, 148);
            this.btnXoaCN.Name = "btnXoaCN";
            this.btnXoaCN.Size = new System.Drawing.Size(91, 31);
            this.btnXoaCN.TabIndex = 5;
            this.btnXoaCN.Text = "Xóa";
            this.btnXoaCN.UseVisualStyleBackColor = true;
            this.btnXoaCN.Click += new System.EventHandler(this.btnXoaCN_Click);
            // 
            // btnSuaCN
            // 
            this.btnSuaCN.Location = new System.Drawing.Point(169, 148);
            this.btnSuaCN.Name = "btnSuaCN";
            this.btnSuaCN.Size = new System.Drawing.Size(93, 31);
            this.btnSuaCN.TabIndex = 4;
            this.btnSuaCN.Text = "Sửa";
            this.btnSuaCN.UseVisualStyleBackColor = true;
            this.btnSuaCN.Click += new System.EventHandler(this.btnSuaCN_Click);
            // 
            // btnThemCN
            // 
            this.btnThemCN.Location = new System.Drawing.Point(55, 148);
            this.btnThemCN.Name = "btnThemCN";
            this.btnThemCN.Size = new System.Drawing.Size(85, 31);
            this.btnThemCN.TabIndex = 3;
            this.btnThemCN.Text = "Thêm";
            this.btnThemCN.UseVisualStyleBackColor = true;
            this.btnThemCN.Click += new System.EventHandler(this.btnThemCN_Click);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(51, 108);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(109, 20);
            this.lblSDT.TabIndex = 2;
            this.lblSDT.Text = "Số Điện Thoại:";
            // 
            // lblTenCN
            // 
            this.lblTenCN.AutoSize = true;
            this.lblTenCN.Location = new System.Drawing.Point(51, 66);
            this.lblTenCN.Name = "lblTenCN";
            this.lblTenCN.Size = new System.Drawing.Size(126, 20);
            this.lblTenCN.TabIndex = 1;
            this.lblTenCN.Text = "Tên Khách Hàng:";
            // 
            // lblMaCN
            // 
            this.lblMaCN.AutoSize = true;
            this.lblMaCN.Location = new System.Drawing.Point(51, 26);
            this.lblMaCN.Name = "lblMaCN";
            this.lblMaCN.Size = new System.Drawing.Size(123, 20);
            this.lblMaCN.TabIndex = 0;
            this.lblMaCN.Text = "Mã Khách Hàng:";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.thuCungBindingSource, "NgaySinh", true));
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(109, 138);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(180, 27);
            this.dtNgaySinh.TabIndex = 12;
            // 
            // thuCungBindingSource
            // 
            this.thuCungBindingSource.DataMember = "ThuCung";
            this.thuCungBindingSource.DataSource = this.quanLyTraiThuCungDataSet;
            // 
            // quanLyTraiThuCungDataSet
            // 
            this.quanLyTraiThuCungDataSet.DataSetName = "QuanLyTraiThuCungDataSet";
            this.quanLyTraiThuCungDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtLoai
            // 
            this.txtLoai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thuCungBindingSource, "Loai", true));
            this.txtLoai.Location = new System.Drawing.Point(129, 94);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(160, 27);
            this.txtLoai.TabIndex = 11;
            // 
            // txtTenTC
            // 
            this.txtTenTC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thuCungBindingSource, "TenTC", true));
            this.txtTenTC.Location = new System.Drawing.Point(129, 55);
            this.txtTenTC.Name = "txtTenTC";
            this.txtTenTC.Size = new System.Drawing.Size(160, 27);
            this.txtTenTC.TabIndex = 10;
            // 
            // txtMaTC
            // 
            this.txtMaTC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thuCungBindingSource, "MaTC", true));
            this.txtMaTC.Location = new System.Drawing.Point(129, 15);
            this.txtMaTC.Name = "txtMaTC";
            this.txtMaTC.Size = new System.Drawing.Size(160, 27);
            this.txtMaTC.TabIndex = 9;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(9, 138);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(84, 20);
            this.lblNgaySinh.TabIndex = 8;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(9, 101);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(114, 20);
            this.lblLoai.TabIndex = 7;
            this.lblLoai.Text = "Loại Thú Cưng:";
            // 
            // lblTenTC
            // 
            this.lblTenTC.AutoSize = true;
            this.lblTenTC.Location = new System.Drawing.Point(9, 62);
            this.lblTenTC.Name = "lblTenTC";
            this.lblTenTC.Size = new System.Drawing.Size(110, 20);
            this.lblTenTC.TabIndex = 6;
            this.lblTenTC.Text = "Tên Thú Cưng:";
            // 
            // lblMaTC
            // 
            this.lblMaTC.AutoSize = true;
            this.lblMaTC.Location = new System.Drawing.Point(9, 23);
            this.lblMaTC.Name = "lblMaTC";
            this.lblMaTC.Size = new System.Drawing.Size(107, 20);
            this.lblMaTC.TabIndex = 5;
            this.lblMaTC.Text = "Mã Thú Cưng:";
            // 
            // dgvThuCung
            // 
            this.dgvThuCung.AutoGenerateColumns = false;
            this.dgvThuCung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuCung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTC,
            this.TenTC,
            this.Loai,
            this.NgaySinh});
            this.dgvThuCung.DataSource = this.thuCungBindingSource;
            this.dgvThuCung.Location = new System.Drawing.Point(307, 15);
            this.dgvThuCung.Name = "dgvThuCung";
            this.dgvThuCung.RowHeadersWidth = 51;
            this.dgvThuCung.RowTemplate.Height = 24;
            this.dgvThuCung.Size = new System.Drawing.Size(684, 422);
            this.dgvThuCung.TabIndex = 3;
            // 
            // MaTC
            // 
            this.MaTC.DataPropertyName = "MaTC";
            this.MaTC.HeaderText = "Mã Thú Cưng";
            this.MaTC.MinimumWidth = 6;
            this.MaTC.Name = "MaTC";
            this.MaTC.Width = 125;
            // 
            // TenTC
            // 
            this.TenTC.DataPropertyName = "TenTC";
            this.TenTC.HeaderText = "Tên Thú Cưng";
            this.TenTC.MinimumWidth = 6;
            this.TenTC.Name = "TenTC";
            this.TenTC.Width = 125;
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "Loai";
            this.Loai.HeaderText = "Loại";
            this.Loai.MinimumWidth = 6;
            this.Loai.Name = "Loai";
            this.Loai.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 125;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(109, 174);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvChuNhan
            // 
            this.dgvChuNhan.AutoGenerateColumns = false;
            this.dgvChuNhan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvChuNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCN,
            this.TenCN,
            this.SDT});
            this.dgvChuNhan.DataSource = this.chuNhanBindingSource;
            this.dgvChuNhan.GridColor = System.Drawing.Color.Silver;
            this.dgvChuNhan.Location = new System.Drawing.Point(403, 18);
            this.dgvChuNhan.Name = "dgvChuNhan";
            this.dgvChuNhan.RowHeadersWidth = 51;
            this.dgvChuNhan.RowTemplate.Height = 24;
            this.dgvChuNhan.Size = new System.Drawing.Size(586, 411);
            this.dgvChuNhan.TabIndex = 9;
            // 
            // MaCN
            // 
            this.MaCN.DataPropertyName = "MaCN";
            this.MaCN.HeaderText = "Mã Chủ Nhân";
            this.MaCN.MinimumWidth = 6;
            this.MaCN.Name = "MaCN";
            this.MaCN.Width = 125;
            // 
            // TenCN
            // 
            this.TenCN.DataPropertyName = "TenCN";
            this.TenCN.HeaderText = "Tên Chủ Nhân";
            this.TenCN.MinimumWidth = 6;
            this.TenCN.Name = "TenCN";
            this.TenCN.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // chuNhanBindingSource
            // 
            this.chuNhanBindingSource.DataMember = "ChuNhan";
            this.chuNhanBindingSource.DataSource = this.quanLyTraiThuCungDataSet;
            // 
            // tabChuNhan
            // 
            this.tabChuNhan.AutoScroll = true;
            this.tabChuNhan.Controls.Add(this.dgvChuNhan);
            this.tabChuNhan.Controls.Add(this.txtSDT);
            this.tabChuNhan.Controls.Add(this.txtTenCN);
            this.tabChuNhan.Controls.Add(this.txtMaCN);
            this.tabChuNhan.Controls.Add(this.btnXoaCN);
            this.tabChuNhan.Controls.Add(this.btnSuaCN);
            this.tabChuNhan.Controls.Add(this.btnThemCN);
            this.tabChuNhan.Controls.Add(this.lblSDT);
            this.tabChuNhan.Controls.Add(this.lblTenCN);
            this.tabChuNhan.Controls.Add(this.lblMaCN);
            this.tabChuNhan.Location = new System.Drawing.Point(4, 29);
            this.tabChuNhan.Name = "tabChuNhan";
            this.tabChuNhan.Padding = new System.Windows.Forms.Padding(3);
            this.tabChuNhan.Size = new System.Drawing.Size(997, 437);
            this.tabChuNhan.TabIndex = 1;
            this.tabChuNhan.Text = "Chủ Nhân";
            this.tabChuNhan.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 174);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tabThongTin
            // 
            this.tabThongTin.Controls.Add(this.tabThuCung);
            this.tabThongTin.Controls.Add(this.tabChuNhan);
            this.tabThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabThongTin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabThongTin.Location = new System.Drawing.Point(0, 0);
            this.tabThongTin.Name = "tabThongTin";
            this.tabThongTin.SelectedIndex = 0;
            this.tabThongTin.Size = new System.Drawing.Size(1005, 470);
            this.tabThongTin.TabIndex = 1;
            // 
            // tabThuCung
            // 
            this.tabThuCung.AutoScroll = true;
            this.tabThuCung.BackColor = System.Drawing.Color.White;
            this.tabThuCung.Controls.Add(this.dtNgaySinh);
            this.tabThuCung.Controls.Add(this.txtLoai);
            this.tabThuCung.Controls.Add(this.txtTenTC);
            this.tabThuCung.Controls.Add(this.txtMaTC);
            this.tabThuCung.Controls.Add(this.lblNgaySinh);
            this.tabThuCung.Controls.Add(this.lblLoai);
            this.tabThuCung.Controls.Add(this.lblTenTC);
            this.tabThuCung.Controls.Add(this.lblMaTC);
            this.tabThuCung.Controls.Add(this.dgvThuCung);
            this.tabThuCung.Controls.Add(this.btnXoa);
            this.tabThuCung.Controls.Add(this.btnSua);
            this.tabThuCung.Controls.Add(this.btnThem);
            this.tabThuCung.Location = new System.Drawing.Point(4, 29);
            this.tabThuCung.Name = "tabThuCung";
            this.tabThuCung.Padding = new System.Windows.Forms.Padding(3);
            this.tabThuCung.Size = new System.Drawing.Size(997, 437);
            this.tabThuCung.TabIndex = 0;
            this.tabThuCung.Text = "Thú Cưng";
            // 
            // thuCungTableAdapter
            // 
            this.thuCungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChamSocTableAdapter = null;
            this.tableAdapterManager.ChuNhanTableAdapter = this.chuNhanTableAdapter;
            this.tableAdapterManager.DichVuTableAdapter = null;
            this.tableAdapterManager.SuDungDVTableAdapter = null;
            this.tableAdapterManager.ThuCungTableAdapter = this.thuCungTableAdapter;
            this.tableAdapterManager.UpdateOrder = Chude47.QuanLyTraiThuCung.QuanLyTraiThuCungDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // chuNhanTableAdapter
            // 
            this.chuNhanTableAdapter.ClearBeforeFill = true;
            // 
            // frmThongTinThuCung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 470);
            this.Controls.Add(this.tabThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongTinThuCung";
            this.Text = "frmThongTinThuCung";
            this.Load += new System.EventHandler(this.frmThongTinThuCung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thuCungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTraiThuCungDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuNhanBindingSource)).EndInit();
            this.tabChuNhan.ResumeLayout(false);
            this.tabChuNhan.PerformLayout();
            this.tabThongTin.ResumeLayout(false);
            this.tabThuCung.ResumeLayout(false);
            this.tabThuCung.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenCN;
        private System.Windows.Forms.TextBox txtMaCN;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoaCN;
        private System.Windows.Forms.Button btnSuaCN;
        private System.Windows.Forms.Button btnThemCN;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenCN;
        private System.Windows.Forms.Label lblMaCN;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.TextBox txtTenTC;
        private System.Windows.Forms.TextBox txtMaTC;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblTenTC;
        private System.Windows.Forms.Label lblMaTC;
        private System.Windows.Forms.DataGridView dgvThuCung;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvChuNhan;
        private System.Windows.Forms.TabPage tabChuNhan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TabControl tabThongTin;
        private System.Windows.Forms.TabPage tabThuCung;
        private QuanLyTraiThuCungDataSet quanLyTraiThuCungDataSet;
        private System.Windows.Forms.BindingSource thuCungBindingSource;
        private QuanLyTraiThuCungDataSetTableAdapters.ThuCungTableAdapter thuCungTableAdapter;
        private QuanLyTraiThuCungDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QuanLyTraiThuCungDataSetTableAdapters.ChuNhanTableAdapter chuNhanTableAdapter;
        private System.Windows.Forms.BindingSource chuNhanBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
    }
}