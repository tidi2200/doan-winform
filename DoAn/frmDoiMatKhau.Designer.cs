namespace DoAn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.txtMatkhauhientai = new System.Windows.Forms.TextBox();
            this.txtMatkhaumoi = new System.Windows.Forms.TextBox();
            this.radHien = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản (Mã nhân viên)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu hiện tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 108);
            this.button1.TabIndex = 3;
            this.button1.Text = "Đổi mật khẩu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtManv
            // 
            this.txtManv.Enabled = false;
            this.txtManv.Location = new System.Drawing.Point(466, 110);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(285, 38);
            this.txtManv.TabIndex = 4;
            // 
            // txtMatkhauhientai
            // 
            this.txtMatkhauhientai.Location = new System.Drawing.Point(466, 234);
            this.txtMatkhauhientai.Name = "txtMatkhauhientai";
            this.txtMatkhauhientai.Size = new System.Drawing.Size(285, 38);
            this.txtMatkhauhientai.TabIndex = 5;
            this.txtMatkhauhientai.UseSystemPasswordChar = true;
            // 
            // txtMatkhaumoi
            // 
            this.txtMatkhaumoi.Location = new System.Drawing.Point(466, 371);
            this.txtMatkhaumoi.Name = "txtMatkhaumoi";
            this.txtMatkhaumoi.Size = new System.Drawing.Size(285, 38);
            this.txtMatkhaumoi.TabIndex = 6;
            this.txtMatkhaumoi.UseSystemPasswordChar = true;
            // 
            // radHien
            // 
            this.radHien.AutoSize = true;
            this.radHien.Location = new System.Drawing.Point(780, 301);
            this.radHien.Name = "radHien";
            this.radHien.Size = new System.Drawing.Size(111, 36);
            this.radHien.TabIndex = 7;
            this.radHien.TabStop = true;
            this.radHien.Text = "Hiện";
            this.radHien.UseVisualStyleBackColor = true;
            this.radHien.CheckedChanged += new System.EventHandler(this.radHien_CheckedChanged);
            this.radHien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radHien_MouseClick);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 647);
            this.Controls.Add(this.radHien);
            this.Controls.Add(this.txtMatkhaumoi);
            this.Controls.Add(this.txtMatkhauhientai);
            this.Controls.Add(this.txtManv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.TextBox txtMatkhauhientai;
        private System.Windows.Forms.TextBox txtMatkhaumoi;
        private System.Windows.Forms.RadioButton radHien;
    }
}