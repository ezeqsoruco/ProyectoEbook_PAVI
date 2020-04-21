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

namespace Ebook
{
    public partial class LoginEbook : Form
    {
        public LoginEbook()
        {
            InitializeComponent();
        }

        //Código necesario para que la venta pueda moverse
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //

        //Evento cuando el cursor está dentro del textbox
        private void txtUsuarioLogin_Enter(object sender, EventArgs e)
        {
            if (txtUsuarioLogin.Text == "USUARIO")
            {
                txtUsuarioLogin.Text = "";
                txtUsuarioLogin.ForeColor = Color.LightGray;
            }
        }

        //Evento cuando el cursor está fuera del textbox
        private void txtUsuarioLogin_Leave(object sender, EventArgs e)
        {
            if (txtUsuarioLogin.Text == "")
            {
                txtUsuarioLogin.Text = "USUARIO";
                txtUsuarioLogin.ForeColor = Color.DimGray;
            }
        }

        //Evento cuando el cursor está dentro del textbox
        private void txtContraseniaLogin_Enter(object sender, EventArgs e)
        {
            if (txtContraseniaLogin.Text == "CONTRASEÑA")
            {
                txtContraseniaLogin.Text = "";
                txtContraseniaLogin.ForeColor = Color.LightGray;
                txtContraseniaLogin.UseSystemPasswordChar = true;
            }
        }

        //Evento cuando el cursor está fuera del textbox
        private void txtContraseniaLogin_Leave(object sender, EventArgs e)
        {
            if(txtContraseniaLogin.Text == "")
            {
                txtContraseniaLogin.Text = "CONTRASEÑA";
                txtContraseniaLogin.ForeColor = Color.DimGray;
                txtContraseniaLogin.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Evento creado necesario para que la vena pueda moverse
        private void LoginEbook_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //
    }
}
