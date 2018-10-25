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

namespace SoftRedes
{
    public partial class Login : Form
    {
        SqlCommand comando = new SqlCommand();
        ConexionSQL conexion = new ConexionSQL();
        VentanaPrincipal abrir = new VentanaPrincipal();
        public Login()
        {
            InitializeComponent();
        }

        private void IconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="USUARIO")
                txtUsuario.Text = "";
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
                txtUsuario.Text = "USUARIO";
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Logear();
        }
        public void Logear()
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "stpLogin ";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@cUsuario", txtUsuario.Text);
                comando.Parameters.AddWithValue("@cContraseña", txtContraseña.Text);
                SqlDataAdapter sda = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                sda.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    //MessageBox.Show("LISTO");
                    abrir.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Usuario o contraseña invalidos, intente con otro usuario");
                comando.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }






        }
    }
}
