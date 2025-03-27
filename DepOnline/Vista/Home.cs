using DepOnline.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepOnline.Vista
{
    // Objetivo: Es la Pantalla principal la cual es el padre de todas las vistas.
    // Autor Autor Equipo DepOnline.
    // Fecha de inicio: 27 de noviembre del 2018.
    // Fecha de la ultima  Edicion: 13 enero del 2019.
    public partial class Home : Form
    {
        public Home()
        {
            
            InitializeComponent();
            // Para cargar el nombre en el inicio.
            name.Text = Propietario.Nombrep;
            
        }
        // Para poder mover la ventana.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnv, int wmsg, int wparam, int lparam);

        private void btnside_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }
        // Creacion de las variables para mandar a llamar las vistas hijas.
        public void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelcontenedor.Controls.Count > 0)

                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();

        }


      

        private void btnCuarto_Click(object sender, EventArgs e)
        {
           
            AbrirFormInPanel(new CuartogeneralView());
            
           
        }

        private void btnImagenes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ImagenesView());
            mostrarPanel(false);
            
        }

      

        private void panelcontenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void barratitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de sistema", "Alerta", MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mostrarPanel(bool valor)
        {
          
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //Cuarto view = new Cuarto();
            //AbrirFormInPanel(view);
        }

        private void btnDisponible_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new PerfilView());
            mostrarPanel(false);
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new PerfilView());
            mostrarPanel(false);
            
        }

     

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ImagenesView());
            mostrarPanel(false);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
           
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Reportecua  ());
            mostrarPanel(false);
          //panel1.Visible = true;
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barratitulo_Paint(object sender, PaintEventArgs e)
        {

        }


        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pnlSubmenu.Visible = true;
          
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente Desea salir de DepOnline","Advertencia...",MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question)==DialogResult.OK)
            {

                Application.Exit();
            }
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new PerfilView());
            mostrarPanel(false);
        }

       

        

        private void btnCuartotal_Click(object sender, EventArgs e)
        {
            pnlSubmenu.Visible = false;
            MessageBox.Show("Aqui usted puede Realizar un reporte de todos los cuartos que tiene en Renta","Información",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
            AbrirFormInPanel(new Reportecua());
            mostrarPanel(false);
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            pnlSubmenu.Visible = false;
           MessageBox.Show("Aqui usted puede Realizar un reporte de los cuartos que tiene Disponible", "Información",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            AbrirFormInPanel(new CuartosDisponible());
            mostrarPanel(false);
        }

        private void btnnodis_Click(object sender, EventArgs e)
        {
            pnlSubmenu.Visible = false;
            MessageBox.Show("Aqui usted puede Realizar un reporte de todos los cuartos que Estan Ocuapados", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            AbrirFormInPanel(new Cuartosnodisponible());
            mostrarPanel(false);
        }

        private void btnCuarto_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            AbrirFormInPanel(new CuartogeneralView());
            mostrarPanel(false);
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Ayuda());
            mostrarPanel(false);
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void name_Click(object sender, EventArgs e)
        {
            pnlper.Visible = true;
        }

        public void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEditarper_Click(object sender, EventArgs e)
        {
            pnlper.Visible = false;
            AbrirFormInPanel(new PerfilView());
            mostrarPanel(false);

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            pnlper.Visible = true;
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            pnlper.Visible = false;
            AbrirFormInPanel(new PerfilView());
            mostrarPanel(false);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            pnlper.Visible = false;
            if (MessageBox.Show("¿Desea cerrar sessión?", "Alerta", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                this.Hide();
                Login lg = new Login();
                lg.Show();
            }
        }

        private void Panelcontenedor_Paint(object sender, PaintEventArgs e) {

        }
    }
}
