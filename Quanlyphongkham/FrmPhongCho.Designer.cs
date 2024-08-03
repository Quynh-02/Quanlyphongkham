namespace Quanlyphongkham
{
    partial class FrmPhongCho
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
            this.lbT = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bttXem = new System.Windows.Forms.Button();
            this.bttThoat = new System.Windows.Forms.Button();
            this.lsvCT = new System.Windows.Forms.ListView();
            this.colMaPhieuKB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTenBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoaiKham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbbTenPK = new System.Windows.Forms.ComboBox();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.radbttTatCa = new System.Windows.Forms.RadioButton();
            this.radbttDaKham = new System.Windows.Forms.RadioButton();
            this.radbttChuaKham = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbT
            // 
            this.lbT.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbT.Appearance.Options.UseFont = true;
            this.lbT.Location = new System.Drawing.Point(555, 559);
            this.lbT.Margin = new System.Windows.Forms.Padding(4);
            this.lbT.Name = "lbT";
            this.lbT.Size = new System.Drawing.Size(118, 24);
            this.lbT.TabIndex = 15;
            this.lbT.Text = "labelControl3";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(405, 559);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(152, 24);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Tổng bệnh nhân:";
            // 
            // bttXem
            // 
            this.bttXem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttXem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXem.Location = new System.Drawing.Point(64, 545);
            this.bttXem.Margin = new System.Windows.Forms.Padding(4);
            this.bttXem.Name = "bttXem";
            this.bttXem.Size = new System.Drawing.Size(102, 50);
            this.bttXem.TabIndex = 12;
            this.bttXem.Text = "Xem";
            this.bttXem.UseVisualStyleBackColor = false;
            // 
            // bttThoat
            // 
            this.bttThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.Location = new System.Drawing.Point(984, 545);
            this.bttThoat.Margin = new System.Windows.Forms.Padding(4);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(102, 50);
            this.bttThoat.TabIndex = 13;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = false;
            // 
            // lsvCT
            // 
            this.lsvCT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPhieuKB,
            this.colHoTenBN,
            this.colLoaiKham,
            this.colTinhTrang});
            this.lsvCT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvCT.FullRowSelect = true;
            this.lsvCT.GridLines = true;
            this.lsvCT.HideSelection = false;
            this.lsvCT.Location = new System.Drawing.Point(64, 172);
            this.lsvCT.Margin = new System.Windows.Forms.Padding(4);
            this.lsvCT.MultiSelect = false;
            this.lsvCT.Name = "lsvCT";
            this.lsvCT.Size = new System.Drawing.Size(1021, 345);
            this.lsvCT.TabIndex = 11;
            this.lsvCT.TabStop = false;
            this.lsvCT.UseCompatibleStateImageBehavior = false;
            this.lsvCT.View = System.Windows.Forms.View.Details;
            // 
            // colMaPhieuKB
            // 
            this.colMaPhieuKB.Text = "Mã phiếu khám bệnh";
            this.colMaPhieuKB.Width = 200;
            // 
            // colHoTenBN
            // 
            this.colHoTenBN.Text = "Họ tên bệnh nhân";
            this.colHoTenBN.Width = 200;
            // 
            // colLoaiKham
            // 
            this.colLoaiKham.Text = "Loại khám";
            this.colLoaiKham.Width = 200;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.Text = "Tình Trạng khám";
            this.colTinhTrang.Width = 150;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(367, 42);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(383, 36);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "PHÒNG CHỜ KHÁM BỆNH";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbbTenPK);
            this.groupControl1.Controls.Add(this.dtNgayLap);
            this.groupControl1.Controls.Add(this.radbttTatCa);
            this.groupControl1.Controls.Add(this.radbttDaKham);
            this.groupControl1.Controls.Add(this.radbttChuaKham);
            this.groupControl1.Location = new System.Drawing.Point(64, 97);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1022, 68);
            this.groupControl1.TabIndex = 10;
            // 
            // cbbTenPK
            // 
            this.cbbTenPK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenPK.FormattingEnabled = true;
            this.cbbTenPK.Location = new System.Drawing.Point(712, 27);
            this.cbbTenPK.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTenPK.Name = "cbbTenPK";
            this.cbbTenPK.Size = new System.Drawing.Size(289, 32);
            this.cbbTenPK.TabIndex = 4;
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.CustomFormat = "dd-MM-yyyy ";
            this.dtNgayLap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLap.Location = new System.Drawing.Point(354, 27);
            this.dtNgayLap.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(353, 32);
            this.dtNgayLap.TabIndex = 3;
            // 
            // radbttTatCa
            // 
            this.radbttTatCa.AutoSize = true;
            this.radbttTatCa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbttTatCa.Location = new System.Drawing.Point(262, 32);
            this.radbttTatCa.Margin = new System.Windows.Forms.Padding(4);
            this.radbttTatCa.Name = "radbttTatCa";
            this.radbttTatCa.Size = new System.Drawing.Size(87, 28);
            this.radbttTatCa.TabIndex = 2;
            this.radbttTatCa.TabStop = true;
            this.radbttTatCa.Text = "Tất cả";
            this.radbttTatCa.UseVisualStyleBackColor = true;
            // 
            // radbttDaKham
            // 
            this.radbttDaKham.AutoSize = true;
            this.radbttDaKham.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbttDaKham.Location = new System.Drawing.Point(139, 32);
            this.radbttDaKham.Margin = new System.Windows.Forms.Padding(4);
            this.radbttDaKham.Name = "radbttDaKham";
            this.radbttDaKham.Size = new System.Drawing.Size(111, 28);
            this.radbttDaKham.TabIndex = 1;
            this.radbttDaKham.TabStop = true;
            this.radbttDaKham.Text = "Đã khám";
            this.radbttDaKham.UseVisualStyleBackColor = true;
            // 
            // radbttChuaKham
            // 
            this.radbttChuaKham.AutoSize = true;
            this.radbttChuaKham.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbttChuaKham.Location = new System.Drawing.Point(6, 32);
            this.radbttChuaKham.Margin = new System.Windows.Forms.Padding(4);
            this.radbttChuaKham.Name = "radbttChuaKham";
            this.radbttChuaKham.Size = new System.Drawing.Size(132, 28);
            this.radbttChuaKham.TabIndex = 0;
            this.radbttChuaKham.TabStop = true;
            this.radbttChuaKham.Text = "Chưa khám";
            this.radbttChuaKham.UseVisualStyleBackColor = true;
            // 
            // FrmPhongCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 638);
            this.Controls.Add(this.lbT);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.bttXem);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.lsvCT);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmPhongCho";
            this.Text = "FrmPhongCho";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbT;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button bttXem;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.ListView lsvCT;
        private System.Windows.Forms.ColumnHeader colMaPhieuKB;
        private System.Windows.Forms.ColumnHeader colHoTenBN;
        private System.Windows.Forms.ColumnHeader colLoaiKham;
        private System.Windows.Forms.ColumnHeader colTinhTrang;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cbbTenPK;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.RadioButton radbttTatCa;
        private System.Windows.Forms.RadioButton radbttDaKham;
        private System.Windows.Forms.RadioButton radbttChuaKham;
    }
}