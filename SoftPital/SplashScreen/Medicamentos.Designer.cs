namespace SplashScreen
{
    partial class Medicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicamentos));
            this.dataGridViewMed = new System.Windows.Forms.DataGridView();
            this.iDMedDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamentosDispBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softPitalDataSet1 = new SplashScreen.SoftPitalDataSet1();
            this.medicamentosDispTableAdapter = new SplashScreen.SoftPitalDataSet1TableAdapters.MedicamentosDispTableAdapter();
            this.buttonAtrasMed = new Guna.UI2.WinForms.Guna2Button();
            this.BExit = new System.Windows.Forms.Label();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.textBoxIDE = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ButtonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxIDB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosDispBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softPitalDataSet1)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMed
            // 
            this.dataGridViewMed.AutoGenerateColumns = false;
            this.dataGridViewMed.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMedDDataGridViewTextBoxColumn,
            this.nombreMedDataGridViewTextBoxColumn});
            this.dataGridViewMed.DataSource = this.medicamentosDispBindingSource;
            this.dataGridViewMed.Location = new System.Drawing.Point(21, 82);
            this.dataGridViewMed.Name = "dataGridViewMed";
            this.dataGridViewMed.Size = new System.Drawing.Size(246, 228);
            this.dataGridViewMed.TabIndex = 0;
            // 
            // iDMedDDataGridViewTextBoxColumn
            // 
            this.iDMedDDataGridViewTextBoxColumn.DataPropertyName = "ID_MedD";
            this.iDMedDDataGridViewTextBoxColumn.HeaderText = "ID_MedD";
            this.iDMedDDataGridViewTextBoxColumn.Name = "iDMedDDataGridViewTextBoxColumn";
            this.iDMedDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreMedDataGridViewTextBoxColumn
            // 
            this.nombreMedDataGridViewTextBoxColumn.DataPropertyName = "NombreMed";
            this.nombreMedDataGridViewTextBoxColumn.HeaderText = "NombreMed";
            this.nombreMedDataGridViewTextBoxColumn.Name = "nombreMedDataGridViewTextBoxColumn";
            // 
            // medicamentosDispBindingSource
            // 
            this.medicamentosDispBindingSource.DataMember = "MedicamentosDisp";
            this.medicamentosDispBindingSource.DataSource = this.softPitalDataSet1;
            // 
            // softPitalDataSet1
            // 
            this.softPitalDataSet1.DataSetName = "SoftPitalDataSet1";
            this.softPitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamentosDispTableAdapter
            // 
            this.medicamentosDispTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAtrasMed
            // 
            this.buttonAtrasMed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.buttonAtrasMed.BorderRadius = 10;
            this.buttonAtrasMed.BorderThickness = 1;
            this.buttonAtrasMed.CheckedState.Parent = this.buttonAtrasMed;
            this.buttonAtrasMed.CustomImages.Parent = this.buttonAtrasMed;
            this.buttonAtrasMed.FillColor = System.Drawing.Color.White;
            this.buttonAtrasMed.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtrasMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.buttonAtrasMed.HoverState.Parent = this.buttonAtrasMed;
            this.buttonAtrasMed.Image = global::SplashScreen.Properties.Resources.icons8_left_arrow_64;
            this.buttonAtrasMed.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonAtrasMed.Location = new System.Drawing.Point(12, 12);
            this.buttonAtrasMed.Name = "buttonAtrasMed";
            this.buttonAtrasMed.ShadowDecoration.Parent = this.buttonAtrasMed;
            this.buttonAtrasMed.Size = new System.Drawing.Size(47, 38);
            this.buttonAtrasMed.TabIndex = 28;
            this.buttonAtrasMed.Click += new System.EventHandler(this.button1_Click);
            // 
            // BExit
            // 
            this.BExit.AutoSize = true;
            this.BExit.BackColor = System.Drawing.Color.Transparent;
            this.BExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BExit.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.BExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BExit.Location = new System.Drawing.Point(525, 9);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(27, 31);
            this.BExit.TabIndex = 51;
            this.BExit.Text = "x";
            this.BExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderRadius = 5;
            this.guna2GroupBox3.BorderThickness = 2;
            this.guna2GroupBox3.Controls.Add(this.textBoxIDE);
            this.guna2GroupBox3.Controls.Add(this.ButtonDelete);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox3.Location = new System.Drawing.Point(302, 203);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
            this.guna2GroupBox3.Size = new System.Drawing.Size(236, 107);
            this.guna2GroupBox3.TabIndex = 53;
            this.guna2GroupBox3.Text = "Eliminar Paciente";
            // 
            // textBoxIDE
            // 
            this.textBoxIDE.BackColor = System.Drawing.Color.White;
            this.textBoxIDE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBoxIDE.BorderRadius = 10;
            this.textBoxIDE.BorderThickness = 2;
            this.textBoxIDE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxIDE.DefaultText = "";
            this.textBoxIDE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxIDE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxIDE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxIDE.DisabledState.Parent = this.textBoxIDE;
            this.textBoxIDE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxIDE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxIDE.FocusedState.Parent = this.textBoxIDE;
            this.textBoxIDE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDE.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxIDE.HoverState.Parent = this.textBoxIDE;
            this.textBoxIDE.Location = new System.Drawing.Point(9, 46);
            this.textBoxIDE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxIDE.Name = "textBoxIDE";
            this.textBoxIDE.PasswordChar = '\0';
            this.textBoxIDE.PlaceholderText = "ID";
            this.textBoxIDE.SelectedText = "";
            this.textBoxIDE.ShadowDecoration.Parent = this.textBoxIDE;
            this.textBoxIDE.Size = new System.Drawing.Size(97, 42);
            this.textBoxIDE.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textBoxIDE.TabIndex = 34;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ButtonDelete.BorderRadius = 10;
            this.ButtonDelete.BorderThickness = 1;
            this.ButtonDelete.CheckedState.Parent = this.ButtonDelete;
            this.ButtonDelete.CustomImages.Parent = this.ButtonDelete;
            this.ButtonDelete.FillColor = System.Drawing.Color.White;
            this.ButtonDelete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ButtonDelete.HoverState.Parent = this.ButtonDelete;
            this.ButtonDelete.Image = global::SplashScreen.Properties.Resources.icons8_delete_64;
            this.ButtonDelete.ImageSize = new System.Drawing.Size(25, 25);
            this.ButtonDelete.Location = new System.Drawing.Point(114, 55);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.ShadowDecoration.Parent = this.ButtonDelete;
            this.ButtonDelete.Size = new System.Drawing.Size(108, 33);
            this.ButtonDelete.TabIndex = 46;
            this.ButtonDelete.Text = "Borrar";
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderRadius = 5;
            this.guna2GroupBox2.BorderThickness = 2;
            this.guna2GroupBox2.Controls.Add(this.ButtonSearch);
            this.guna2GroupBox2.Controls.Add(this.textBoxIDB);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(302, 82);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(236, 107);
            this.guna2GroupBox2.TabIndex = 52;
            this.guna2GroupBox2.Text = "Buscar Paciente";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ButtonSearch.BorderRadius = 10;
            this.ButtonSearch.BorderThickness = 1;
            this.ButtonSearch.CheckedState.Parent = this.ButtonSearch;
            this.ButtonSearch.CustomImages.Parent = this.ButtonSearch;
            this.ButtonSearch.FillColor = System.Drawing.Color.White;
            this.ButtonSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ButtonSearch.HoverState.Parent = this.ButtonSearch;
            this.ButtonSearch.Image = global::SplashScreen.Properties.Resources.icons8_search_64;
            this.ButtonSearch.ImageSize = new System.Drawing.Size(25, 25);
            this.ButtonSearch.Location = new System.Drawing.Point(114, 56);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.ShadowDecoration.Parent = this.ButtonSearch;
            this.ButtonSearch.Size = new System.Drawing.Size(108, 33);
            this.ButtonSearch.TabIndex = 44;
            this.ButtonSearch.Text = "Buscar";
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // textBoxIDB
            // 
            this.textBoxIDB.BackColor = System.Drawing.Color.White;
            this.textBoxIDB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBoxIDB.BorderRadius = 10;
            this.textBoxIDB.BorderThickness = 2;
            this.textBoxIDB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxIDB.DefaultText = "";
            this.textBoxIDB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxIDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxIDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxIDB.DisabledState.Parent = this.textBoxIDB;
            this.textBoxIDB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxIDB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxIDB.FocusedState.Parent = this.textBoxIDB;
            this.textBoxIDB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxIDB.HoverState.Parent = this.textBoxIDB;
            this.textBoxIDB.Location = new System.Drawing.Point(9, 46);
            this.textBoxIDB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxIDB.Name = "textBoxIDB";
            this.textBoxIDB.PasswordChar = '\0';
            this.textBoxIDB.PlaceholderText = "ID";
            this.textBoxIDB.SelectedText = "";
            this.textBoxIDB.ShadowDecoration.Parent = this.textBoxIDB;
            this.textBoxIDB.Size = new System.Drawing.Size(97, 42);
            this.textBoxIDB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textBoxIDB.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(275, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 31);
            this.label3.TabIndex = 55;
            this.label3.Text = "SoftPital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SplashScreen.Properties.Resources.Recurso_2_72x_8;
            this.pictureBox1.Location = new System.Drawing.Point(209, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 346);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.buttonAtrasMed);
            this.Controls.Add(this.dataGridViewMed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Medicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicamentos";
            this.Load += new System.EventHandler(this.Medicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosDispBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softPitalDataSet1)).EndInit();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMed;
        private SoftPitalDataSet1 softPitalDataSet1;
        private System.Windows.Forms.BindingSource medicamentosDispBindingSource;
        private SoftPitalDataSet1TableAdapters.MedicamentosDispTableAdapter medicamentosDispTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMedDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMedDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button buttonAtrasMed;
        private System.Windows.Forms.Label BExit;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2TextBox textBoxIDE;
        private Guna.UI2.WinForms.Guna2Button ButtonDelete;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button ButtonSearch;
        private Guna.UI2.WinForms.Guna2TextBox textBoxIDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}