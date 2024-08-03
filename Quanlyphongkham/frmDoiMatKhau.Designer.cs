namespace Quanlyphongkham
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtxnmk = new DevExpress.XtraEditors.TextEdit();
            this.txtmkmoi = new DevExpress.XtraEditors.TextEdit();
            this.txtmkcu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtxnmk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmkmoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmkcu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(458, 306);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(80, 41);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "Cancel";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(286, 306);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 41);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Xác nhận";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboBox1);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtxnmk);
            this.groupControl1.Controls.Add(this.txtmkmoi);
            this.groupControl1.Controls.Add(this.txtmkcu);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(208, 104);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(385, 182);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Đổi mật khẩu";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(162, 57);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(40, 60);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Tên tài khoản";
            // 
            // txtxnmk
            // 
            this.txtxnmk.Location = new System.Drawing.Point(162, 138);
            this.txtxnmk.Margin = new System.Windows.Forms.Padding(4);
            this.txtxnmk.Name = "txtxnmk";
            this.txtxnmk.Properties.PasswordChar = '•';
            this.txtxnmk.Size = new System.Drawing.Size(182, 22);
            this.txtxnmk.TabIndex = 4;
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.Location = new System.Drawing.Point(162, 112);
            this.txtmkmoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.Properties.PasswordChar = '•';
            this.txtmkmoi.Size = new System.Drawing.Size(182, 22);
            this.txtmkmoi.TabIndex = 3;
            // 
            // txtmkcu
            // 
            this.txtmkcu.Location = new System.Drawing.Point(162, 84);
            this.txtmkcu.Margin = new System.Windows.Forms.Padding(4);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Properties.PasswordChar = '•';
            this.txtmkcu.Size = new System.Drawing.Size(182, 22);
            this.txtmkcu.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(40, 142);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(110, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Xác nhận mật khẩu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(40, 116);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(111, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nhập mật khẩu mới";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(40, 87);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhập mật khẩu cũ";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDoiMatKhau";
            this.Text = "frmDoiMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtxnmk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmkmoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmkcu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtxnmk;
        private DevExpress.XtraEditors.TextEdit txtmkmoi;
        private DevExpress.XtraEditors.TextEdit txtmkcu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}