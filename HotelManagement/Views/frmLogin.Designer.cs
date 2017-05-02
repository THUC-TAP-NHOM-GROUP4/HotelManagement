namespace HotelManagement
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.login_picturebox_hotelimage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.login_linklabel_linkpage = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_textbox_password = new System.Windows.Forms.TextBox();
            this.login_textbox_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login_erp_password = new System.Windows.Forms.ErrorProvider(this.components);
            this.login_erp_username = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.login_picturebox_hotelimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_erp_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_erp_username)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_picturebox_hotelimage
            // 
            this.login_picturebox_hotelimage.Image = ((System.Drawing.Image)(resources.GetObject("login_picturebox_hotelimage.Image")));
            this.login_picturebox_hotelimage.Location = new System.Drawing.Point(0, 129);
            this.login_picturebox_hotelimage.Name = "login_picturebox_hotelimage";
            this.login_picturebox_hotelimage.Size = new System.Drawing.Size(600, 481);
            this.login_picturebox_hotelimage.TabIndex = 2;
            this.login_picturebox_hotelimage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Charlemagne Std", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(356, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOAROM HOTEL";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDangNhap.Location = new System.Drawing.Point(332, 219);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(141, 42);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // login_linklabel_linkpage
            // 
            this.login_linklabel_linkpage.AutoSize = true;
            this.login_linklabel_linkpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.login_linklabel_linkpage.Location = new System.Drawing.Point(67, 236);
            this.login_linklabel_linkpage.Name = "login_linklabel_linkpage";
            this.login_linklabel_linkpage.Size = new System.Drawing.Size(238, 25);
            this.login_linklabel_linkpage.TabIndex = 3;
            this.login_linklabel_linkpage.TabStop = true;
            this.login_linklabel_linkpage.Text = "hoaromhotel.hoarom.vn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(67, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(67, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu";
            // 
            // login_textbox_password
            // 
            this.login_textbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.login_textbox_password.Location = new System.Drawing.Point(236, 160);
            this.login_textbox_password.Name = "login_textbox_password";
            this.login_textbox_password.Size = new System.Drawing.Size(237, 31);
            this.login_textbox_password.TabIndex = 1;
            this.login_textbox_password.UseSystemPasswordChar = true;
            // 
            // login_textbox_username
            // 
            this.login_textbox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.login_textbox_username.Location = new System.Drawing.Point(236, 104);
            this.login_textbox_username.Name = "login_textbox_username";
            this.login_textbox_username.Size = new System.Drawing.Size(237, 31);
            this.login_textbox_username.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(18, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ĐĂNG NHẬP";
            // 
            // login_erp_password
            // 
            this.login_erp_password.ContainerControl = this;
            // 
            // login_erp_username
            // 
            this.login_erp_username.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.login_textbox_username);
            this.panel2.Controls.Add(this.btnDangNhap);
            this.panel2.Controls.Add(this.login_textbox_password);
            this.panel2.Controls.Add(this.login_linklabel_linkpage);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(598, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 481);
            this.panel2.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_picturebox_hotelimage);
            this.MaximumSize = new System.Drawing.Size(1200, 650);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoarom Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.login_picturebox_hotelimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_erp_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_erp_username)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox login_picturebox_hotelimage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.LinkLabel login_linklabel_linkpage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_textbox_password;
        private System.Windows.Forms.TextBox login_textbox_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider login_erp_password;
        private System.Windows.Forms.ErrorProvider login_erp_username;
        private System.Windows.Forms.Panel panel2;
    }
}

