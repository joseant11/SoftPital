using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SplashScreen
{
    public partial class NuevoP : Form
    {
        public NuevoP()
        {
            InitializeComponent();
        }

        
        private void NuevoP_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'softPitalDataSet.Nuevos_Pacientes' Puede moverla o quitarla según sea necesario.
            this.nuevos_PacientesTableAdapter.Fill(this.softPitalDataSet.Nuevos_Pacientes);

            dataGridViewUser.DataSource = Actualizar();

        }

        public DataTable Actualizar() 
        {
            SqlConnection conexion = new SqlConnection("Server=BL4CKP1TT\\BP;Database=SoftPital; integrated security = true;");
            conexion.Open();
            DataTable dt = new DataTable();
            string con = "SELECT * FROM Nuevos_Pacientes";
            SqlCommand comando = new SqlCommand(con, conexion);
            comando.ExecuteNonQuery();
            SqlDataAdapter Ada = new SqlDataAdapter(comando);
            Ada.Fill(dt);
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server=BL4CKP1TT\\BP;Database=SoftPital; integrated security = true;");
            conexion.Open();
            string Nombres = textBoxNombre.Text;
            string Apellidos = textBoxApellido.Text;
            bool Consulta = checkBoxConsulta.Checked;
            bool Seguro = checkBoxSeguro.Checked;
            string TipoSeguro = comboBoxSeguro.Text;
            string Correo = textBoxCorreo.Text;
            string Telefono = textBoxTelefono.Text;
            string Direccion = textBoxDireccion.Text;
            string cadena = "INSERT INTO Nuevos_Pacientes (Nombres, Apellidos, Consulta, Seguro, TipoSeguro, Correo, Telefono, Direccion) VALUES ('" + Nombres + "', '" + Apellidos + "', '" + Consulta + "', '" + Seguro + "', '" + Correo + "', '" + TipoSeguro + "', '" + Telefono + "', '" + Direccion + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Datos Agregado");
            dataGridViewUser.DataSource = Actualizar();
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxCorreo.Clear();
            textBoxDireccion.Clear(); 
            textBoxTelefono.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server=BL4CKP1TT\\BP;Database=SoftPital; integrated security = true;");
            conexion.Open();
            string eliminar = "DELETE FROM Nuevos_Pacientes WHERE ID_NPacientes = @ID_NPacientes";
            SqlCommand eliminarcmd = new SqlCommand(eliminar, conexion);
            eliminarcmd.Parameters.AddWithValue("@ID_NPacientes", textBoxIDE.Text);



            eliminarcmd.ExecuteNonQuery();

            MessageBox.Show("Datos Eliminados Correctamente");

            dataGridViewUser.DataSource = Actualizar();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                textBoxIDE.Text = dataGridViewUser.CurrentRow.Cells[0].Value.ToString();

            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SoftPital MApp = new SoftPital();
            MApp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server=BL4CKP1TT\\BP;Database=SoftPital; integrated security = true;");
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Nuevos_Pacientes WHERE ID_NPacientes = @ID_NPacientes", conexion);
            cmd.Parameters.AddWithValue("@ID_NPacientes", textBoxIDB.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewUser.DataSource = dt;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    String img = OpenFile.FileName;
                    guna2ImageButton1.Image = Image.FromFile(img);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo seleccionado no es valido");
            }
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

