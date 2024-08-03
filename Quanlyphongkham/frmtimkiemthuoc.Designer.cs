namespace Quanlyphongkham
{
    partial class frmtimkiemthuoc
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
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bttThoat = new System.Windows.Forms.Button();
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
            this.txtMaSo = new DevExpress.XtraEditors.TextEdit();
            this.txtTenThuoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThuoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(901, 643);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 22);
            this.labelControl4.TabIndex = 84;
            this.labelControl4.Text = "Kết quả:";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(974, 638);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.ReadOnly = true;
            this.txtsoluong.Size = new System.Drawing.Size(74, 22);
            this.txtsoluong.TabIndex = 83;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(327, 666);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 54);
            this.button1.TabIndex = 82;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bttThoat
            // 
            this.bttThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttThoat.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Location = new System.Drawing.Point(974, 666);
            this.bttThoat.Margin = new System.Windows.Forms.Padding(2);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(88, 54);
            this.bttThoat.TabIndex = 81;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(426, 22);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(265, 36);
            this.labelControl7.TabIndex = 80;
            this.labelControl7.Text = "TÌM KIẾM THUỐC";
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
            this.lsvThuoc.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvThuoc.FullRowSelect = true;
            this.lsvThuoc.GridLines = true;
            this.lsvThuoc.HideSelection = false;
            this.lsvThuoc.Location = new System.Drawing.Point(34, 324);
            this.lsvThuoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lsvThuoc.Name = "lsvThuoc";
            this.lsvThuoc.Size = new System.Drawing.Size(1095, 308);
            this.lsvThuoc.TabIndex = 79;
            this.lsvThuoc.UseCompatibleStateImageBehavior = false;
            this.lsvThuoc.View = System.Windows.Forms.View.Details;
            // 
            // colMaSo
            // 
            this.colMaSo.Text = "Mã thuốc";
            this.colMaSo.Width = 150;
            // 
            // colTenThuoc
            // 
            this.colTenThuoc.Text = "Tên thuốc";
            this.colTenThuoc.Width = 200;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 150;
            // 
            // colDonGia
            // 
            this.colDonGia.Text = "Đơn giá";
            this.colDonGia.Width = 150;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.Text = "Đơn vị tính";
            this.colDonViTinh.Width = 200;
            // 
            // colTenLoai
            // 
            this.colTenLoai.Text = "Tên loại thuốc";
            this.colTenLoai.Width = 230;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbbTenL);
            this.groupControl1.Controls.Add(this.txtMaSo);
            this.groupControl1.Controls.Add(this.txtTenThuoc);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(202, 76);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(712, 226);
            this.groupControl1.TabIndex = 78;
            this.groupControl1.Text = "Thông tin phiếu";
            // 
            // cbbTenL
            // 
            this.cbbTenL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenL.FormattingEnabled = true;
            this.cbbTenL.Location = new System.Drawing.Point(200, 170);
            this.cbbTenL.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbbTenL.Name = "cbbTenL";
            this.cbbTenL.Size = new System.Drawing.Size(289, 32);
            this.cbbTenL.TabIndex = 6;
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(200, 57);
            this.txtMaSo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSo.Properties.Appearance.Options.UseFont = true;
            this.txtMaSo.Size = new System.Drawing.Size(289, 30);
            this.txtMaSo.TabIndex = 1;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(200, 117);
            this.txtTenThuoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenThuoc.Properties.Appearance.Options.UseFont = true;
            this.txtTenThuoc.Size = new System.Drawing.Size(289, 30);
            this.txtTenThuoc.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(74, 177);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(79, 22);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Tên Loại:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(71, 127);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 22);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên thuốc:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(106, 70);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã số:";
            // 
            // frmtimkiemthuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 743);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.lsvThuoc);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmtimkiemthuoc";
            this.Text = "frmtimkiemthuoc";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThuoc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttThoat;
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
        private DevExpress.XtraEditors.TextEdit txtMaSo;
        private DevExpress.XtraEditors.TextEdit txtTenThuoc;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}