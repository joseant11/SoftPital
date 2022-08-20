namespace SplashScreen
{
    partial class PacientesC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacientesC));
            this.dataGridViewListPacient = new System.Windows.Forms.DataGridView();
            this.iDNPacientesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.seguroDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tipoSeguroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuevosPacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softPitalDataSet = new SplashScreen.SoftPitalDataSet();
            this.nuevos_PacientesTableAdapter = new SplashScreen.SoftPitalDataSetTableAdapters.Nuevos_PacientesTableAdapter();
            this.BExit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AtrasListPaciente = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ButtonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxIDB = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListPacient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevosPacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softPitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewListPacient
            // 
            this.dataGridViewListPacient.AutoGenerateColumns = false;
            this.dataGridViewListPacient.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewListPacient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListPacient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDNPacientesDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.consultaDataGridViewCheckBoxColumn,
            this.seguroDataGridViewCheckBoxColumn,
            this.tipoSeguroDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.dataGridViewListPacient.DataSource = this.nuevosPacientesBindingSource;
            this.dataGridViewListPacient.Location = new System.Drawing.Point(9, 103);
            this.dataGridViewListPacient.Name = "dataGridViewListPacient";
            this.dataGridViewListPacient.Size = new System.Drawing.Size(444, 237);
            this.dataGridViewListPacient.TabIndex = 0;
            this.dataGridViewListPacient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDNPacientesDataGridViewTextBoxColumn
            // 
            this.iDNPacientesDataGridViewTextBoxColumn.DataPropertyName = "ID_NPacientes";
            this.iDNPacientesDataGridViewTextBoxColumn.HeaderText = "ID_NPacientes";
            this.iDNPacientesDataGridViewTextBoxColumn.Name = "iDNPacientesDataGridViewTextBoxColumn";
            this.iDNPacientesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // consultaDataGridViewCheckBoxColumn
            // 
            this.consultaDataGridViewCheckBoxColumn.DataPropertyName = "Consulta";
            this.consultaDataGridViewCheckBoxColumn.HeaderText = "Consulta";
            this.consultaDataGridViewCheckBoxColumn.Name = "consultaDataGridViewCheckBoxColumn";
            // 
            // seguroDataGridViewCheckBoxColumn
            // 
            this.seguroDataGridViewCheckBoxColumn.DataPropertyName = "Seguro";
            this.seguroDataGridViewCheckBoxColumn.HeaderText = "Seguro";
            this.seguroDataGridViewCheckBoxColumn.Name = "seguroDataGridViewCheckBoxColumn";
            // 
            // tipoSeguroDataGridViewTextBoxColumn
            // 
            this.tipoSeguroDataGridViewTextBoxColumn.DataPropertyName = "TipoSeguro";
            this.tipoSeguroDataGridViewTextBoxColumn.HeaderText = "TipoSeguro";
            this.tipoSeguroDataGridViewTextBoxColumn.Name = "tipoSeguroDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // nuevosPacientesBindingSource
            // 
            this.nuevosPacientesBindingSource.DataMember = "Nuevos_Pacientes";
            this.nuevosPacientesBindingSource.DataSource = this.softPitalDataSet;
            // 
            // softPitalDataSet
            // 
            this.softPitalDataSet.DataSetName = "SoftPitalDataSet";
            this.softPitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nuevos_PacientesTableAdapter
            // 
            this.nuevos_PacientesTableAdapter.ClearBeforeFill = true;
            // 
            // BExit
            // 
            this.BExit.AutoSize = true;
            this.BExit.BackColor = System.Drawing.Color.Transparent;
            this.BExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BExit.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.BExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BExit.Location = new System.Drawing.Point(671, 7);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(27, 31);
            this.BExit.TabIndex = 54;
            this.BExit.Text = "x";
            this.BExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(352, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 31);
            this.label3.TabIndex = 53;
            this.label3.Text = "SoftPital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SplashScreen.Properties.Resources.Recurso_2_72x_8;
            this.pictureBox1.Location = new System.Drawing.Point(286, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // AtrasListPaciente
            // 
            this.AtrasListPaciente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.AtrasListPaciente.BorderRadius = 10;
            this.AtrasListPaciente.BorderThickness = 1;
            this.AtrasListPaciente.CheckedState.Parent = this.AtrasListPaciente;
            this.AtrasListPaciente.CustomImages.Parent = this.AtrasListPaciente;
            this.AtrasListPaciente.FillColor = System.Drawing.Color.White;
            this.AtrasListPaciente.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtrasListPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.AtrasListPaciente.HoverState.Parent = this.AtrasListPaciente;
            this.AtrasListPaciente.Image = global::SplashScreen.Properties.Resources.icons8_left_arrow_64;
            this.AtrasListPaciente.ImageSize = new System.Drawing.Size(25, 25);
            this.AtrasListPaciente.Location = new System.Drawing.Point(9, 8);
            this.AtrasListPaciente.Name = "AtrasListPaciente";
            this.AtrasListPaciente.ShadowDecoration.Parent = this.AtrasListPaciente;
            this.AtrasListPaciente.Size = new System.Drawing.Size(36, 33);
            this.AtrasListPaciente.TabIndex = 51;
            this.AtrasListPaciente.Click += new System.EventHandler(this.button1_Click);
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
            this.guna2GroupBox2.Location = new System.Drawing.Point(462, 165);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(236, 107);
            this.guna2GroupBox2.TabIndex = 55;
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
            // PacientesC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(707, 376);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AtrasListPaciente);
            this.Controls.Add(this.dataGridViewListPacient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PacientesC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Pacientes";
            this.Load += new System.EventHandler(this.PacientesC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListPacient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevosPacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softPitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListPacient;
        private SoftPitalDataSet softPitalDataSet;
        private System.Windows.Forms.BindingSource nuevosPacientesBindingSource;
        private SoftPitalDataSetTableAdapters.Nuevos_PacientesTableAdapter nuevos_PacientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNPacientesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn consultaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seguroDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoSeguroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label BExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button AtrasListPaciente;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button ButtonSearch;
        private Guna.UI2.WinForms.Guna2TextBox textBoxIDB;
    }
}