﻿namespace Quanlyphongkham
{
    partial class frmtiemkiembenhnhan
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bttThoat = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MABN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaysinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gioitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diachi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dantoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nghenghiep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txthoten = new DevExpress.XtraEditors.TextEdit();
            this.txtdienthoai = new DevExpress.XtraEditors.TextEdit();
            this.txtmabn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txthoten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdienthoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmabn.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(366, 62);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(343, 36);
            this.labelControl3.TabIndex = 85;
            this.labelControl3.Text = "TÌM KIẾM BỆNH NHÂN";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(770, 542);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 22);
            this.labelControl4.TabIndex = 84;
            this.labelControl4.Text = "Kết quả:";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(844, 537);
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
            this.button1.Location = new System.Drawing.Point(172, 564);
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
            this.bttThoat.Location = new System.Drawing.Point(844, 564);
            this.bttThoat.Margin = new System.Windows.Forms.Padding(2);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(88, 54);
            this.bttThoat.TabIndex = 80;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MABN,
            this.TenBN,
            this.ngaysinh,
            this.gioitinh,
            this.diachi,
            this.SDT,
            this.dantoc,
            this.nghenghiep});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(131, 317);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(787, 214);
            this.listView1.TabIndex = 81;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // MABN
            // 
            this.MABN.Text = "MABN";
            this.MABN.Width = 130;
            // 
            // TenBN
            // 
            this.TenBN.Text = "Tên BN";
            this.TenBN.Width = 200;
            // 
            // ngaysinh
            // 
            this.ngaysinh.Text = "Ngày sinh";
            this.ngaysinh.Width = 150;
            // 
            // gioitinh
            // 
            this.gioitinh.Text = "Giới tính";
            this.gioitinh.Width = 130;
            // 
            // diachi
            // 
            this.diachi.Text = "Địa chỉ";
            this.diachi.Width = 200;
            // 
            // SDT
            // 
            this.SDT.Text = "SDT";
            this.SDT.Width = 150;
            // 
            // dantoc
            // 
            this.dantoc.Text = "Dân tộc";
            this.dantoc.Width = 120;
            // 
            // nghenghiep
            // 
            this.nghenghiep.Text = "Nghề nghiệp";
            this.nghenghiep.Width = 260;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txthoten);
            this.groupControl1.Controls.Add(this.txtdienthoai);
            this.groupControl1.Controls.Add(this.txtmabn);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(271, 130);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(523, 182);
            this.groupControl1.TabIndex = 79;
            this.groupControl1.Text = "Thông tin bệnh nhân";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(136, 69);
            this.txthoten.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txthoten.Name = "txthoten";
            this.txthoten.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.Properties.Appearance.Options.UseFont = true;
            this.txthoten.Size = new System.Drawing.Size(341, 28);
            this.txthoten.TabIndex = 2;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(136, 127);
            this.txtdienthoai.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdienthoai.Properties.Appearance.Options.UseFont = true;
            this.txtdienthoai.Size = new System.Drawing.Size(341, 28);
            this.txtdienthoai.TabIndex = 7;
            // 
            // txtmabn
            // 
            this.txtmabn.Location = new System.Drawing.Point(136, 34);
            this.txtmabn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtmabn.Name = "txtmabn";
            this.txtmabn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmabn.Properties.Appearance.Options.UseFont = true;
            this.txtmabn.Size = new System.Drawing.Size(120, 28);
            this.txtmabn.TabIndex = 1;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(20, 73);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(115, 22);
            this.labelControl11.TabIndex = 10;
            this.labelControl11.Text = "Họ và tên BN:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(41, 130);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(89, 22);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Điện thoại:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(68, 39);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã BN:";
            // 
            // frmtiemkiembenhnhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 681);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmtiemkiembenhnhan";
            this.Text = "frmtiemkiembenhnhan";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txthoten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdienthoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmabn.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MABN;
        private System.Windows.Forms.ColumnHeader TenBN;
        private System.Windows.Forms.ColumnHeader ngaysinh;
        private System.Windows.Forms.ColumnHeader gioitinh;
        private System.Windows.Forms.ColumnHeader diachi;
        private System.Windows.Forms.ColumnHeader SDT;
        private System.Windows.Forms.ColumnHeader dantoc;
        private System.Windows.Forms.ColumnHeader nghenghiep;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txthoten;
        private DevExpress.XtraEditors.TextEdit txtdienthoai;
        private DevExpress.XtraEditors.TextEdit txtmabn;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}