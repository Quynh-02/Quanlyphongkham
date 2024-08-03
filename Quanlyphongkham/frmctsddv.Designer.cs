namespace Quanlyphongkham
{
    partial class frmctsddv
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lsvctsddv = new System.Windows.Forms.ListView();
            this.colMaPCLS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTendantoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbbmadv = new System.Windows.Forms.ComboBox();
            this.cbbmapcls = new System.Windows.Forms.ComboBox();
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
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(270, 24);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(230, 36);
            this.labelControl3.TabIndex = 69;
            this.labelControl3.Text = "CHI TIẾT SDDV";
            // 
            // lsvctsddv
            // 
            this.lsvctsddv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPCLS,
            this.colTendantoc});
            this.lsvctsddv.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvctsddv.FullRowSelect = true;
            this.lsvctsddv.GridLines = true;
            this.lsvctsddv.HideSelection = false;
            this.lsvctsddv.Location = new System.Drawing.Point(145, 188);
            this.lsvctsddv.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lsvctsddv.MultiSelect = false;
            this.lsvctsddv.Name = "lsvctsddv";
            this.lsvctsddv.Size = new System.Drawing.Size(499, 312);
            this.lsvctsddv.TabIndex = 68;
            this.lsvctsddv.UseCompatibleStateImageBehavior = false;
            this.lsvctsddv.View = System.Windows.Forms.View.Details;
            // 
            // colMaPCLS
            // 
            this.colMaPCLS.Text = "Mã PCLS";
            this.colMaPCLS.Width = 350;
            // 
            // colTendantoc
            // 
            this.colTendantoc.Text = "TÊN DỊCH VỤ";
            this.colTendantoc.Width = 400;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbbmadv);
            this.groupControl1.Controls.Add(this.cbbmapcls);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(145, 80);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(498, 101);
            this.groupControl1.TabIndex = 67;
            this.groupControl1.Text = "Thông tin phiếu";
            // 
            // cbbmadv
            // 
            this.cbbmadv.FormattingEnabled = true;
            this.cbbmadv.Location = new System.Drawing.Point(200, 68);
            this.cbbmadv.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbbmadv.Name = "cbbmadv";
            this.cbbmadv.Size = new System.Drawing.Size(247, 24);
            this.cbbmadv.TabIndex = 2;
            // 
            // cbbmapcls
            // 
            this.cbbmapcls.FormattingEnabled = true;
            this.cbbmapcls.Location = new System.Drawing.Point(200, 39);
            this.cbbmapcls.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbbmapcls.Name = "cbbmapcls";
            this.cbbmapcls.Size = new System.Drawing.Size(247, 24);
            this.cbbmapcls.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(98, 66);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 22);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên dịch vụ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(0, 39);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
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
            this.bttThoat.Location = new System.Drawing.Point(608, 537);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(96, 40);
            this.bttThoat.TabIndex = 75;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = false;
            // 
            // bttHuy
            // 
            this.bttHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttHuy.Location = new System.Drawing.Point(506, 537);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(96, 40);
            this.bttHuy.TabIndex = 74;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = false;
            // 
            // bttLuu
            // 
            this.bttLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttLuu.Location = new System.Drawing.Point(404, 537);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(96, 40);
            this.bttLuu.TabIndex = 73;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = false;
            // 
            // bttXoa
            // 
            this.bttXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttXoa.Location = new System.Drawing.Point(302, 537);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(96, 40);
            this.bttXoa.TabIndex = 72;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = false;
            // 
            // bttSua
            // 
            this.bttSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttSua.Location = new System.Drawing.Point(197, 537);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(96, 40);
            this.bttSua.TabIndex = 71;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = false;
            // 
            // bttThem
            // 
            this.bttThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttThem.Location = new System.Drawing.Point(95, 537);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(96, 40);
            this.bttThem.TabIndex = 70;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = false;
            // 
            // frmctsddv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 613);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lsvctsddv);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmctsddv";
            this.Text = "frmctsddv";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ListView lsvctsddv;
        private System.Windows.Forms.ColumnHeader colMaPCLS;
        private System.Windows.Forms.ColumnHeader colTendantoc;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cbbmadv;
        private System.Windows.Forms.ComboBox cbbmapcls;
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