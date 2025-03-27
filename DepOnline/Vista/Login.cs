using DepOnline.Controlador;
using DepOnline.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepOnline.Vista
{
    // Objetivo: Iniciar session con el usaurio y mostar los cuartos que el tiene en renta.
    // Autor; Autor Equipo DepOnline.
    // Fecha de inicio: 12 de Noviembre del 2018.
    // Fecha de la ultima  Edicion: 15 de noviembre del 2018.
    public partial class Login : Form
    {
        private PropietarioController objPropietario = null;
        private CuartosController objCuartos = null;
        private ServiciosController objServicio = null;

        public Login()
        {
            objPropietario = new PropietarioController();
            objServicio = new ServiciosController();
            objCuartos = new CuartosController();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Diseñar los txt.
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }
        // Aqui en este metodo Realizamos el login 
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("ingrese el nombre del usuario");
                return;
            }
            string contraseña = txtContraseña.Text;
            if (txtContraseña.Text == "")
            {
                MessageBox.Show("ingrese la Contraseña");
            }
            //  int idpropietario = .txtUsuario.text;

            bool res = objPropietario.ValidarLogin(usuario, contraseña);
            if (res)
            {
                MessageBox.Show("Bienvenido a DepOnline, ustes Ingreso con el usuario : \n" + txtUsuario.Text, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            txtContraseña.Clear();
            txtUsuario.Clear();
           
            return;
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        // Validamos en los textbox.
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUsuario.TextLength>15)
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back))//inicalizamos para que no asepte otros valores 
                {
                    e.Handled = true;
                }
            }
            if(!char.IsLetter(e.KeyChar)&&!char.IsNumber(e.KeyChar)&& e.KeyChar!=Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtContraseña.TextLength>15)
            {
                if(e.KeyChar!=Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
            }
            if(!char.IsLetter(e.KeyChar)&&!char.IsNumber(e.KeyChar)&&e.KeyChar!=Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Cancelamos la operacion.
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de sistema", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK) 
            {
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PerfilView pe = new PerfilView();
            pe.Show();
            
           
            pe.btnGuardar.Visible = true;
            pe.btnGuardar.Enabled = false;
            pe.btnNuevo.Visible = true;
            pe.bunifuFlatButton1.Visible = false;
            pe.bunifuFlatButton2.Visible = true;
            this.Hide();
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("ingrese el nombre del usuario");
                return;
            }
            string contraseña = txtContraseña.Text;
            if (txtContraseña.Text == "")
            {
                MessageBox.Show("ingrese la Contraseña");
            }
            //  int idpropietario = .txtUsuario.text;

            bool res = objPropietario.ValidarLogin(usuario, contraseña);
            if (res)
            {
                MessageBox.Show("Bienvenido a DepOnline, usted Ingreso con el usuario : \n" + txtUsuario.Text, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            txtContraseña.Clear();
            txtUsuario.Clear();

            return;

        }
    }
}
