namespace Quanlyphongkham
{
    partial class frmDSBN
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
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.radiobtnu = new System.Windows.Forms.RadioButton();
            this.radiobtnam = new System.Windows.Forms.RadioButton();
            this.lable = new DevExpress.XtraEditors.LabelControl();
            this.txtnghenghiep = new DevExpress.XtraEditors.TextEdit();
            this.cbbdantoc = new System.Windows.Forms.ComboBox();
            this.txtdiachi = new DevExpress.XtraEditors.TextEdit();
            this.txthoten = new DevExpress.XtraEditors.TextEdit();
            this.txtdienthoai = new DevExpress.XtraEditors.TextEdit();
            this.txtmabn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bttThoat = new System.Windows.Forms.Button();
            this.bttHuy = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.bttThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnghenghiep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiachi.Properties)).BeginInit();
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
            this.labelControl3.Location = new System.Drawing.Point(342, 33);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(328, 36);
            this.labelControl3.TabIndex = 69;
            this.labelControl3.Text = "QUẢN LÝ BỆNH NHÂN";
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
            this.listView1.Location = new System.Drawing.Point(120, 390);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(787, 214);
            this.listView1.TabIndex = 68;
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
            this.groupControl1.Controls.Add(this.dtngaysinh);
            this.groupControl1.Controls.Add(this.radiobtnu);
            this.groupControl1.Controls.Add(this.radiobtnam);
            this.groupControl1.Controls.Add(this.lable);
            this.groupControl1.Controls.Add(this.txtnghenghiep);
            this.groupControl1.Controls.Add(this.cbbdantoc);
            this.groupControl1.Controls.Add(this.txtdiachi);
            this.groupControl1.Controls.Add(this.txthoten);
            this.groupControl1.Controls.Add(this.txtdienthoai);
            this.groupControl1.Controls.Add(this.txtmabn);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(120, 86);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(785, 292);
            this.groupControl1.TabIndex = 67;
            this.groupControl1.Text = "Thông tin bệnh nhân";
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtngaysinh.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaysinh.Location = new System.Drawing.Point(136, 110);
            this.dtngaysinh.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(255, 28);
            this.dtngaysinh.TabIndex = 3;
            // 
            // radiobtnu
            // 
            this.radiobtnu.AutoSize = true;
            this.radiobtnu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnu.Location = new System.Drawing.Point(534, 108);
            this.radiobtnu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radiobtnu.Name = "radiobtnu";
            this.radiobtnu.Size = new System.Drawing.Size(52, 25);
            this.radiobtnu.TabIndex = 5;
            this.radiobtnu.TabStop = true;
            this.radiobtnu.Text = "Nữ";
            this.radiobtnu.UseVisualStyleBackColor = true;
            // 
            // radiobtnam
            // 
            this.radiobtnam.AutoSize = true;
            this.radiobtnam.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnam.Location = new System.Drawing.Point(475, 108);
            this.radiobtnam.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radiobtnam.Name = "radiobtnam";
            this.radiobtnam.Size = new System.Drawing.Size(65, 25);
            this.radiobtnam.TabIndex = 4;
            this.radiobtnam.TabStop = true;
            this.radiobtnam.Text = "Nam";
            this.radiobtnam.UseVisualStyleBackColor = true;
            // 
            // lable
            // 
            this.lable.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Appearance.Options.UseFont = true;
            this.lable.Location = new System.Drawing.Point(31, 252);
            this.lable.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(107, 22);
            this.lable.TabIndex = 62;
            this.lable.Text = "Nghề nghiệp:";
            // 
            // txtnghenghiep
            // 
            this.txtnghenghiep.Location = new System.Drawing.Point(136, 249);
            this.txtnghenghiep.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtnghenghiep.Name = "txtnghenghiep";
            this.txtnghenghiep.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnghenghiep.Properties.Appearance.Options.UseFont = true;
            this.txtnghenghiep.Size = new System.Drawing.Size(537, 28);
            this.txtnghenghiep.TabIndex = 9;
            // 
            // cbbdantoc
            // 
            this.cbbdantoc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbdantoc.FormattingEnabled = true;
            this.cbbdantoc.Location = new System.Drawing.Point(136, 215);
            this.cbbdantoc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbbdantoc.Name = "cbbdantoc";
            this.cbbdantoc.Size = new System.Drawing.Size(121, 29);
            this.cbbdantoc.TabIndex = 8;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(136, 142);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Properties.Appearance.Options.UseFont = true;
            this.txtdiachi.Size = new System.Drawing.Size(537, 28);
            this.txtdiachi.TabIndex = 6;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(136, 69);
            this.txthoten.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txthoten.Name = "txthoten";
            this.txthoten.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.Properties.Appearance.Options.UseFont = true;
            this.txthoten.Size = new System.Drawing.Size(537, 28);
            this.txthoten.TabIndex = 2;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(136, 178);
            this.txtdienthoai.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdienthoai.Properties.Appearance.Options.UseFont = true;
            this.txtdienthoai.Size = new System.Drawing.Size(537, 28);
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
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(63, 218);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(69, 22);
            this.labelControl15.TabIndex = 14;
            this.labelControl15.Text = "Dân tộc:";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(396, 110);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(77, 22);
            this.labelControl14.TabIndex = 13;
            this.labelControl14.Text = "Giới tính:";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(47, 110);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(82, 20);
            this.labelControl12.TabIndex = 11;
            this.labelControl12.Text = "Ngày sinh:";
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
            this.labelControl5.Location = new System.Drawing.Point(47, 178);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(89, 22);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Điện thoại:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(68, 146);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 22);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Địa chỉ:";
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
            // bttThoat
            // 
            this.bttThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttThoat.Location = new System.Drawing.Point(697, 645);
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
            this.bttHuy.Location = new System.Drawing.Point(595, 645);
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
            this.bttLuu.Location = new System.Drawing.Point(493, 645);
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
            this.bttXoa.Location = new System.Drawing.Point(391, 645);
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
            this.bttSua.Location = new System.Drawing.Point(286, 645);
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
            this.bttThem.Location = new System.Drawing.Point(184, 645);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(96, 40);
            this.bttThem.TabIndex = 94;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = false;
            // 
            // frmDSBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 743);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttHuy);
            this.Controls.Add(this.bttLuu);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDSBN";
            this.Text = "frmDSBN";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnghenghiep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthoten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdienthoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmabn.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
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
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private System.Windows.Forms.RadioButton radiobtnu;
        private System.Windows.Forms.RadioButton radiobtnam;
        private DevExpress.XtraEditors.LabelControl lable;
        private DevExpress.XtraEditors.TextEdit txtnghenghiep;
        private System.Windows.Forms.ComboBox cbbdantoc;
        private DevExpress.XtraEditors.TextEdit txtdiachi;
        private DevExpress.XtraEditors.TextEdit txthoten;
        private DevExpress.XtraEditors.TextEdit txtdienthoai;
        private DevExpress.XtraEditors.TextEdit txtmabn;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button bttThem;
    }
}