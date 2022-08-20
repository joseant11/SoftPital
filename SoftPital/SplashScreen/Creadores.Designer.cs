namespace SplashScreen
{
    partial class Creadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creadores));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAtrasAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.BExit = new System.Windows.Forms.Label();
            this.TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2TextBox1);
            this.guna2Panel1.Controls.Add(this.TextBox1);
            this.guna2Panel1.Controls.Add(this.BExit);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.buttonAtrasAddUser);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(497, 304);
            this.guna2Panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(239, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 31);
            this.label4.TabIndex = 57;
            this.label4.Text = "SoftPital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SplashScreen.Properties.Resources.Recurso_2_72x_8;
            this.pictureBox1.Location = new System.Drawing.Point(173, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAtrasAddUser
            // 
            this.buttonAtrasAddUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.buttonAtrasAddUser.BorderRadius = 10;
            this.buttonAtrasAddUser.BorderThickness = 1;
            this.buttonAtrasAddUser.CheckedState.Parent = this.buttonAtrasAddUser;
            this.buttonAtrasAddUser.CustomImages.Parent = this.buttonAtrasAddUser;
            this.buttonAtrasAddUser.FillColor = System.Drawing.Color.White;
            this.buttonAtrasAddUser.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtrasAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.buttonAtrasAddUser.HoverState.Parent = this.buttonAtrasAddUser;
            this.buttonAtrasAddUser.Image = global::SplashScreen.Properties.Resources.icons8_left_arrow_64;
            this.buttonAtrasAddUser.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonAtrasAddUser.Location = new System.Drawing.Point(3, 3);
            this.buttonAtrasAddUser.Name = "buttonAtrasAddUser";
            this.buttonAtrasAddUser.ShadowDecoration.Parent = this.buttonAtrasAddUser;
            this.buttonAtrasAddUser.Size = new System.Drawing.Size(36, 33);
            this.buttonAtrasAddUser.TabIndex = 55;
            this.buttonAtrasAddUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // BExit
            // 
            this.BExit.AutoSize = true;
            this.BExit.BackColor = System.Drawing.Color.Transparent;
            this.BExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BExit.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.BExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BExit.Location = new System.Drawing.Point(467, 5);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(27, 31);
            this.BExit.TabIndex = 58;
            this.BExit.Text = "x";
            this.BExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox1.DefaultText = "SoftPital es un software gestión de pacientes permite que el personal autorizado " +
    "visualice y edite los datos de los pacientes y el historial de interacción.";
            this.TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1.DisabledState.Parent = this.TextBox1;
            this.TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1.FocusedState.Parent = this.TextBox1;
            this.TextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.ForeColor = System.Drawing.Color.Gray;
            this.TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1.HoverState.Parent = this.TextBox1;
            this.TextBox1.Location = new System.Drawing.Point(7, 112);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '\0';
            this.TextBox1.PlaceholderText = "";
            this.TextBox1.SelectedText = "";
            this.TextBox1.SelectionStart = 156;
            this.TextBox1.ShadowDecoration.Parent = this.TextBox1;
            this.TextBox1.Size = new System.Drawing.Size(483, 80);
            this.TextBox1.TabIndex = 59;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "- Isabel Stephany Vásquez Terrero (2019-9032) -Woodjiny Sashka Renard (2021-1025)" +
    "                - José Antonio Rosa Guzmán (2021-1073)";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(75, 200);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Multiline = true;
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(348, 80);
            this.guna2TextBox1.TabIndex = 60;
            // 
            // Creadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(521, 330);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Creadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creadores";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button buttonAtrasAddUser;
        private System.Windows.Forms.Label BExit;
        private Guna.UI2.WinForms.Guna2TextBox TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}