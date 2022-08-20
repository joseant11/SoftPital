namespace SplashScreen
{
    partial class NuevoP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoP));
            this.label4 = new System.Windows.Forms.Label();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkBoxConsulta = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkBoxSeguro = new Guna.UI2.WinForms.Guna2CheckBox();
            this.comboBoxSeguro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.softPitalDataSet = new SplashScreen.SoftPitalDataSet();
            this.softPitalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ButtonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxIDB = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonAtrasAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BExit = new System.Windows.Forms.Label();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.textBoxIDE = new Guna.UI2.WinForms.Guna2TextBox();
            this.nuevosPacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nuevos_PacientesTableAdapter = new SplashScreen.SoftPitalDataSetTableAdapters.Nuevos_PacientesTableAdapter();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoSeguroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seguroDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.consultaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNPacientesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.softPitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softPitalDataSetBindingSource)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuevosPacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(275, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de Seguro:";
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(13, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Adjuntar Imagen";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.White;
            this.textBoxNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBoxNombre.BorderRadius = 10;
            this.textBoxNombre.BorderThickness = 2;
            this.textBoxNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNombre.DefaultText = "";
            this.textBoxNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNombre.DisabledState.Parent = this.textBoxNombre;
            this.textBoxNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNombre.FocusedState.Parent = this.textBoxNombre;
            this.textBoxNombre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNombre.HoverState.Parent = this.textBoxNombre;
            this.textBoxNombre.Location = new System.Drawing.Point(16, 40);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.PasswordChar = '\0';
            this.textBoxNombre.PlaceholderText = "Nombres";
            this.textBoxNombre.SelectedText = "";
            this.textBoxNombre.ShadowDecoration.Parent = this.textBoxNombre;
            this.textBoxNombre.Size = new System.Drawing.Size(183, 42);
            this.textBoxNombre.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textBoxNombre.TabIndex = 33;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.BackColor = System.Drawing.Color.White;
            this.textBoxApellido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBoxApellido.BorderRadius = 10;
            this.textBoxApellido.BorderThickness = 2;
            this.textBoxApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxApellido.DefaultText = "";
            this.textBoxApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxApellido.DisabledState.Parent = this.textBoxApellido;
            this.textBoxApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxApellido.FocusedState.Parent = this.textBoxApellido;
            this.textBoxApellido.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxApellido.HoverState.Parent = this.textBoxApellido;
            this.textBoxApellido.Location = new System.Drawing.Point(207, 40);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.PasswordChar = '\0';
            this.textBoxApellido.PlaceholderText = "Apellidos";
            this.textBoxApellido.SelectedText = "";
            this.textBoxApellido.ShadowDecoration.Parent = this.textBoxApellido;
            this.textBoxApellido.Size = new System.Drawing.Size(183, 42);
            this.textBoxApellido.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textBoxApellido.TabIndex = 34;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.BackColor = System.Drawing.Color.White;
            this.textBoxCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBoxCorreo.BorderRadius = 10;
            this.textBoxCorreo.BorderThickness = 2;
            this.textBoxCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCorreo.DefaultText = "";
            this.textBoxCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCorreo.DisabledState.Parent = this.textBoxCorreo;
            this.textBoxCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCorreo.FocusedState.Parent = this.textBoxCorreo;
            this.textBoxCorreo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCorreo.HoverState.Parent = this.textBoxCorreo;
            this.textBoxCorreo.Location = new System.Drawing.Point(16, 88);
            this.textBoxCorreo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.PasswordChar = '\0';
            this.textBoxCorreo.PlaceholderText = "Email";
            this.textBoxCorreo.SelectedText = "";
            this.textBoxCorreo.ShadowDecoration.Parent = this.textBoxCorreo;
            this.textBoxCorreo.Size = new System.Drawing.Size(183, 42);
            this.textBoxCorreo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textBoxCorreo.TabIndex = 35;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.BackColor = System.Drawing.Color.White;
            this.textBoxTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBoxTelefono.BorderRadius = 10;
            this.textBoxTelefono.BorderThickness = 2;
            this.textBoxTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTelefono.DefaultText = "";
            this.textBoxTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTelefono.DisabledState.Parent = this.textBoxTelefono;
            this.textBoxTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTelefono.FocusedState.Parent = this.textBoxTelefono;
            this.textBoxTelefono.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTelefono.HoverState.Parent = this.textBoxTelefono;
            this.textBoxTelefono.Location = new System.Drawing.Point(207, 88);
            this.textBoxTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.PasswordChar = '\0';
            this.textBoxTelefono.PlaceholderText = "Telefono";
            this.textBoxTelefono.SelectedText = "";
            this.textBoxTelefono.ShadowDecoration.Parent = this.textBoxTelefono;
            this.textBoxTelefono.Size = new System.Drawing.Size(183, 42);
            this.textBoxTelefono.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textBoxTelefono.TabIndex = 36;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.BackColor = System.Drawing.Color.White;
            this.textBoxDireccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBoxDireccion.BorderRadius = 10;
            this.textBoxDireccion.BorderThickness = 2;
            this.textBoxDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDireccion.DefaultText = "";
            this.textBoxDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDireccion.DisabledState.Parent = this.textBoxDireccion;
            this.textBoxDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDireccion.FocusedState.Parent = this.textBoxDireccion;
            this.textBoxDireccion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDireccion.HoverState.Parent = this.textBoxDireccion;
            this.textBoxDireccion.Location = new System.Drawing.Point(16, 136);
            this.textBoxDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.PasswordChar = '\0';
            this.textBoxDireccion.PlaceholderText = "Direccion";
            this.textBoxDireccion.SelectedText = "";
            this.textBoxDireccion.ShadowDecoration.Parent = this.textBoxDireccion;
            this.textBoxDireccion.Size = new System.Drawing.Size(374, 42);
            this.textBoxDireccion.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textBoxDireccion.TabIndex = 37;
            // 
            // checkBoxConsulta
            // 
            this.checkBoxConsulta.AutoSize = true;
            this.checkBoxConsulta.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxConsulta.CheckedState.BorderRadius = 2;
            this.checkBoxConsulta.CheckedState.BorderThickness = 0;
            this.checkBoxConsulta.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxConsulta.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkBoxConsulta.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxConsulta.Location = new System.Drawing.Point(245, 200);
            this.checkBoxConsulta.Name = "checkBoxConsulta";
            this.checkBoxConsulta.Size = new System.Drawing.Size(71, 19);
            this.checkBoxConsulta.TabIndex = 38;
            this.checkBoxConsulta.Text = "Consula";
            this.checkBoxConsulta.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxConsulta.UncheckedState.BorderRadius = 2;
            this.checkBoxConsulta.UncheckedState.BorderThickness = 0;
            this.checkBoxConsulta.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxConsulta.UseVisualStyleBackColor = true;
            // 
            // checkBoxSeguro
            // 
            this.checkBoxSeguro.AutoSize = true;
            this.checkBoxSeguro.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxSeguro.CheckedState.BorderRadius = 2;
            this.checkBoxSeguro.CheckedState.BorderThickness = 0;
            this.checkBoxSeguro.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxSeguro.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkBoxSeguro.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxSeguro.Location = new System.Drawing.Point(328, 200);
            this.checkBoxSeguro.Name = "checkBoxSeguro";
            this.checkBoxSeguro.Size = new System.Drawing.Size(66, 19);
            this.checkBoxSeguro.TabIndex = 39;
            this.checkBoxSeguro.Text = "Seguro";
            this.checkBoxSeguro.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxSeguro.UncheckedState.BorderRadius = 2;
            this.checkBoxSeguro.UncheckedState.BorderThickness = 0;
            this.checkBoxSeguro.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxSeguro.UseVisualStyleBackColor = true;
            // 
            // comboBoxSeguro
            // 
            this.comboBoxSeguro.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxSeguro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.comboBoxSeguro.BorderThickness = 2;
            this.comboBoxSeguro.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.softPitalDataSet, "Nuevos_Pacientes.TipoSeguro", true));
            this.comboBoxSeguro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSeguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeguro.FocusedColor = System.Drawing.Color.Empty;
            this.comboBoxSeguro.FocusedState.Parent = this.comboBoxSeguro;
            this.comboBoxSeguro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSeguro.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBoxSeguro.FormattingEnabled = true;
            this.comboBoxSeguro.HoverState.Parent = this.comboBoxSeguro;
            this.comboBoxSeguro.ItemHeight = 30;
            this.comboBoxSeguro.Items.AddRange(new object[] {
            "Primera ARS de Humano",
            "Mapfre Salud ARS",
            "ARS Universal",
            "ARS SIMAG",
            "ARS Yunen ",
            "ARS Monumental"});
            this.comboBoxSeguro.ItemsAppearance.Parent = this.comboBoxSeguro;
            this.comboBoxSeguro.Location = new System.Drawing.Point(245, 251);
            this.comboBoxSeguro.Name = "comboBoxSeguro";
            this.comboBoxSeguro.ShadowDecoration.Parent = this.comboBoxSeguro;
            this.comboBoxSeguro.Size = new System.Drawing.Size(151, 36);
            this.comboBoxSeguro.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.comboBoxSeguro.TabIndex = 40;
            this.comboBoxSeguro.Tag = "";
            // 
            // softPitalDataSet
            // 
            this.softPitalDataSet.DataSetName = "SoftPitalDataSet";
            this.softPitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // softPitalDataSetBindingSource
            // 
            this.softPitalDataSetBindingSource.DataSource = this.softPitalDataSet;
            this.softPitalDataSetBindingSource.Position = 0;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Location = new System.Drawing.Point(16, 220);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(99, 67);
            this.guna2ImageButton1.TabIndex = 41;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 5;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.checkBoxSeguro);
            this.guna2GroupBox1.Controls.Add(this.textBoxNombre);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton1);
            this.guna2GroupBox1.Controls.Add(this.checkBoxConsulta);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.comboBoxSeguro);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.textBoxApellido);
            this.guna2GroupBox1.Controls.Add(this.textBoxCorreo);
            this.guna2GroupBox1.Controls.Add(this.textBoxDireccion);
            this.guna2GroupBox1.Controls.Add(this.textBoxTelefono);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(9, 99);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(418, 309);
            this.guna2GroupBox1.TabIndex = 42;
            this.guna2GroupBox1.Text = "Insertar Paciente";
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
            this.guna2GroupBox2.Location = new System.Drawing.Point(460, 99);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(236, 107);
            this.guna2GroupBox2.TabIndex = 43;
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
            this.ButtonSearch.Click += new System.EventHandler(this.button4_Click);
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
            this.buttonAtrasAddUser.Location = new System.Drawing.Point(12, 12);
            this.buttonAtrasAddUser.Name = "buttonAtrasAddUser";
            this.buttonAtrasAddUser.ShadowDecoration.Parent = this.buttonAtrasAddUser;
            this.buttonAtrasAddUser.Size = new System.Drawing.Size(36, 33);
            this.buttonAtrasAddUser.TabIndex = 43;
            this.buttonAtrasAddUser.Click += new System.EventHandler(this.button5_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ButtonAdd.BorderRadius = 10;
            this.ButtonAdd.BorderThickness = 1;
            this.ButtonAdd.CheckedState.Parent = this.ButtonAdd;
            this.ButtonAdd.CustomImages.Parent = this.ButtonAdd;
            this.ButtonAdd.FillColor = System.Drawing.Color.White;
            this.ButtonAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ButtonAdd.HoverState.Parent = this.ButtonAdd;
            this.ButtonAdd.Image = global::SplashScreen.Properties.Resources.icons8_add_64;
            this.ButtonAdd.ImageSize = new System.Drawing.Size(25, 25);
            this.ButtonAdd.Location = new System.Drawing.Point(460, 350);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.ShadowDecoration.Parent = this.ButtonAdd;
            this.ButtonAdd.Size = new System.Drawing.Size(236, 57);
            this.ButtonAdd.TabIndex = 45;
            this.ButtonAdd.Text = "Agregar";
            this.ButtonAdd.Click += new System.EventHandler(this.button1_Click);
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
            this.ButtonDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(342, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 31);
            this.label3.TabIndex = 49;
            this.label3.Text = "SoftPital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SplashScreen.Properties.Resources.Recurso_2_72x_8;
            this.pictureBox1.Location = new System.Drawing.Point(276, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // BExit
            // 
            this.BExit.AutoSize = true;
            this.BExit.BackColor = System.Drawing.Color.Transparent;
            this.BExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BExit.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.BExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BExit.Location = new System.Drawing.Point(680, 3);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(27, 31);
            this.BExit.TabIndex = 50;
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
            this.guna2GroupBox3.Location = new System.Drawing.Point(460, 220);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
            this.guna2GroupBox3.Size = new System.Drawing.Size(236, 107);
            this.guna2GroupBox3.TabIndex = 45;
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
            // nuevosPacientesBindingSource
            // 
            this.nuevosPacientesBindingSource.DataMember = "Nuevos_Pacientes";
            this.nuevosPacientesBindingSource.DataSource = this.softPitalDataSetBindingSource;
            // 
            // nuevos_PacientesTableAdapter
            // 
            this.nuevos_PacientesTableAdapter.ClearBeforeFill = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // tipoSeguroDataGridViewTextBoxColumn
            // 
            this.tipoSeguroDataGridViewTextBoxColumn.DataPropertyName = "TipoSeguro";
            this.tipoSeguroDataGridViewTextBoxColumn.HeaderText = "TipoSeguro";
            this.tipoSeguroDataGridViewTextBoxColumn.Name = "tipoSeguroDataGridViewTextBoxColumn";
            // 
            // seguroDataGridViewCheckBoxColumn
            // 
            this.seguroDataGridViewCheckBoxColumn.DataPropertyName = "Seguro";
            this.seguroDataGridViewCheckBoxColumn.HeaderText = "Seguro";
            this.seguroDataGridViewCheckBoxColumn.Name = "seguroDataGridViewCheckBoxColumn";
            // 
            // consultaDataGridViewCheckBoxColumn
            // 
            this.consultaDataGridViewCheckBoxColumn.DataPropertyName = "Consulta";
            this.consultaDataGridViewCheckBoxColumn.HeaderText = "Consulta";
            this.consultaDataGridViewCheckBoxColumn.Name = "consultaDataGridViewCheckBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            // 
            // iDNPacientesDataGridViewTextBoxColumn
            // 
            this.iDNPacientesDataGridViewTextBoxColumn.DataPropertyName = "ID_NPacientes";
            this.iDNPacientesDataGridViewTextBoxColumn.HeaderText = "ID_NPacientes";
            this.iDNPacientesDataGridViewTextBoxColumn.Name = "iDNPacientesDataGridViewTextBoxColumn";
            this.iDNPacientesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AutoGenerateColumns = false;
            this.dataGridViewUser.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDNPacientesDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.consultaDataGridViewCheckBoxColumn,
            this.seguroDataGridViewCheckBoxColumn,
            this.tipoSeguroDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.dataGridViewUser.DataSource = this.nuevosPacientesBindingSource;
            this.dataGridViewUser.Location = new System.Drawing.Point(9, 414);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.Size = new System.Drawing.Size(687, 145);
            this.dataGridViewUser.TabIndex = 42;
            this.dataGridViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NuevoP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 571);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.buttonAtrasAddUser);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoP";
            this.Load += new System.EventHandler(this.NuevoP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.softPitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softPitalDataSetBindingSource)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nuevosPacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox textBoxNombre;
        private Guna.UI2.WinForms.Guna2TextBox textBoxApellido;
        private Guna.UI2.WinForms.Guna2TextBox textBoxCorreo;
        private Guna.UI2.WinForms.Guna2TextBox textBoxTelefono;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDireccion;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxConsulta;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxSeguro;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxSeguro;
        private SoftPitalDataSet softPitalDataSet;
        private System.Windows.Forms.BindingSource softPitalDataSetBindingSource;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button buttonAtrasAddUser;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2TextBox textBoxIDB;
        private Guna.UI2.WinForms.Guna2Button ButtonSearch;
        private Guna.UI2.WinForms.Guna2Button ButtonAdd;
        private Guna.UI2.WinForms.Guna2Button ButtonDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BExit;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2TextBox textBoxIDE;
        private System.Windows.Forms.BindingSource nuevosPacientesBindingSource;
        private SoftPitalDataSetTableAdapters.Nuevos_PacientesTableAdapter nuevos_PacientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoSeguroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seguroDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn consultaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNPacientesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewUser;
    }
}