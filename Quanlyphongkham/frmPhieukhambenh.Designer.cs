namespace Quanlyphongkham
{
    partial class frmPhieukhambenh
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
            this.label1 = new System.Windows.Forms.Label();
            this.txttimkiem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lsvPKB = new System.Windows.Forms.ListView();
            this.colMaPKB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenPK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenLK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaylap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coltt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGhichu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.radiobtchuakham = new System.Windows.Forms.RadioButton();
            this.radiobtdakham = new System.Windows.Forms.RadioButton();
            this.cbbMaBN = new System.Windows.Forms.ComboBox();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.cbbMaLK = new System.Windows.Forms.ComboBox();
            this.cbbMaPK = new System.Windows.Forms.ComboBox();
            this.dttNgaylap = new System.Windows.Forms.DateTimePicker();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.txtMaPKB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bttThoat = new System.Windows.Forms.Button();
            this.bttHuy = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.bttThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txttimkiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPKB.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(698, 562);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 74;
            this.label1.Text = "Tìm kiếm mã số:";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(871, 559);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Properties.Appearance.Options.UseFont = true;
            this.txttimkiem.Size = new System.Drawing.Size(105, 28);
            this.txttimkiem.TabIndex = 73;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(412, 54);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(293, 36);
            this.labelControl5.TabIndex = 72;
            this.labelControl5.Text = "PHIẾU KHÁM BỆNH";
            // 
            // lsvPKB
            // 
            this.lsvPKB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPKB,
            this.colTenPK,
            this.colTenNV,
            this.colTenLK,
            this.colTenBN,
            this.colNgaylap,
            this.coltt,
            this.colGhichu});
            this.lsvPKB.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvPKB.FullRowSelect = true;
            this.lsvPKB.GridLines = true;
            this.lsvPKB.HideSelection = false;
            this.lsvPKB.Location = new System.Drawing.Point(75, 275);
            this.lsvPKB.Margin = new System.Windows.Forms.Padding(2);
            this.lsvPKB.Name = "lsvPKB";
            this.lsvPKB.Size = new System.Drawing.Size(914, 280);
            this.lsvPKB.TabIndex = 71;
            this.lsvPKB.UseCompatibleStateImageBehavior = false;
            this.lsvPKB.View = System.Windows.Forms.View.Details;
            // 
            // colMaPKB
            // 
            this.colMaPKB.Text = "Mã phiếu khám";
            this.colMaPKB.Width = 220;
            // 
            // colTenPK
            // 
            this.colTenPK.Text = "Tên phòng khám";
            this.colTenPK.Width = 220;
            // 
            // colTenNV
            // 
            this.colTenNV.Text = "Tên nhân viên ";
            this.colTenNV.Width = 200;
            // 
            // colTenLK
            // 
            this.colTenLK.Text = "Tên loại khám";
            this.colTenLK.Width = 200;
            // 
            // colTenBN
            // 
            this.colTenBN.Text = "Tên bệnh nhân";
            this.colTenBN.Width = 200;
            // 
            // colNgaylap
            // 
            this.colNgaylap.Text = "Ngày lập";
            this.colNgaylap.Width = 200;
            // 
            // coltt
            // 
            this.coltt.Text = "Tình trạng";
            this.coltt.Width = 100;
            // 
            // colGhichu
            // 
            this.colGhichu.Text = "Ghi chú ";
            this.colGhichu.Width = 200;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.radiobtchuakham);
            this.groupControl1.Controls.Add(this.radiobtdakham);
            this.groupControl1.Controls.Add(this.cbbMaBN);
            this.groupControl1.Controls.Add(this.cbbMaNV);
            this.groupControl1.Controls.Add(this.cbbMaLK);
            this.groupControl1.Controls.Add(this.cbbMaPK);
            this.groupControl1.Controls.Add(this.dttNgaylap);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtGhiChu);
            this.groupControl1.Controls.Add(this.txtMaPKB);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(76, 100);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(899, 171);
            this.groupControl1.TabIndex = 70;
            this.groupControl1.Text = "Thông tin bệnh nhân";
            // 
            // radiobtchuakham
            // 
            this.radiobtchuakham.AutoSize = true;
            this.radiobtchuakham.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtchuakham.Location = new System.Drawing.Point(760, 90);
            this.radiobtchuakham.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radiobtchuakham.Name = "radiobtchuakham";
            this.radiobtchuakham.Size = new System.Drawing.Size(121, 26);
            this.radiobtchuakham.TabIndex = 49;
            this.radiobtchuakham.TabStop = true;
            this.radiobtchuakham.Text = "Chưa khám";
            this.radiobtchuakham.UseVisualStyleBackColor = true;
            // 
            // radiobtdakham
            // 
            this.radiobtdakham.AutoSize = true;
            this.radiobtdakham.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtdakham.Location = new System.Drawing.Point(760, 48);
            this.radiobtdakham.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radiobtdakham.Name = "radiobtdakham";
            this.radiobtdakham.Size = new System.Drawing.Size(102, 26);
            this.radiobtdakham.TabIndex = 48;
            this.radiobtdakham.TabStop = true;
            this.radiobtdakham.Text = "Đã khám";
            this.radiobtdakham.UseVisualStyleBackColor = true;
            // 
            // cbbMaBN
            // 
            this.cbbMaBN.FormattingEnabled = true;
            this.cbbMaBN.Location = new System.Drawing.Point(516, 62);
            this.cbbMaBN.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaBN.Name = "cbbMaBN";
            this.cbbMaBN.Size = new System.Drawing.Size(215, 24);
            this.cbbMaBN.TabIndex = 5;
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(161, 94);
            this.cbbMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(215, 24);
            this.cbbMaNV.TabIndex = 3;
            // 
            // cbbMaLK
            // 
            this.cbbMaLK.FormattingEnabled = true;
            this.cbbMaLK.Location = new System.Drawing.Point(516, 34);
            this.cbbMaLK.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaLK.Name = "cbbMaLK";
            this.cbbMaLK.Size = new System.Drawing.Size(215, 24);
            this.cbbMaLK.TabIndex = 4;
            // 
            // cbbMaPK
            // 
            this.cbbMaPK.FormattingEnabled = true;
            this.cbbMaPK.Location = new System.Drawing.Point(160, 64);
            this.cbbMaPK.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaPK.Name = "cbbMaPK";
            this.cbbMaPK.Size = new System.Drawing.Size(216, 24);
            this.cbbMaPK.TabIndex = 2;
            // 
            // dttNgaylap
            // 
            this.dttNgaylap.CalendarFont = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttNgaylap.CustomFormat = "dd/MM/yyyy";
            this.dttNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttNgaylap.Location = new System.Drawing.Point(516, 94);
            this.dttNgaylap.Margin = new System.Windows.Forms.Padding(2);
            this.dttNgaylap.Name = "dttNgaylap";
            this.dttNgaylap.Size = new System.Drawing.Size(215, 23);
            this.dttNgaylap.TabIndex = 6;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(429, 94);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(83, 22);
            this.labelControl9.TabIndex = 47;
            this.labelControl9.Text = "Ngày lập: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(385, 62);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 22);
            this.labelControl1.TabIndex = 46;
            this.labelControl1.Text = "Tên bệnh nhân:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(26, 91);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(115, 20);
            this.labelControl7.TabIndex = 21;
            this.labelControl7.Text = "Tên nhân viên:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(388, 34);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(123, 22);
            this.labelControl8.TabIndex = 41;
            this.labelControl8.Text = "Tên loại khám:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(160, 121);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(570, 22);
            this.txtGhiChu.TabIndex = 7;
            // 
            // txtMaPKB
            // 
            this.txtMaPKB.Location = new System.Drawing.Point(160, 33);
            this.txtMaPKB.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPKB.Name = "txtMaPKB";
            this.txtMaPKB.Size = new System.Drawing.Size(215, 22);
            this.txtMaPKB.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(70, 121);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 20);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Ghi chú:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(14, 36);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(133, 22);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Mã phiếu khám:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(9, 63);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(141, 20);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Tên phòng khám: ";
            // 
            // bttThoat
            // 
            this.bttThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttThoat.Location = new System.Drawing.Point(719, 635);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(96, 40);
            this.bttThoat.TabIndex = 117;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = false;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // bttHuy
            // 
            this.bttHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttHuy.Location = new System.Drawing.Point(617, 635);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(96, 40);
            this.bttHuy.TabIndex = 116;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = false;
            this.bttHuy.Click += new System.EventHandler(this.bttHuy_Click);
            // 
            // bttLuu
            // 
            this.bttLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttLuu.Location = new System.Drawing.Point(515, 635);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(96, 40);
            this.bttLuu.TabIndex = 115;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = false;
            this.bttLuu.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // bttXoa
            // 
            this.bttXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttXoa.Location = new System.Drawing.Point(413, 635);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(96, 40);
            this.bttXoa.TabIndex = 114;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = false;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // bttSua
            // 
            this.bttSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttSua.Location = new System.Drawing.Point(308, 635);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(96, 40);
            this.bttSua.TabIndex = 113;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = false;
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click);
            // 
            // bttThem
            // 
            this.bttThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttThem.Location = new System.Drawing.Point(206, 635);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(96, 40);
            this.bttThem.TabIndex = 112;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = false;
            this.bttThem.Click += new System.EventHandler(this.bttThem_Click_1);
            // 
            // frmPhieukhambenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 731);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lsvPKB);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmPhieukhambenh";
            this.Text = "frmPhieukhambenh";
            this.Load += new System.EventHandler(this.frmPhieukhambenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txttimkiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPKB.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txttimkiem;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ListView lsvPKB;
        private System.Windows.Forms.ColumnHeader colMaPKB;
        private System.Windows.Forms.ColumnHeader colTenPK;
        private System.Windows.Forms.ColumnHeader colTenNV;
        private System.Windows.Forms.ColumnHeader colTenLK;
        private System.Windows.Forms.ColumnHeader colTenBN;
        private System.Windows.Forms.ColumnHeader colNgaylap;
        private System.Windows.Forms.ColumnHeader coltt;
        private System.Windows.Forms.ColumnHeader colGhichu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton radiobtchuakham;
        private System.Windows.Forms.RadioButton radiobtdakham;
        private System.Windows.Forms.ComboBox cbbMaBN;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.ComboBox cbbMaLK;
        private System.Windows.Forms.ComboBox cbbMaPK;
        private System.Windows.Forms.DateTimePicker dttNgaylap;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.TextEdit txtMaPKB;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button bttThem;
    }
}