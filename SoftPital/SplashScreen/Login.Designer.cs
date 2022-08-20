namespace SplashScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BExit = new System.Windows.Forms.Label();
            this.BTLog = new Guna.UI2.WinForms.Guna2Button();
            this.TBUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.TBPass = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SplashScreen.Properties.Resources.Recurso_2_72x_8;
            this.pictureBox1.Location = new System.Drawing.Point(360, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(63, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 55);
            this.label3.TabIndex = 7;
            this.label3.Text = "SoftPital";
            // 
            // BExit
            // 
            this.BExit.AutoSize = true;
            this.BExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BExit.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.BExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BExit.Location = new System.Drawing.Point(614, 9);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(27, 31);
            this.BExit.TabIndex = 11;
            this.BExit.Text = "x";
            this.BExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // BTLog
            // 
            this.BTLog.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BTLog.BorderRadius = 20;
            this.BTLog.BorderThickness = 1;
            this.BTLog.CheckedState.Parent = this.BTLog;
            this.BTLog.CustomImages.Parent = this.BTLog;
            this.BTLog.FillColor = System.Drawing.Color.White;
            this.BTLog.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BTLog.HoverState.Parent = this.BTLog;
            this.BTLog.Location = new System.Drawing.Point(84, 297);
            this.BTLog.Name = "BTLog";
            this.BTLog.PressedColor = System.Drawing.Color.LightGray;
            this.BTLog.ShadowDecoration.Parent = this.BTLog;
            this.BTLog.Size = new System.Drawing.Size(180, 45);
            this.BTLog.TabIndex = 12;
            this.BTLog.Text = "Iniciar Sesión";
            this.BTLog.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBUser
            // 
            this.TBUser.BackColor = System.Drawing.Color.White;
            this.TBUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.TBUser.BorderRadius = 10;
            this.TBUser.BorderThickness = 2;
            this.TBUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBUser.DefaultText = "";
            this.TBUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBUser.DisabledState.Parent = this.TBUser;
            this.TBUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBUser.FocusedState.Parent = this.TBUser;
            this.TBUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBUser.HoverState.Parent = this.TBUser;
            this.TBUser.Location = new System.Drawing.Point(27, 134);
            this.TBUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBUser.Name = "TBUser";
            this.TBUser.PasswordChar = '\0';
            this.TBUser.PlaceholderText = "Usuario";
            this.TBUser.SelectedText = "";
            this.TBUser.ShadowDecoration.Parent = this.TBUser;
            this.TBUser.Size = new System.Drawing.Size(294, 42);
            this.TBUser.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TBUser.TabIndex = 13;
            // 
            // TBPass
            // 
            this.TBPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.TBPass.BorderRadius = 10;
            this.TBPass.BorderThickness = 2;
            this.TBPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBPass.DefaultText = "";
            this.TBPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBPass.DisabledState.Parent = this.TBPass;
            this.TBPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBPass.FocusedState.Parent = this.TBPass;
            this.TBPass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.TBPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBPass.HoverState.Parent = this.TBPass;
            this.TBPass.Location = new System.Drawing.Point(30, 216);
            this.TBPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBPass.Name = "TBPass";
            this.TBPass.PasswordChar = '\0';
            this.TBPass.PlaceholderText = "Contraseña";
            this.TBPass.SelectedText = "";
            this.TBPass.ShadowDecoration.Parent = this.TBPass;
            this.TBPass.Size = new System.Drawing.Size(294, 42);
            this.TBPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TBPass.TabIndex = 14;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(653, 381);
            this.ControlBox = false;
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBUser);
            this.Controls.Add(this.BTLog);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BExit;
        private Guna.UI2.WinForms.Guna2Button BTLog;
        private Guna.UI2.WinForms.Guna2TextBox TBUser;
        private Guna.UI2.WinForms.Guna2TextBox TBPass;
    }
}