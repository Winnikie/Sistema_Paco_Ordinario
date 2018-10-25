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
using System.Data;

namespace SoftRedes
{
    public partial class Usuarios : Form
    {

        ConexionSQL conexion = new ConexionSQL();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }
        private void MostrarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = Mostrar();
        }
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "stpLeerUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.NomUsuario = txtNombreUsuario.Text;
            u.DireccionUsuario = txtDireccionUsuario.Text;
            u.CorreoUsuario = txtCorreoUsuario.Text;
            u.TelefonoUsuario = txtTelefonoUsuario.Text;
            u.FechaNacUsuario = Convert.ToDateTime(dtpFechaNacUsuario.Text);
            u.AliasUsuario = txtAliasUsuario.Text;
            u.ContraseñaUsuario = txtContraseñaUsuario.Text;
            GuardarUsuario(u);
            MostrarUsuarios();
            
        }
        public void GuardarUsuario(Usuario u)
        {
            Insertar(u);
        }
        public void Insertar(Usuario u)
        {
            //PROCEDIMNIENTO

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "stpCrearUsuario ";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreUsuario", u.NomUsuario);
            comando.Parameters.AddWithValue("@CorreoUsuario", u.CorreoUsuario);
            comando.Parameters.AddWithValue("@DireccionUsuario", u.DireccionUsuario);
            comando.Parameters.AddWithValue("@TelefonoUsuario", u.TelefonoUsuario);            
            comando.Parameters.AddWithValue("@FechaNacimiento", u.FechaNacUsuario);
            comando.Parameters.AddWithValue("@AliasUsuario", u.AliasUsuario);
            comando.Parameters.AddWithValue("@ContraseñaUsuario", u.ContraseñaUsuario);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

            comando.Parameters.Clear();

        }

        private void txtCorreoUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
