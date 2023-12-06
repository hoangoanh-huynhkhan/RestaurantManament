
namespace GUI
{
    partial class frm__Login
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn__close = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn__minimize = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn__maximize = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pic__title = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pic__username = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pic__password = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.txt__username = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt__password = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn__showPassword = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn__login = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn__close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn__minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn__maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic__title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic__username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic__password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn__showPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn__login)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.btn__maximize);
            this.guna2Panel1.Controls.Add(this.btn__minimize);
            this.guna2Panel1.Controls.Add(this.btn__close);
            this.guna2Panel1.Location = new System.Drawing.Point(-15, -7);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(515, 56);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btn__close
            // 
            this.btn__close.Image = global::GUI.Properties.Resources.close;
            this.btn__close.ImageRotate = 0F;
            this.btn__close.Location = new System.Drawing.Point(30, 16);
            this.btn__close.Name = "btn__close";
            this.btn__close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn__close.Size = new System.Drawing.Size(30, 30);
            this.btn__close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn__close.TabIndex = 1;
            this.btn__close.TabStop = false;
            this.btn__close.Click += new System.EventHandler(this.btn__close_Click);
            // 
            // btn__minimize
            // 
            this.btn__minimize.Image = global::GUI.Properties.Resources.minus;
            this.btn__minimize.ImageRotate = 0F;
            this.btn__minimize.Location = new System.Drawing.Point(66, 16);
            this.btn__minimize.Name = "btn__minimize";
            this.btn__minimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn__minimize.Size = new System.Drawing.Size(30, 30);
            this.btn__minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn__minimize.TabIndex = 2;
            this.btn__minimize.TabStop = false;
            // 
            // btn__maximize
            // 
            this.btn__maximize.Image = global::GUI.Properties.Resources.full_screen;
            this.btn__maximize.ImageRotate = 0F;
            this.btn__maximize.Location = new System.Drawing.Point(102, 16);
            this.btn__maximize.Name = "btn__maximize";
            this.btn__maximize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn__maximize.Size = new System.Drawing.Size(30, 30);
            this.btn__maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn__maximize.TabIndex = 2;
            this.btn__maximize.TabStop = false;
            // 
            // pic__title
            // 
            this.pic__title.Image = global::GUI.Properties.Resources.login_;
            this.pic__title.ImageRotate = 0F;
            this.pic__title.Location = new System.Drawing.Point(112, 55);
            this.pic__title.Name = "pic__title";
            this.pic__title.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pic__title.Size = new System.Drawing.Size(244, 264);
            this.pic__title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic__title.TabIndex = 1;
            this.pic__title.TabStop = false;
            // 
            // pic__username
            // 
            this.pic__username.Image = global::GUI.Properties.Resources.profile;
            this.pic__username.ImageRotate = 0F;
            this.pic__username.Location = new System.Drawing.Point(27, 365);
            this.pic__username.Name = "pic__username";
            this.pic__username.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pic__username.Size = new System.Drawing.Size(64, 64);
            this.pic__username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic__username.TabIndex = 2;
            this.pic__username.TabStop = false;
            // 
            // pic__password
            // 
            this.pic__password.Image = global::GUI.Properties.Resources.password;
            this.pic__password.ImageRotate = 0F;
            this.pic__password.Location = new System.Drawing.Point(27, 487);
            this.pic__password.Name = "pic__password";
            this.pic__password.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pic__password.Size = new System.Drawing.Size(64, 64);
            this.pic__password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic__password.TabIndex = 3;
            this.pic__password.TabStop = false;
            // 
            // txt__username
            // 
            this.txt__username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt__username.BorderRadius = 15;
            this.txt__username.BorderThickness = 2;
            this.txt__username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt__username.DefaultText = "";
            this.txt__username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt__username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt__username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt__username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt__username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt__username.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.txt__username.ForeColor = System.Drawing.Color.Black;
            this.txt__username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt__username.Location = new System.Drawing.Point(112, 369);
            this.txt__username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt__username.Name = "txt__username";
            this.txt__username.PasswordChar = '\0';
            this.txt__username.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt__username.PlaceholderText = "Username";
            this.txt__username.SelectedText = "";
            this.txt__username.Size = new System.Drawing.Size(315, 58);
            this.txt__username.TabIndex = 4;
            // 
            // txt__password
            // 
            this.txt__password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt__password.BorderRadius = 15;
            this.txt__password.BorderThickness = 2;
            this.txt__password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt__password.DefaultText = "";
            this.txt__password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt__password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt__password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt__password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt__password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt__password.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.txt__password.ForeColor = System.Drawing.Color.Black;
            this.txt__password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt__password.Location = new System.Drawing.Point(112, 491);
            this.txt__password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt__password.Name = "txt__password";
            this.txt__password.PasswordChar = '\0';
            this.txt__password.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt__password.PlaceholderText = "Password";
            this.txt__password.SelectedText = "";
            this.txt__password.Size = new System.Drawing.Size(315, 58);
            this.txt__password.TabIndex = 5;
            // 
            // btn__showPassword
            // 
            this.btn__showPassword.BackColor = System.Drawing.Color.White;
            this.btn__showPassword.Image = global::GUI.Properties.Resources.hide__1_;
            this.btn__showPassword.ImageRotate = 0F;
            this.btn__showPassword.Location = new System.Drawing.Point(384, 507);
            this.btn__showPassword.Name = "btn__showPassword";
            this.btn__showPassword.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn__showPassword.Size = new System.Drawing.Size(30, 30);
            this.btn__showPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn__showPassword.TabIndex = 3;
            this.btn__showPassword.TabStop = false;
            this.btn__showPassword.Visible = false;
            // 
            // btn__login
            // 
            this.btn__login.BorderRadius = 20;
            this.btn__login.Image = global::GUI.Properties.Resources.verified;
            this.btn__login.ImageRotate = 0F;
            this.btn__login.Location = new System.Drawing.Point(158, 639);
            this.btn__login.Name = "btn__login";
            this.btn__login.Size = new System.Drawing.Size(166, 97);
            this.btn__login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn__login.TabIndex = 6;
            this.btn__login.TabStop = false;
            // 
            // frm__Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 766);
            this.Controls.Add(this.btn__login);
            this.Controls.Add(this.btn__showPassword);
            this.Controls.Add(this.txt__password);
            this.Controls.Add(this.txt__username);
            this.Controls.Add(this.pic__password);
            this.Controls.Add(this.pic__username);
            this.Controls.Add(this.pic__title);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm__Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn__close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn__minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn__maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic__title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic__username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic__password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn__showPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn__login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btn__close;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btn__maximize;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btn__minimize;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pic__password;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pic__username;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pic__title;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2TextBox txt__username;
        private Guna.UI2.WinForms.Guna2PictureBox btn__login;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btn__showPassword;
        private Guna.UI2.WinForms.Guna2TextBox txt__password;
    }
}