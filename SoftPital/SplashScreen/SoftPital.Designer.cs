namespace SplashScreen
{
    partial class SoftPital
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.GroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonList = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSupport = new Guna.UI2.WinForms.Guna2Button();
            this.buttonCerrarSecion = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAcercade = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonMedicamentos = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.BExit = new System.Windows.Forms.Label();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 356);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(674, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "StatusStrip";
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.BExit);
            this.GroupBox.Controls.Add(this.label3);
            this.GroupBox.Controls.Add(this.pictureBox1);
            this.GroupBox.Controls.Add(this.buttonList);
            this.GroupBox.Controls.Add(this.buttonSupport);
            this.GroupBox.Controls.Add(this.buttonCerrarSecion);
            this.GroupBox.Controls.Add(this.buttonAcercade);
            this.GroupBox.Controls.Add(this.ButtonMedicamentos);
            this.GroupBox.Controls.Add(this.buttonAddUser);
            this.GroupBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.ForeColor = System.Drawing.Color.White;
            this.GroupBox.Location = new System.Drawing.Point(0, 0);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.ShadowDecoration.Parent = this.GroupBox;
            this.GroupBox.Size = new System.Drawing.Size(674, 378);
            this.GroupBox.TabIndex = 6;
            this.GroupBox.Text = "Opciones - SoftPital";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(321, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 40);
            this.label3.TabIndex = 31;
            this.label3.Text = "SoftPital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SplashScreen.Properties.Resources.Recurso_2_72x_8;
            this.pictureBox1.Location = new System.Drawing.Point(235, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // buttonList
            // 
            this.buttonList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.buttonList.BorderRadius = 10;
            this.buttonList.BorderThickness = 1;
            this.buttonList.CheckedState.Parent = this.buttonList;
            this.buttonList.CustomImages.Parent = this.buttonList;
            this.buttonList.FillColor = System.Drawing.Color.White;
            this.buttonList.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.buttonList.HoverState.Parent = this.buttonList;
            this.buttonList.Image = global::SplashScreen.Properties.Resources.icons8_list_view_30;
            this.buttonList.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonList.Location = new System.Drawing.Point(483, 189);
            this.buttonList.Name = "buttonList";
            this.buttonList.ShadowDecoration.Parent = this.buttonList;
            this.buttonList.Size = new System.Drawing.Size(149, 38);
            this.buttonList.TabIndex = 29;
            this.buttonList.Text = "Lista de Pacientes";
            this.buttonList.Click += new System.EventHandler(this.BTPaC_Click);
            // 
            // buttonSupport
            // 
            this.buttonSupport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.buttonSupport.BorderRadius = 10;
            this.buttonSupport.BorderThickness = 1;
            this.buttonSupport.CheckedState.Parent = this.buttonSupport;
            this.buttonSupport.CustomImages.Parent = this.buttonSupport;
            this.buttonSupport.FillColor = System.Drawing.Color.White;
            this.buttonSupport.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.buttonSupport.HoverState.Parent = this.buttonSupport;
            this.buttonSupport.Image = global::SplashScreen.Properties.Resources.icons8_technical_support_26;
            this.buttonSupport.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonSupport.Location = new System.Drawing.Point(47, 287);
            this.buttonSupport.Name = "buttonSupport";
            this.buttonSupport.ShadowDecoration.Parent = this.buttonSupport;
            this.buttonSupport.Size = new System.Drawing.Size(141, 38);
            this.buttonSupport.TabIndex = 28;
            this.buttonSupport.Text = "Soporte";
            this.buttonSupport.Click += new System.EventHandler(this.BTPaS_Click);
            // 
            // buttonCerrarSecion
            // 
            this.buttonCerrarSecion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.buttonCerrarSecion.BorderRadius = 10;
            this.buttonCerrarSecion.BorderThickness = 1;
            this.buttonCerrarSecion.CheckedState.Parent = this.buttonCerrarSecion;
            this.buttonCerrarSecion.CustomImages.Parent = this.buttonCerrarSecion;
            this.buttonCerrarSecion.FillColor = System.Drawing.Color.White;
            this.buttonCerrarSecion.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarSecion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.buttonCerrarSecion.HoverState.Parent = this.buttonCerrarSecion;
            this.buttonCerrarSecion.Image = global::SplashScreen.Properties.Resources.icons8_logout_rounded_50;
            this.buttonCerrarSecion.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonCerrarSecion.Location = new System.Drawing.Point(483, 287);
            this.buttonCerrarSecion.Name = "buttonCerrarSecion";
            this.buttonCerrarSecion.ShadowDecoration.Parent = this.buttonCerrarSecion;
            this.buttonCerrarSecion.Size = new System.Drawing.Size(149, 38);
            this.buttonCerrarSecion.TabIndex = 27;
            this.buttonCerrarSecion.Text = "Cerrar Sesion";
            this.buttonCerrarSecion.Click += new System.EventHandler(this.BTCerrar_Click);
            // 
            // buttonAcercade
            // 
            this.buttonAcercade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.buttonAcercade.BorderRadius = 10;
            this.buttonAcercade.BorderThickness = 1;
            this.buttonAcercade.CheckedState.Parent = this.buttonAcercade;
            this.buttonAcercade.CustomImages.Parent = this.buttonAcercade;
            this.buttonAcercade.FillColor = System.Drawing.Color.White;
            this.buttonAcercade.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcercade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.buttonAcercade.HoverState.Parent = this.buttonAcercade;
            this.buttonAcercade.Image = global::SplashScreen.Properties.Resources.icons8_group_64;
            this.buttonAcercade.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonAcercade.Location = new System.Drawing.Point(271, 287);
            this.buttonAcercade.Name = "buttonAcercade";
            this.buttonAcercade.ShadowDecoration.Parent = this.buttonAcercade;
            this.buttonAcercade.Size = new System.Drawing.Size(141, 38);
            this.buttonAcercade.TabIndex = 26;
            this.buttonAcercade.Text = "Acerca de...";
            this.buttonAcercade.Click += new System.EventHandler(this.BTFact_Click);
            // 
            // ButtonMedicamentos
            // 
            this.ButtonMedicamentos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ButtonMedicamentos.BorderRadius = 10;
            this.ButtonMedicamentos.BorderThickness = 1;
            this.ButtonMedicamentos.CheckedState.Parent = this.ButtonMedicamentos;
            this.ButtonMedicamentos.CustomImages.Parent = this.ButtonMedicamentos;
            this.ButtonMedicamentos.FillColor = System.Drawing.Color.White;
            this.ButtonMedicamentos.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMedicamentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ButtonMedicamentos.HoverState.Parent = this.ButtonMedicamentos;
            this.ButtonMedicamentos.Image = global::SplashScreen.Properties.Resources.icons8_pills_30;
            this.ButtonMedicamentos.ImageSize = new System.Drawing.Size(25, 25);
            this.ButtonMedicamentos.Location = new System.Drawing.Point(271, 189);
            this.ButtonMedicamentos.Name = "ButtonMedicamentos";
            this.ButtonMedicamentos.ShadowDecoration.Parent = this.ButtonMedicamentos;
            this.ButtonMedicamentos.Size = new System.Drawing.Size(141, 38);
            this.ButtonMedicamentos.TabIndex = 25;
            this.ButtonMedicamentos.Text = "Medicamentos";
            this.ButtonMedicamentos.Click += new System.EventHandler(this.BTMedi_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.buttonAddUser.BorderRadius = 10;
            this.buttonAddUser.BorderThickness = 1;
            this.buttonAddUser.CheckedState.Parent = this.buttonAddUser;
            this.buttonAddUser.CustomImages.Parent = this.buttonAddUser;
            this.buttonAddUser.FillColor = System.Drawing.Color.White;
            this.buttonAddUser.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.buttonAddUser.HoverState.Parent = this.buttonAddUser;
            this.buttonAddUser.Image = global::SplashScreen.Properties.Resources.icons8_add_user_group_woman_man_64;
            this.buttonAddUser.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonAddUser.Location = new System.Drawing.Point(47, 189);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.ShadowDecoration.Parent = this.buttonAddUser;
            this.buttonAddUser.Size = new System.Drawing.Size(141, 38);
            this.buttonAddUser.TabIndex = 24;
            this.buttonAddUser.Text = "Añadir Paciente";
            this.buttonAddUser.Click += new System.EventHandler(this.BTNuevo_Click);
            // 
            // BExit
            // 
            this.BExit.AutoSize = true;
            this.BExit.BackColor = System.Drawing.Color.Transparent;
            this.BExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BExit.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.BExit.ForeColor = System.Drawing.Color.White;
            this.BExit.Location = new System.Drawing.Point(643, 3);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(27, 31);
            this.BExit.TabIndex = 32;
            this.BExit.Text = "x";
            this.BExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // SoftPital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 378);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.GroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoftPital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicApp";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Guna.UI2.WinForms.Guna2GroupBox GroupBox;
        private Guna.UI2.WinForms.Guna2Button buttonAddUser;
        private Guna.UI2.WinForms.Guna2Button buttonList;
        private Guna.UI2.WinForms.Guna2Button buttonSupport;
        private Guna.UI2.WinForms.Guna2Button buttonCerrarSecion;
        private Guna.UI2.WinForms.Guna2Button buttonAcercade;
        private Guna.UI2.WinForms.Guna2Button ButtonMedicamentos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BExit;
    }
}