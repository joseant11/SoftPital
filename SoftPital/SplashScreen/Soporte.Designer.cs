namespace SplashScreen
{
    partial class Soporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Soporte));
            this.dataGridViewSupport = new System.Windows.Forms.DataGridView();
            this.iDSoporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soporteRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softPitalDataSet2 = new SplashScreen.SoftPitalDataSet2();
            this.soporte_RequestTableAdapter = new SplashScreen.SoftPitalDataSet2TableAdapters.Soporte_RequestTableAdapter();
            this.BExit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GroupBoxSupport = new Guna.UI2.WinForms.Guna2GroupBox();
            this.textBoxSupportN = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxSupportE = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxSupportC = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.textBoxIDE = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ButtonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxIDB = new Guna.UI2.WinForms.Guna2TextBox();
            this.BTEnviar = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAtrasAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.Atras5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soporteRequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softPitalDataSet2)).BeginInit();
            this.GroupBoxSupport.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSupport
            // 
            this.dataGridViewSupport.AutoGenerateColumns = false;
            this.dataGridViewSupport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSupport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSoporteDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dataGridViewSupport.DataSource = this.soporteRequestBindingSource;
            this.dataGridViewSupport.Location = new System.Drawing.Point(12, 364);
            this.dataGridViewSupport.Name = "dataGridViewSupport";
            this.dataGridViewSupport.Size = new System.Drawing.Size(450, 96);
            this.dataGridViewSupport.TabIndex = 10;
            // 
            // iDSoporteDataGridViewTextBoxColumn
            // 
            this.iDSoporteDataGridViewTextBoxColumn.DataPropertyName = "ID_Soporte";
            this.iDSoporteDataGridViewTextBoxColumn.HeaderText = "ID_Soporte";
            this.iDSoporteDataGridViewTextBoxColumn.Name = "iDSoporteDataGridViewTextBoxColumn";
            this.iDSoporteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Completo";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre_Completo";
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // soporteRequestBindingSource
            // 
            this.soporteRequestBindingSource.DataMember = "Soporte_Request";
            this.soporteRequestBindingSource.DataSource = this.softPitalDataSet2;
            // 
            // softPitalDataSet2
            // 
            this.softPitalDataSet2.DataSetName = "SoftPitalDataSet2";
            this.softPitalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soporte_RequestTableAdapter
            // 
            this.soporte_RequestTableAdapter.ClearBeforeFill = true;
            // 
            // BExit
            // 
            this.BExit.AutoSize = true;
            this.BExit.BackColor = System.Drawing.Color.Transparent;
            this.BExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BExit.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.BExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BExit.Location = new System.Drawing.Point(675, 9);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(27, 31);
            this.BExit.TabIndex = 55;
            this.BExit.Text = "x";
            this.BExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(336, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 31);
            this.label4.TabIndex = 54;
            this.label4.Text = "SoftPital";
            // 
            // GroupBoxSupport
            // 
            this.GroupBoxSupport.BorderRadius = 5;
            this.GroupBoxSupport.BorderThickness = 2;
            this.GroupBoxSupport.Controls.Add(this.textBoxSupportN);
            this.GroupBoxSupport.Controls.Add(this.textBoxSupportE);
            this.GroupBoxSupport.Controls.Add(this.textBoxSupportC);
            this.GroupBoxSupport.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.GroupBoxSupport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.GroupBoxSupport.ForeColor = System.Drawing.Color.White;
            this.GroupBoxSupport.Location = new System.Drawing.Point(12, 106);
            this.GroupBoxSupport.Name = "GroupBoxSupport";
            this.GroupBoxSupport.ShadowDecoration.Parent = this.GroupBoxSupport;
            this.GroupBoxSupport.Size = new System.Drawing.Size(450, 252);
            this.GroupBoxSupport.TabIndex = 51;
            this.GroupBoxSupport.Text = "Soporte";
            // 
            // textBoxSupportN
            // 
            this.textBoxSupportN.BackColor = System.Drawing.Color.White;
            this.textBoxSupportN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBoxSupportN.BorderRadius = 10;
            this.textBoxSupportN.BorderThickness = 2;
            this.textBoxSupportN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSupportN.DefaultText = "";
            this.textBoxSupportN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSupportN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSupportN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSupportN.DisabledState.Parent = this.textBoxSupportN;
            this.textBoxSupportN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSupportN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSupportN.FocusedState.Parent = this.textBoxSupportN;
            this.textBoxSupportN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupportN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSupportN.HoverState.Parent = this.textBoxSupportN;
            this.textBoxSupportN.Location = new System.Drawing.Point(41, 51);
            this.textBoxSupportN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSupportN.Name = "textBoxSupportN";
            this.textBoxSupportN.PasswordChar = '\0';
            this.textBoxSupportN.PlaceholderText = "Nombres Completo";
            this.textBoxSupportN.SelectedText = "";
            this.textBoxSupportN.ShadowDecoration.Parent = this.textBoxSupportN;
            this.textBoxSupportN.Size = new System.Drawing.Size(183, 42);
            this.textBoxSupportN.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textBoxSupportN.TabIndex = 33;
            // 
            // textBoxSupportE
            // 
            this.textBoxSupportE.BackColor = System.Drawing.Color.White;
            this.textBoxSupportE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBoxSupportE.BorderRadius = 10;
            this.textBoxSupportE.BorderThickness = 2;
            this.textBoxSupportE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSupportE.DefaultText = "";
            this.textBoxSupportE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSupportE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSupportE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSupportE.DisabledState.Parent = this.textBoxSupportE;
            this.textBoxSupportE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSupportE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSupportE.FocusedState.Parent = this.textBoxSupportE;
            this.textBoxSupportE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupportE.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSupportE.HoverState.Parent = this.textBoxSupportE;
            this.textBoxSupportE.Location = new System.Drawing.Point(232, 51);
            this.textBoxSupportE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSupportE.Name = "textBoxSupportE";
            this.textBoxSupportE.PasswordChar = '\0';
            this.textBoxSupportE.PlaceholderText = "Email";
            this.textBoxSupportE.SelectedText = "";
            this.textBoxSupportE.ShadowDecoration.Parent = this.textBoxSupportE;
            this.textBoxSupportE.Size = new System.Drawing.Size(183, 42);
            this.textBoxSupportE.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textBoxSupportE.TabIndex = 35;
            // 
            // textBoxSupportC
            // 
            this.textBoxSupportC.BackColor = System.Drawing.Color.White;
            this.textBoxSupportC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBoxSupportC.BorderRadius = 10;
            this.textBoxSupportC.BorderThickness = 2;
            this.textBoxSupportC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSupportC.DefaultText = "";
            this.textBoxSupportC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSupportC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSupportC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSupportC.DisabledState.Parent = this.textBoxSupportC;
            this.textBoxSupportC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSupportC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSupportC.FocusedState.Parent = this.textBoxSupportC;
            this.textBoxSupportC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupportC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSupportC.HoverState.Parent = this.textBoxSupportC;
            this.textBoxSupportC.Location = new System.Drawing.Point(41, 99);
            this.textBoxSupportC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSupportC.Name = "textBoxSupportC";
            this.textBoxSupportC.PasswordChar = '\0';
            this.textBoxSupportC.PlaceholderText = "Direccion";
            this.textBoxSupportC.SelectedText = "";
            this.textBoxSupportC.ShadowDecoration.Parent = this.textBoxSupportC;
            this.textBoxSupportC.Size = new System.Drawing.Size(374, 134);
            this.textBoxSupportC.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textBoxSupportC.TabIndex = 37;
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
            this.guna2GroupBox3.Location = new System.Drawing.Point(468, 239);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
            this.guna2GroupBox3.Size = new System.Drawing.Size(236, 107);
            this.guna2GroupBox3.TabIndex = 58;
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
            this.guna2GroupBox2.Location = new System.Drawing.Point(468, 106);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(236, 107);
            this.guna2GroupBox2.TabIndex = 56;
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
            // BTEnviar
            // 
            this.BTEnviar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BTEnviar.BorderRadius = 10;
            this.BTEnviar.BorderThickness = 1;
            this.BTEnviar.CheckedState.Parent = this.BTEnviar;
            this.BTEnviar.CustomImages.Parent = this.BTEnviar;
            this.BTEnviar.FillColor = System.Drawing.Color.White;
            this.BTEnviar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BTEnviar.HoverState.Parent = this.BTEnviar;
            this.BTEnviar.Image = global::SplashScreen.Properties.Resources.icons8_send_32;
            this.BTEnviar.ImageSize = new System.Drawing.Size(25, 25);
            this.BTEnviar.Location = new System.Drawing.Point(468, 379);
            this.BTEnviar.Name = "BTEnviar";
            this.BTEnviar.ShadowDecoration.Parent = this.BTEnviar;
            this.BTEnviar.Size = new System.Drawing.Size(236, 57);
            this.BTEnviar.TabIndex = 57;
            this.BTEnviar.Text = "Enviar";
            this.BTEnviar.Click += new System.EventHandler(this.BTEnviar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SplashScreen.Properties.Resources.Recurso_2_72x_8;
            this.pictureBox1.Location = new System.Drawing.Point(270, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
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
            this.buttonAtrasAddUser.Location = new System.Drawing.Point(15, 19);
            this.buttonAtrasAddUser.Name = "buttonAtrasAddUser";
            this.buttonAtrasAddUser.ShadowDecoration.Parent = this.buttonAtrasAddUser;
            this.buttonAtrasAddUser.Size = new System.Drawing.Size(36, 33);
            this.buttonAtrasAddUser.TabIndex = 52;
            // 
            // Atras5
            // 
            this.Atras5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Atras5.BackgroundImage")));
            this.Atras5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Atras5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Atras5.Location = new System.Drawing.Point(942, 2);
            this.Atras5.Name = "Atras5";
            this.Atras5.Size = new System.Drawing.Size(37, 30);
            this.Atras5.TabIndex = 2;
            this.Atras5.UseVisualStyleBackColor = true;
            this.Atras5.Click += new System.EventHandler(this.button1_Click);
            // 
            // Soporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(714, 489);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.BTEnviar);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAtrasAddUser);
            this.Controls.Add(this.GroupBoxSupport);
            this.Controls.Add(this.dataGridViewSupport);
            this.Controls.Add(this.Atras5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Soporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soporte";
            this.Load += new System.EventHandler(this.Soporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soporteRequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softPitalDataSet2)).EndInit();
            this.GroupBoxSupport.ResumeLayout(false);
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Atras5;
        private System.Windows.Forms.DataGridView dataGridViewSupport;
        private SoftPitalDataSet2 softPitalDataSet2;
        private System.Windows.Forms.BindingSource soporteRequestBindingSource;
        private SoftPitalDataSet2TableAdapters.Soporte_RequestTableAdapter soporte_RequestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSoporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label BExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button buttonAtrasAddUser;
        private Guna.UI2.WinForms.Guna2GroupBox GroupBoxSupport;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSupportN;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSupportE;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSupportC;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2TextBox textBoxIDE;
        private Guna.UI2.WinForms.Guna2Button ButtonDelete;
        private Guna.UI2.WinForms.Guna2Button BTEnviar;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button ButtonSearch;
        private Guna.UI2.WinForms.Guna2TextBox textBoxIDB;
    }
}