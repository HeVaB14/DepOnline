using DepOnline.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DepOnline.Modelo;
using DepOnline.Vista;

namespace DepOnline.Vista
{
    // Objetivo: mostrar Los datos de los propietarios.
    // Autor Brayan Hernandez Vazquez
    // Fecha de inicio 
    // Fecha de la ultima  Edicion:
    public partial class PerfilView : Form
    {
        //  Aqui llamamos el controlador para utilizar los datos que se guarda las clases.
        private PropietarioController objpropietario = null;
        Home home = new Home();
        public PerfilView()
        
        {
            InitializeComponent();
          
            objpropietario = new PropietarioController();
           // Aqui igualamos Cada uno de los Datos Correspondietes para que se muestre en la interfaz. 
            txtNombre.Text = Propietario.Nombrep;
            txtApaterno.Text = Propietario.ap;
            txtAmaterno.Text = Propietario.am;
            txtCalle.Text = Propietario.ncalle;
            txtnumc.Text =  Propietario.numcalle;
            txtUser.Text = Propietario.user;
            txtLocalidad.Text = Propietario.local;
            cmbsexo.Text = Propietario.sexo;
            txtTelefono.Text = Propietario.tlf;
            txtContraeña.Text = Propietario.password;
            txtEdad.Text =Convert.ToString( Propietario.edad);
            txtidpropietario.Text = Convert.ToString(Propietario.idpro);
        }

      

        private void txtidpropietario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarNum(txtidpropietario, e, 2);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnGuardar.Enabled = true;
            label1.Visible = false;
            txtidpropietario.Visible = false;


        }


        // En este metodo Editamos los datos.
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea Realmete Editar Su Perfil? Para guardar Cambios Es Necesario Cerrar sesion",
                "Notificación",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information)==DialogResult.OK)
            {
                int idpropietario = Convert.ToInt32(txtidpropietario.Text);
                string Nombre = txtNombre.Text;
                string Ap_paterno = txtApaterno.Text;
                string Ap_materno = txtAmaterno.Text;
                int Edad = Convert.ToInt32(txtEdad.Text);
                string Sexo = cmbsexo.Text;
                string Numero_de_telefono = txtTelefono.Text;
                string No_de_calle = txtnumc.Text;
                string Calle = txtCalle.Text;
                string Localidad = txtLocalidad.Text;
                string Usuario = txtUser.Text;
                string Password_2 = txtContraeña.Text;
                string Tipo_usuario = txtTipouser.Text;


                bool res = objpropietario.ModificarPropietario(idpropietario, Nombre, Ap_paterno, Ap_materno, Edad, Sexo,
                    Numero_de_telefono, No_de_calle, Calle, Localidad, Usuario, Password_2, Tipo_usuario);
                if (res)
                {
                    Home home = new Home();
                    
                    if (MessageBox.Show("Para guardar los cambios es necesario Reiniciar, CIERRA SESSIÓN PORFAVOR ",
                       "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) ;
                    {
                        this.Hide();



                    }

                }
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
          if(  MessageBox.Show("¿Realmente Deseea Cancelar la operacion, no se guardaran ningun cambio","Notificación",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                this.Hide();
                Login lg = new Login();
                lg.Show();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNombre.TextLength > 30)
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != '/' && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtApaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtApaterno.TextLength > 30)
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != '/' && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtAmaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAmaterno.TextLength > 30)
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != '/' && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUser.TextLength > 30)
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != '/' && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtLocalidad.TextLength > 30)
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != '/' && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarNum(txtTelefono, e, 10);
        }

        private void txtnumc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarNum(txtnumc, e, 3);
        }

        private void cmbsexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != '#' && e.KeyChar != '/' && e.KeyChar != '@' && e.KeyChar != '*' && e.KeyChar != '/'
                && e.KeyChar != '$' && e.KeyChar != '%' && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int idpropietario = Convert.ToInt32(txtidpropietario.Text);
           
            string Nombre = txtNombre.Text;
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Reñene este campo");
                txtNombre.SelectAll();
            }

            string Ap_paterno = txtApaterno.Text;
            if(Ap_paterno=="")
            {
                errorProvider1.SetError(txtApaterno, "Reñene este campo");
                txtApaterno.SelectAll();
            }
            string Ap_materno = txtAmaterno.Text;
            if (Ap_materno == "")
            {
                errorProvider1.SetError(txtAmaterno, "Reñene este campo");
                txtAmaterno.SelectAll();
            }

            int Edad = Convert.ToInt32(txtEdad.Text);
            if(txtEdad.Text== null)
            {
                errorProvider1.SetError(txtEdad, "REñene el Campo");
                txtEdad.SelectAll();
            }
            string Sexo = cmbsexo.Text;
            if (cmbsexo.Text =="")
            {
                errorProvider1.SetError(cmbsexo, "Reñene este campo");
                cmbsexo.SelectAll();
            }
            string Numero_de_telefono = txtTelefono.Text;
            string No_de_calle = txtnumc.Text;
            if (txtnumc.Text == "")
            {
                errorProvider1.SetError(txtnumc, "Reñene este campo");
                txtnumc.SelectAll();
            }
            string Calle = txtCalle.Text;
            if (txtCalle.Text == "")
            {
                errorProvider1.SetError(txtCalle, "Reñene este campo");
                txtCalle.SelectAll();
            }
            string Localidad = txtLocalidad.Text;
            if (txtLocalidad.Text == "")
            {
                errorProvider1.SetError(txtLocalidad, "Reñene este campo");
                txtLocalidad.SelectAll();
            }
            string Usuario = txtUser.Text;
            if (txtUser.Text == "")
            {
                errorProvider1.SetError(txtUser, "Reñene este campo");
                txtUser.SelectAll();
            }
            string Password_2 = txtContraeña.Text;
            if(txtContraeña.Text=="")
            {
                errorProvider1.SetError(txtContraeña, "Reñene este campo");
                txtContraeña.SelectAll();
            }
            string Tipo_usuario = txtTipouser.Text;


            bool res = objpropietario.RegistarPropietario(idpropietario, Nombre, Ap_paterno, Ap_materno, Edad, Sexo,
                Numero_de_telefono, No_de_calle, Calle, Localidad, Usuario, Password_2, Tipo_usuario);
            if (res)
            {

                this.Hide();
                Login log = new Login();
                log.Show();
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

