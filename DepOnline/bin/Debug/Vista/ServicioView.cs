using DepOnline.Controlador;
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

    public partial class ServicioView : Form
    {
        private PropietarioController objPropietario = null;
        private ServiciosController objservicios = null;
        // private CuartosController objcuarto = null;
        //private CuartosView cuarto = null;
        private ImagenesController objimagen = null;
    // private ImagenesView img = null;

        
       // private ServicioView servicio = null;
        public ServicioView()
        
        {
            InitializeComponent();
            //    objcuarto = new CuartosController();
            objPropietario = new PropietarioController();
            objimagen = new ImagenesController();
             //= new ImagenesView();
            objservicios = new ServiciosController();
            //cuarto = new CuartosView();
          
          //  servicio = new ServicioView();
            objservicios.ConsultaServicio(0, dataGridView1);





        }

        

        public void Limpiarcampos()
        {
           // txtCuarto.Clear();
            txtIdservicio.Clear();
            cmBaño.Items.Clear();
            cmCable.Items.Clear();
            cmInternet.Items.Clear();


            cmAguac.Items.Clear();
            cmAmueblado.Items.Clear();




        }
        public void habilitarbotones(bool value)
        {
            btnAgregar.Enabled = value;
            btnModificar.Enabled = value;
            btnGuardar.Enabled = value;
            btnEliminar.Enabled = value;
            btnCancelar.Enabled = value;
           
            

        }
        public void habilitarCampos(bool value)
        {
            txtCuarto.Enabled = value;
            cmBaño.Enabled = value;
            cmAmueblado.Enabled = value;
            cmCable.Enabled = value;
            cmAguac.Enabled = value;
            cmInternet.Enabled = value;
            txtIdservicio.Enabled = value;
        }

        private void ServiciosView_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbagua_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = dataGridView1.CurrentRow.Index;
            txtIdservicio.Text = objservicios.Getservicios(indice).IdServicios.ToString();
            cmBaño.SelectedValue = objservicios.Getservicios(indice).Banio;
            cmInternet.SelectedValue=objservicios.Getservicios(indice).Internet;
            cmCable.SelectedValue = objservicios.Getservicios(indice).Cablevision;
            cmAmueblado.SelectedValue = objservicios.Getservicios(indice).Amueblado;
            cmAguac.Text = objservicios.Getservicios(indice).Agua_caliente;
           
            txtCuarto.Text = objservicios.Getservicios(indice).Cuarto_idcuarto.ToString();
            habilitarbotones(true);
            habilitarCampos(true);
            btnAgregar.Enabled = false;
            btnGuardar.Enabled = false;
            txtCuarto. Enabled = false;
            txtIdservicio.Enabled = false;
        }

        //private void btnNuevo_Click(object sender, EventArgs e)
        //{
          
        //}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarCampos(false);
            Limpiarcampos();
            habilitarbotones(false);
           btnAgregar.Enabled = true;
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            int Idservicios = Convert.ToInt32(txtIdservicio.Text);
            bool res = objservicios.EliminarServicio(Idservicios);
            if (res)
            {
                Limpiarcampos();
                habilitarbotones(false);
                habilitarCampos(false);
                txtIdservicio.Enabled = true;
                btnAgregar.Enabled = true;
                btnCancelar.Enabled = true;
                objservicios.ConsultaServicio(0, dataGridView1);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Hide();
            errorProvider1.Clear();
            int IdServicios = Convert.ToInt32(txtIdservicio.Text);
            if (txtIdservicio == null)
            {
                MessageBox.Show("rellene el campo");
                return;
            }
            if(objservicios.consultaid(IdServicios)!=null)

            {
                errorProvider1.SetError(txtIdservicio, "Error el numero de servicio ya existe, agrege uno nuevo");
                txtIdservicio.SelectAll();
                txtIdservicio.Focus();
                return;
            }
           
            string Banio =cmBaño.Text;

            if (cmBaño.Text== "")
            {
                MessageBox.Show("Selecione un campo");
                cmBaño.Focus();
                return;
            }


            string Internet = cmInternet.Text;
            if (cmInternet.Text=="")
            {
                MessageBox.Show("Selecione un campo");
                cmInternet.Focus();
                return;
            }
           
            string Cablevision =cmCable.Text;
            if (cmCable.Text == "")
            {
                MessageBox.Show("Selecione un campo");
                cmCable.Focus();
                return;
            }

            string Amueblado = cmAmueblado.Text;
            if (cmAmueblado.Text == "")
            {
                MessageBox.Show("Selecione un campo");
                cmAmueblado.Focus();
                return;
            }

            string Agua_caliente =cmAguac.Text;
            if (cmAguac.Text == "")
            {
                MessageBox.Show("Selecione un campo");
                cmAguac.Focus();
                return;
            }

            int Cuarto_idcuarto = Convert.ToInt32(txtCuarto.Text);
           
            bool res = objservicios.InsertarServicio(IdServicios, Banio,Internet,Cablevision,Amueblado,Agua_caliente,Cuarto_idcuarto);
            if (res)
            {
                Limpiarcampos();

                objservicios.ConsultaServicio(0, dataGridView1);
            }
            else
            {
                return;
                
            }
            
            MessageBox.Show("Ahora agrege las fotos ");
            ImagenesView img = new ImagenesView();
          
            img.txtIdcuarto.Text = txtCuarto.Text;
            
            img.ShowDialog();
          //  objimagen.ConsultarImagenes(0, dataGridView1);




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmInternet_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int IdServicios = Convert.ToInt32(txtIdservicio.Text);

            string Banio = cmBaño.Text;
            if (cmBaño.Text == "")
            {
                MessageBox.Show("Selecione un campo");
                cmBaño.Focus();
                return;
            }


            string Internet = cmInternet.Text;
            if (cmInternet.Text == "")
            {
                MessageBox.Show("Selecione un campo");
                cmInternet.Focus();
                return;
            }

            string Cablevision = cmCable.Text;
            if (cmCable.Text == "")
            {
                MessageBox.Show("Selecione un campo");
                cmCable.Focus();
                return;
            }

            string Amueblado = cmAmueblado.Text;
            if (cmAmueblado.Text == "")
            {
                MessageBox.Show("Selecione un campo");
                cmAmueblado.Focus();
                return;
            }

            string Agua_caliente = cmAguac.Text;
            if (cmAguac.Text == "")
            {
                MessageBox.Show("Selecione un campo");
                cmAguac.Focus();
                return;
            }

            int Cuarto_idcuarto = Convert.ToInt32(txtCuarto.Text);
            bool res = objservicios.ModificarServicio(IdServicios, Banio, Internet, Cablevision, Amueblado, Agua_caliente, Cuarto_idcuarto);
            if (res)
            {
                Limpiarcampos();

                objservicios.ConsultaServicio(0, dataGridView1);
            }
            else
            {
                return;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            habilitarbotones(false);
            habilitarCampos(true);
            cmAguac.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtIdservicio.Focus();
            Limpiarcampos();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void cmBaño_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtIdservicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarNum(txtIdservicio, e, 2);


            if (txtIdservicio.TextLength > 5)
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

        private void txtCuarto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarNum(txtCuarto, e, 2);


        }

        private void cmBaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarLetras(cmBaño, e, 10);
        }

        private void cmInternet_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarLetras(cmInternet, e, 10);
        }

        private void cmCable_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarLetras(cmCable, e, 10);
        }

        private void cmAmueblado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarLetras(cmAmueblado, e, 10);
        }

        private void cmAguac_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarLetras(cmAguac, e, 10);
        }
    }
}
