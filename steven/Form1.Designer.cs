namespace steven
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnLogin = new System.Windows.Forms.Button();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rekomendasilogin = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nama = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(194, 324);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(92, 41);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(144, 199);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(237, 20);
            this.usernamebox.TabIndex = 2;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(40, 199);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(55, 13);
            this.username.TabIndex = 3;
            this.username.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(40, 247);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 4;
            this.password.Text = "Password";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(144, 282);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rekomendasilogin
            // 
            this.rekomendasilogin.AutoSize = true;
            this.rekomendasilogin.ForeColor = System.Drawing.Color.White;
            this.rekomendasilogin.Location = new System.Drawing.Point(153, 395);
            this.rekomendasilogin.Name = "rekomendasilogin";
            this.rekomendasilogin.Size = new System.Drawing.Size(127, 13);
            this.rekomendasilogin.TabIndex = 20;
            this.rekomendasilogin.Text = "didn\'t have any account?";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(283, 395);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(46, 13);
            this.link.TabIndex = 21;
            this.link.TabStop = true;
            this.link.Text = "Register";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(78, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 133);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.ForeColor = System.Drawing.Color.White;
            this.nama.Location = new System.Drawing.Point(40, 171);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(35, 13);
            this.nama.TabIndex = 24;
            this.nama.Text = "Name";
            this.nama.Visible = false;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(144, 168);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(237, 20);
            this.namebox.TabIndex = 23;
            this.namebox.Visible = false;
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(144, 247);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(237, 20);
            this.passwordbox.TabIndex = 25;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(453, 520);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.link);
            this.Controls.Add(this.rekomendasilogin);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.btnLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label rekomendasilogin;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox passwordbox;
    }
}

