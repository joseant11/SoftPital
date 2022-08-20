using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen
{
    public partial class Soporte : Form
    {
        public Soporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoftPital MApp = new SoftPital();
            MApp.Show();
            this.Hide();
        }

        private void Soporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'medicAppDataSet2.Soporte_Request' Puede moverla o quitarla según sea necesario.
            dataGridViewSupport.DataSource = Actualizar();

        }
        public DataTable Actualizar()
        {
            SqlConnection conexion = new SqlConnection("Server=BL4CKP1TT\\BP;Database=SoftPital; integrated security = true;");
            conexion.Open();
            DataTable dt = new DataTable();
            string con = "SELECT * FROM Soporte_Request";
            SqlCommand comando = new SqlCommand(con, conexion);
            comando.ExecuteNonQuery();
            SqlDataAdapter Ada = new SqlDataAdapter(comando);
            Ada.Fill(dt);
            return dt;
        }

        private void BTEnviar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server=BL4CKP1TT\\BP;Database=SoftPital; integrated security = true;");
            conexion.Open();
            string NombreC = textBoxSupportN.Text;
            string Correo = textBoxSupportE.Text;    
            string Descrp = textBoxSupportC.Text;
            string cadena = "INSERT INTO Soporte_Request(Nombre_Completo, Correo, Descripcion) VALUES ('" + NombreC + "', '" + Correo + "', '" + Descrp + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Reporte Enviado");
            dataGridViewSupport.DataSource = Actualizar();
            textBoxSupportN.Clear();
            textBoxSupportE.Clear();
            textBoxSupportC.Clear();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server=BL4CKP1TT\\BP;Database=SoftPital; integrated security = true;");
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Nuevos_Pacientes WHERE ID_NPacientes = @ID_NPacientes", conexion);
            cmd.Parameters.AddWithValue("@ID_NPacientes", textBoxIDB.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSupport.DataSource = dt;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server=BL4CKP1TT\\BP;Database=SoftPital; integrated security = true;");
            conexion.Open();
            string eliminar = "DELETE FROM Nuevos_Pacientes WHERE ID_NPacientes = @ID_NPacientes";
            SqlCommand eliminarcmd = new SqlCommand(eliminar, conexion);
            eliminarcmd.Parameters.AddWithValue("@ID_NPacientes", textBoxIDE.Text);



            eliminarcmd.ExecuteNonQuery();

            MessageBox.Show("Datos Eliminados Correctamente");

            dataGridViewSupport.DataSource = Actualizar();
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
