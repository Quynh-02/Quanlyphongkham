namespace Quanlyphongkham
{
    partial class frmchucvu
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
            this.lsvchucvu = new System.Windows.Forms.ListView();
            this.colMachucvu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTencv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txttencv = new DevExpress.XtraEditors.TextEdit();
            this.txtmacv = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.txttencv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmacv.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(183, 20);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(315, 36);
            this.labelControl3.TabIndex = 68;
            this.labelControl3.Text = "DANH MỤC CHỨC VỤ";
            // 
            // lsvchucvu
            // 
            this.lsvchucvu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMachucvu,
            this.colTencv});
            this.lsvchucvu.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvchucvu.FullRowSelect = true;
            this.lsvchucvu.GridLines = true;
            this.lsvchucvu.HideSelection = false;
            this.lsvchucvu.Location = new System.Drawing.Point(91, 209);
            this.lsvchucvu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lsvchucvu.MultiSelect = false;
            this.lsvchucvu.Name = "lsvchucvu";
            this.lsvchucvu.Size = new System.Drawing.Size(509, 262);
            this.lsvchucvu.TabIndex = 67;
            this.lsvchucvu.UseCompatibleStateImageBehavior = false;
            this.lsvchucvu.View = System.Windows.Forms.View.Details;
            // 
            // colMachucvu
            // 
            this.colMachucvu.Text = "Mã chức vụ";
            this.colMachucvu.Width = 330;
            // 
            // colTencv
            // 
            this.colTencv.Text = "Tên chức vụ";
            this.colTencv.Width = 500;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txttencv);
            this.groupControl1.Controls.Add(this.txtmacv);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(91, 76);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(509, 126);
            this.groupControl1.TabIndex = 66;
            this.groupControl1.Text = "Thông tin chức vụ";
            // 
            // txttencv
            // 
            this.txttencv.Location = new System.Drawing.Point(138, 78);
            this.txttencv.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txttencv.Name = "txttencv";
            this.txttencv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttencv.Properties.Appearance.Options.UseFont = true;
            this.txttencv.Size = new System.Drawing.Size(309, 30);
            this.txttencv.TabIndex = 2;
            // 
            // txtmacv
            // 
            this.txtmacv.Location = new System.Drawing.Point(138, 36);
            this.txtmacv.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtmacv.Name = "txtmacv";
            this.txtmacv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmacv.Properties.Appearance.Options.UseFont = true;
            this.txtmacv.Size = new System.Drawing.Size(309, 30);
            this.txtmacv.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(23, 82);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(105, 22);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên chức vụ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(23, 39);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã chức vụ:";
            // 
            // bttThoat
            // 
            this.bttThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttThoat.Location = new System.Drawing.Point(551, 508);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(96, 40);
            this.bttThoat.TabIndex = 81;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = false;
            // 
            // bttHuy
            // 
            this.bttHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttHuy.Location = new System.Drawing.Point(449, 508);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(96, 40);
            this.bttHuy.TabIndex = 80;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = false;
            // 
            // bttLuu
            // 
            this.bttLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttLuu.Location = new System.Drawing.Point(347, 508);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(96, 40);
            this.bttLuu.TabIndex = 79;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = false;
            // 
            // bttXoa
            // 
            this.bttXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttXoa.Location = new System.Drawing.Point(245, 508);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(96, 40);
            this.bttXoa.TabIndex = 78;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = false;
            // 
            // bttSua
            // 
            this.bttSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttSua.Location = new System.Drawing.Point(140, 508);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(96, 40);
            this.bttSua.TabIndex = 77;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = false;
            // 
            // bttThem
            // 
            this.bttThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttThem.Location = new System.Drawing.Point(38, 508);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(96, 40);
            this.bttThem.TabIndex = 76;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = false;
            // 
            // frmchucvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 583);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lsvchucvu);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmchucvu";
            this.Text = "frmchucvu";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttencv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmacv.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ListView lsvchucvu;
        private System.Windows.Forms.ColumnHeader colMachucvu;
        private System.Windows.Forms.ColumnHeader colTencv;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txttencv;
        private DevExpress.XtraEditors.TextEdit txtmacv;
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