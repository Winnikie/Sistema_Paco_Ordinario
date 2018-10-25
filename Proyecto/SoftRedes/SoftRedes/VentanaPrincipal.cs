using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SoftRedes
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void IconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconoMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconoMinimizarTam.Visible = true;
            IconoMaximizar.Visible = false;
        }
        private void IconoMinimizarTam_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconoMinimizarTam.Visible = false;
            IconoMaximizar.Visible = true;
        }
        private void IconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirVentana (object formhijo)
        {
            if (PanelContenedor.Controls.Count == 0)
            {
                AjustarMenu();
                Form fh = formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.PanelContenedor.Controls.Add(fh);
                this.PanelContenedor.Tag = fh;
                fh.Show();
            }
            else
                MessageBox.Show("Ya hay una ventana abierta");
                
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Usuarios());

            // AbrirVentana(new fUsuarios());
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            AjustarMenu();
        }
        public void AjustarMenu()
        {
            if (MenuVertical.Width == 246)
                MenuVertical.Width = 67;
            else
                MenuVertical.Width = 246;
        }
    }
}
