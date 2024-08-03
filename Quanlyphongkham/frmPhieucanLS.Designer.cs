namespace Quanlyphongkham
{
    partial class frmPhieucanLS
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lsvPCLS = new System.Windows.Forms.ListView();
            this.colMaPCLS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaylap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txttongtien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbbMaBN = new System.Windows.Forms.ComboBox();
            this.dttNgaylap = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaPCLS = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.txttongtien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPCLS.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(224, 27);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(339, 36);
            this.labelControl4.TabIndex = 69;
            this.labelControl4.Text = "PHIẾU CẬN LÂM SÀNG";
            // 
            // lsvPCLS
            // 
            this.lsvPCLS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPCLS,
            this.colMaBN,
            this.colNgaylap,
            this.columnHeader1});
            this.lsvPCLS.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvPCLS.FullRowSelect = true;
            this.lsvPCLS.GridLines = true;
            this.lsvPCLS.HideSelection = false;
            this.lsvPCLS.Location = new System.Drawing.Point(88, 264);
            this.lsvPCLS.Margin = new System.Windows.Forms.Padding(2);
            this.lsvPCLS.MultiSelect = false;
            this.lsvPCLS.Name = "lsvPCLS";
            this.lsvPCLS.Size = new System.Drawing.Size(630, 264);
            this.lsvPCLS.TabIndex = 68;
            this.lsvPCLS.UseCompatibleStateImageBehavior = false;
            this.lsvPCLS.View = System.Windows.Forms.View.Details;
            // 
            // colMaPCLS
            // 
            this.colMaPCLS.Text = "Mã phiếu cận lâm sàng";
            this.colMaPCLS.Width = 400;
            // 
            // colMaBN
            // 
            this.colMaBN.Text = "Mã bênh nhân";
            this.colMaBN.Width = 250;
            // 
            // colNgaylap
            // 
            this.colNgaylap.Text = "Ngày lập";
            this.colNgaylap.Width = 300;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "tổng tièn";
            this.columnHeader1.Width = 100;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txttongtien);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.cbbMaBN);
            this.groupControl1.Controls.Add(this.dttNgaylap);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtMaPCLS);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(88, 79);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(631, 180);
            this.groupControl1.TabIndex = 67;
            this.groupControl1.Text = "Thông tin phiếu ";
            // 
            // txttongtien
            // 
            this.txttongtien.EditValue = "";
            this.txttongtien.Location = new System.Drawing.Point(237, 142);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(2);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongtien.Properties.Appearance.Options.UseFont = true;
            this.txttongtien.Size = new System.Drawing.Size(337, 30);
            this.txttongtien.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(132, 149);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(83, 22);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Tổng tiền:";
            // 
            // cbbMaBN
            // 
            this.cbbMaBN.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaBN.FormattingEnabled = true;
            this.cbbMaBN.Location = new System.Drawing.Point(237, 98);
            this.cbbMaBN.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaBN.Name = "cbbMaBN";
            this.cbbMaBN.Size = new System.Drawing.Size(298, 28);
            this.cbbMaBN.TabIndex = 3;
            // 
            // dttNgaylap
            // 
            this.dttNgaylap.CustomFormat = "dd/MM/yyyy";
            this.dttNgaylap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttNgaylap.Location = new System.Drawing.Point(237, 65);
            this.dttNgaylap.Margin = new System.Windows.Forms.Padding(2);
            this.dttNgaylap.Name = "dttNgaylap";
            this.dttNgaylap.Size = new System.Drawing.Size(230, 28);
            this.dttNgaylap.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(89, 97);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(126, 22);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Tên bệnh nhân:";
            // 
            // txtMaPCLS
            // 
            this.txtMaPCLS.EditValue = "";
            this.txtMaPCLS.Location = new System.Drawing.Point(237, 30);
            this.txtMaPCLS.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPCLS.Name = "txtMaPCLS";
            this.txtMaPCLS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPCLS.Properties.Appearance.Options.UseFont = true;
            this.txtMaPCLS.Size = new System.Drawing.Size(337, 30);
            this.txtMaPCLS.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(136, 71);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 22);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ngày lập:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 39);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(194, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã phiếu cận lâm sàng:";
            // 
            // bttThoat
            // 
            this.bttThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttThoat.Location = new System.Drawing.Point(612, 571);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(96, 40);
            this.bttThoat.TabIndex = 117;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = false;
            // 
            // bttHuy
            // 
            this.bttHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttHuy.Location = new System.Drawing.Point(510, 571);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(96, 40);
            this.bttHuy.TabIndex = 116;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = false;
            // 
            // bttLuu
            // 
            this.bttLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttLuu.Location = new System.Drawing.Point(408, 571);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(96, 40);
            this.bttLuu.TabIndex = 115;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = false;
            // 
            // bttXoa
            // 
            this.bttXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttXoa.Location = new System.Drawing.Point(306, 571);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(96, 40);
            this.bttXoa.TabIndex = 114;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = false;
            // 
            // bttSua
            // 
            this.bttSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttSua.Location = new System.Drawing.Point(201, 571);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(96, 40);
            this.bttSua.TabIndex = 113;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = false;
            // 
            // bttThem
            // 
            this.bttThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttThem.Location = new System.Drawing.Point(99, 571);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(96, 40);
            this.bttThem.TabIndex = 112;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = false;
            // 
            // frmPhieucanLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 726);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lsvPCLS);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmPhieucanLS";
            this.Text = "frmPhieucanLS";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttongtien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPCLS.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ListView lsvPCLS;
        private System.Windows.Forms.ColumnHeader colMaPCLS;
        private System.Windows.Forms.ColumnHeader colMaBN;
        private System.Windows.Forms.ColumnHeader colNgaylap;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txttongtien;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cbbMaBN;
        private System.Windows.Forms.DateTimePicker dttNgaylap;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMaPCLS;
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