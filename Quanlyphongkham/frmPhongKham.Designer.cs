namespace Quanlyphongkham
{
    partial class frmPhongKham
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
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lsvphongkham = new System.Windows.Forms.ListView();
            this.colMaPK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenPK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTenPk = new DevExpress.XtraEditors.TextEdit();
            this.txtMapk = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMapk.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(129, 45);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(389, 36);
            this.labelControl5.TabIndex = 70;
            this.labelControl5.Text = "DANH MỤC PHÒNG KHÁM";
            // 
            // lsvphongkham
            // 
            this.lsvphongkham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPK,
            this.colTenPK});
            this.lsvphongkham.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvphongkham.FullRowSelect = true;
            this.lsvphongkham.GridLines = true;
            this.lsvphongkham.HideSelection = false;
            this.lsvphongkham.Location = new System.Drawing.Point(51, 211);
            this.lsvphongkham.Margin = new System.Windows.Forms.Padding(2);
            this.lsvphongkham.MultiSelect = false;
            this.lsvphongkham.Name = "lsvphongkham";
            this.lsvphongkham.Size = new System.Drawing.Size(556, 238);
            this.lsvphongkham.TabIndex = 69;
            this.lsvphongkham.UseCompatibleStateImageBehavior = false;
            this.lsvphongkham.View = System.Windows.Forms.View.Details;
            // 
            // colMaPK
            // 
            this.colMaPK.Text = "Mã phòng khám";
            this.colMaPK.Width = 350;
            // 
            // colTenPK
            // 
            this.colTenPK.Text = "Tên phòng khám";
            this.colTenPK.Width = 400;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtTenPk);
            this.groupControl1.Controls.Add(this.txtMapk);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(51, 96);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(555, 111);
            this.groupControl1.TabIndex = 68;
            this.groupControl1.Text = "Thông tin phòng khám";
            // 
            // txtTenPk
            // 
            this.txtTenPk.EditValue = "";
            this.txtTenPk.Location = new System.Drawing.Point(155, 69);
            this.txtTenPk.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenPk.Name = "txtTenPk";
            this.txtTenPk.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPk.Properties.Appearance.Options.UseFont = true;
            this.txtTenPk.Size = new System.Drawing.Size(337, 30);
            this.txtTenPk.TabIndex = 2;
            // 
            // txtMapk
            // 
            this.txtMapk.EditValue = "";
            this.txtMapk.Location = new System.Drawing.Point(155, 31);
            this.txtMapk.Margin = new System.Windows.Forms.Padding(2);
            this.txtMapk.Name = "txtMapk";
            this.txtMapk.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMapk.Properties.Appearance.Options.UseFont = true;
            this.txtMapk.Size = new System.Drawing.Size(337, 30);
            this.txtMapk.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(20, 78);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(136, 20);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên phòng khám:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(23, 39);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(133, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã phòng khám:";
            // 
            // bttThoat
            // 
            this.bttThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttThoat.Location = new System.Drawing.Point(541, 483);
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
            this.bttHuy.Location = new System.Drawing.Point(439, 483);
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
            this.bttLuu.Location = new System.Drawing.Point(337, 483);
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
            this.bttXoa.Location = new System.Drawing.Point(235, 483);
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
            this.bttSua.Location = new System.Drawing.Point(130, 483);
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
            this.bttThem.Location = new System.Drawing.Point(28, 483);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(96, 40);
            this.bttThem.TabIndex = 112;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = false;
            // 
            // frmPhongKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 556);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lsvphongkham);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmPhongKham";
            this.Text = "frmPhongKham";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMapk.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ListView lsvphongkham;
        private System.Windows.Forms.ColumnHeader colMaPK;
        private System.Windows.Forms.ColumnHeader colTenPK;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtTenPk;
        private DevExpress.XtraEditors.TextEdit txtMapk;
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