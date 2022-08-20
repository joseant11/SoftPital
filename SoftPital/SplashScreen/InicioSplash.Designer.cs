namespace SplashScreen
{
    partial class InicioSplash
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LBPorcentaje = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ProB = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LBPorcentaje
            // 
            this.LBPorcentaje.AutoSize = true;
            this.LBPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.LBPorcentaje.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.LBPorcentaje.Location = new System.Drawing.Point(128, 252);
            this.LBPorcentaje.Name = "LBPorcentaje";
            this.LBPorcentaje.Size = new System.Drawing.Size(54, 31);
            this.LBPorcentaje.TabIndex = 5;
            this.LBPorcentaje.Text = "0%";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 45;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ProB
            // 
            this.ProB.BackColor = System.Drawing.Color.Transparent;
            this.ProB.Controls.Add(this.label1);
            this.ProB.Controls.Add(this.pictureBoxLogo);
            this.ProB.Controls.Add(this.LBPorcentaje);
            this.ProB.Location = new System.Drawing.Point(107, 9);
            this.ProB.Name = "ProB";
            this.ProB.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ProB.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ProB.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProB.ShadowDecoration.Parent = this.ProB;
            this.ProB.Size = new System.Drawing.Size(315, 315);
            this.ProB.TabIndex = 6;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::SplashScreen.Properties.Resources.Recurso_2_72x_8;
            this.pictureBoxLogo.Location = new System.Drawing.Point(76, 67);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(164, 134);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.label1.Location = new System.Drawing.Point(74, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "SoftPital";
            // 
            // InicioSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 341);
            this.ControlBox = false;
            this.Controls.Add(this.ProB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSplash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InicioSplash_FormClosing);
            this.Load += new System.EventHandler(this.InicioSplash_Load);
            this.ProB.ResumeLayout(false);
            this.ProB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBPorcentaje;
        private System.Windows.Forms.Timer Timer;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProB;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label1;
    }
}

