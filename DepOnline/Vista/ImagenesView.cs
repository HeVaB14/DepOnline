using DepOnline.Controlador;
using DepOnline.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepOnline.Vista
{
    public partial class ImagenesView : Form

    {
        private ImagenesController  objImagen = null;
        public ImagenesView()
        {
            objImagen = new ImagenesController();
            InitializeComponent();
            objImagen.ConsultarImagenes(0, dataGridView1);
        }

        private void ImagenesView_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void plbImagen_DoubleClick(object sender, EventArgs e)
        {
            
        }
        byte[] arreglo = null;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int NumImagenes = Convert.ToInt32(txtIdimagen.Text);
            string Nombre_imagenes = txtIdimagen.Text;
            int Cuarto_idcuarto = Convert.ToInt32(txtIdcuarto.Text);
            bool res = objImagen.ModificarImagenes(NumImagenes, Nombre_imagenes, Cuarto_idcuarto);
            saveFileDialog1.InitialDirectory = "C:\\Users\\wm\\Desktop\\";
            saveFileDialog1.Filter = "archivo JPG|*.jpg|Archivo PNG|*png|Archivo JPEG|*jpg ";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                Image img = plbImagen.Image;
                img.Save(saveFileDialog1.FileName);
            }
            if (res)
            {


                 objImagen.ConsultarImagenes(0, dataGridView1);
            }
            else
            {
                return;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            int NumImagenes = Convert.ToInt32(txtIdimagen.Text);
           
            bool res = objImagen.EliminarImagen(NumImagenes);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = dataGridView1.CurrentRow.Index;
            txtIdimagen.Text = objImagen.Getimagenes(indice).NumImagenes.ToString();
            txtNombre.Text = objImagen.Getimagenes(indice).Nombre_imagenes;
            txtIdcuarto.Text = objImagen.Getimagenes(indice).Cuarto_idcuarto.ToString();
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtIdimagen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdimagen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarNum(txtIdimagen, e, 2);
        }

        private void txtIdcuarto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdcuarto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarNum(txtIdcuarto, e, 2);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            open.InitialDirectory = "C:\\Users\\wm\\Desktop\\img\\";
            open.Filter = "archivo JPG|*.jpg|Archivo PNG|*png|Archivo JPEG|*jpg ";
            if (open.ShowDialog() == DialogResult.OK) ;
            {
                plbImagen.Image = Image.FromFile(open.FileName);
                txtNombre.Text = open.FileName;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(plbImagen.Image==null)
            {
                MessageBox.Show("Seleccione una imagen",
                 "Informacion", MessageBoxButtons.OK, 
                 MessageBoxIcon.Information);
                return;
            }
            if(txtNombre.Text=="")
            {
                MessageBox.Show("No se Puede insertar sin nombre",
                   "Informacion", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                return;

            }
            arreglo = File.ReadAllBytes(txtNombre.Text);
            string base64 = Convert.ToBase64String(arreglo);
            // string nombre = txtnombre.Text;
            errorProvider1.Clear();


           // int NumImagenes = Convert.ToInt32(txtIdimagen.Text);


            string Nombre_imagenes = txtNombre.Text;
            if (Nombre_imagenes == "")
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre de la imagen para poder guardar");
                txtNombre.SelectAll();
                txtNombre.Focus();
                return;


            }
            // int d = Convert.ToInt32(txtIdimagen.Text);
            int Cuarto_idcuarto = Convert.ToInt32(txtIdcuarto.Text);
            Imagenes m = new Imagenes();
            bool res = objImagen.AñadirImagenes(0, base64, Cuarto_idcuarto);
            saveFileDialog1.InitialDirectory = "C:\\Users\\wm\\Desktop\\";
            saveFileDialog1.Filter = "archivo JPG|*.jpg|Archivo PNG|*png|Archivo JPEG|*jpg ";
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK) ;
            //{
            ////    Image img = plbImagen.Image;
            ////    img.Save(saveFileDialog1.FileName);

            //}
            //if (res)
            //{


            //    objImagen.ConsultarImagenes(0, dataGridView1);
            //}
            //else
            //{
            //    return;
            //}
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("¿Estas seguro  de cerrar la ventana de agregar imagenes?", "Alerta...", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Hide();
            }
        }
    }
}
