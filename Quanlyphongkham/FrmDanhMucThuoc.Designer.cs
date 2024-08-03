namespace Quanlyphongkham
{
    partial class FrmDanhMucThuoc
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
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lsvThuoc = new System.Windows.Forms.ListView();
            this.colMaSo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenThuoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonViTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbbTenL = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.txtDVT = new DevExpress.XtraEditors.TextEdit();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSo = new DevExpress.XtraEditors.TextEdit();
            this.txtTenThuoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bttThoat = new System.Windows.Forms.Button();
            this.bttHuy = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.bttThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThuoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(326, 38);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(283, 36);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "DANH MỤC THUỐC";
            // 
            // lsvThuoc
            // 
            this.lsvThuoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSo,
            this.colTenThuoc,
            this.colSoLuong,
            this.colDonGia,
            this.colDonViTinh,
            this.colTenLoai});
            this.lsvThuoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvThuoc.FullRowSelect = true;
            this.lsvThuoc.GridLines = true;
            this.lsvThuoc.HideSelection = false;
            this.lsvThuoc.Location = new System.Drawing.Point(74, 254);
            this.lsvThuoc.Name = "lsvThuoc";
            this.lsvThuoc.Size = new System.Drawing.Size(800, 278);
            this.lsvThuoc.TabIndex = 14;
            this.lsvThuoc.UseCompatibleStateImageBehavior = false;
            this.lsvThuoc.View = System.Windows.Forms.View.Details;
            // 
            // colMaSo
            // 
            this.colMaSo.Text = "Mã thuốc";
            this.colMaSo.Width = 120;
            // 
            // colTenThuoc
            // 
            this.colTenThuoc.Text = "Tên thuốc";
            this.colTenThuoc.Width = 200;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 100;
            // 
            // colDonGia
            // 
            this.colDonGia.Text = "Đơn giá";
            this.colDonGia.Width = 100;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.Text = "Đơn vị tính";
            this.colDonViTinh.Width = 100;
            // 
            // colTenLoai
            // 
            this.colTenLoai.Text = "Tên loại thuốc";
            this.colTenLoai.Width = 180;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbbTenL);
            this.groupControl1.Controls.Add(this.txtDonGia);
            this.groupControl1.Controls.Add(this.txtDVT);
            this.groupControl1.Controls.Add(this.txtSoLuong);
            this.groupControl1.Controls.Add(this.txtMaSo);
            this.groupControl1.Controls.Add(this.txtTenThuoc);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(74, 85);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(800, 163);
            this.groupControl1.TabIndex = 13;
            // 
            // cbbTenL
            // 
            this.cbbTenL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenL.FormattingEnabled = true;
            this.cbbTenL.Location = new System.Drawing.Point(495, 119);
            this.cbbTenL.Name = "cbbTenL";
            this.cbbTenL.Size = new System.Drawing.Size(289, 32);
            this.cbbTenL.TabIndex = 5;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(495, 38);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Properties.Appearance.Options.UseFont = true;
            this.txtDonGia.Size = new System.Drawing.Size(289, 30);
            this.txtDonGia.TabIndex = 3;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(495, 81);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVT.Properties.Appearance.Options.UseFont = true;
            this.txtDVT.Size = new System.Drawing.Size(289, 30);
            this.txtDVT.TabIndex = 4;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(104, 119);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuong.Size = new System.Drawing.Size(277, 30);
            this.txtSoLuong.TabIndex = 2;
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(104, 38);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSo.Properties.Appearance.Options.UseFont = true;
            this.txtMaSo.Size = new System.Drawing.Size(277, 30);
            this.txtMaSo.TabIndex = 0;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(104, 81);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenThuoc.Properties.Appearance.Options.UseFont = true;
            this.txtTenThuoc.Size = new System.Drawing.Size(277, 30);
            this.txtTenThuoc.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(413, 122);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(77, 24);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Tên Loại";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(413, 84);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(97, 24);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Đơn vị tính";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(413, 41);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 24);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Đơn giá";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 122);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 24);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Số lượng";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 84);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 24);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên thuốc";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã số";
            // 
            // bttThoat
            // 
            this.bttThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttThoat.Location = new System.Drawing.Point(691, 574);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(96, 40);
            this.bttThoat.TabIndex = 99;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = false;
            // 
            // bttHuy
            // 
            this.bttHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttHuy.Location = new System.Drawing.Point(589, 574);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(96, 40);
            this.bttHuy.TabIndex = 98;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = false;
            // 
            // bttLuu
            // 
            this.bttLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttLuu.Location = new System.Drawing.Point(487, 574);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(96, 40);
            this.bttLuu.TabIndex = 97;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = false;
            // 
            // bttXoa
            // 
            this.bttXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttXoa.Location = new System.Drawing.Point(385, 574);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(96, 40);
            this.bttXoa.TabIndex = 96;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = false;
            // 
            // bttSua
            // 
            this.bttSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttSua.Location = new System.Drawing.Point(280, 574);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(96, 40);
            this.bttSua.TabIndex = 95;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = false;
            // 
            // bttThem
            // 
            this.bttThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttThem.Location = new System.Drawing.Point(178, 574);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(96, 40);
            this.bttThem.TabIndex = 94;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = false;
            // 
            // FrmDanhMucThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 682);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.lsvThuoc);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmDanhMucThuoc";
            this.Text = "FrmDanhMucThuoc";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThuoc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ListView lsvThuoc;
        private System.Windows.Forms.ColumnHeader colMaSo;
        private System.Windows.Forms.ColumnHeader colTenThuoc;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colDonGia;
        private System.Windows.Forms.ColumnHeader colDonViTinh;
        private System.Windows.Forms.ColumnHeader colTenLoai;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cbbTenL;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.TextEdit txtDVT;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.TextEdit txtMaSo;
        private DevExpress.XtraEditors.TextEdit txtTenThuoc;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button bttThem;
    }
}