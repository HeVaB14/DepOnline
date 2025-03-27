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

namespace DepOnline.Vista {
    // Objetivo 
    // Autor Equipo DepOnline
    // Fecha de inicio  27 diciembre de l 2018.
    // Fecha de modificacion  13 enero del 2019.

    public partial class CuartogeneralView : Form
    // Madamos a llamr los controladores que usaremos para la interfaz.     
    {
        private CuartosController objCuarto = null;
        private ImagenesController objimagen = null;
        private ServiciosController objservicios = null;
        private Cuartosincluidoscontroller objtotal = null;

        public CuartogeneralView() {
            InitializeComponent( );
            objtotal = new Cuartosincluidoscontroller( );
            objCuarto = new CuartosController( );
            objimagen = new ImagenesController( );
            objservicios = new ServiciosController( );

            objservicios.ConsultaServicio(0, dataGridView1);
            objimagen.ConsultarImagenes(0, dataGridView1);
            objCuarto.ConsultarCuarto(0, dataGridView1);

        }
        public void habilitarbotones(bool value) {

            btnEditar.Enabled = value;
            button1.Enabled = value;
            btnCancelar.Enabled = value;
            groupBox1.Enabled = value;
            groupBox2.Enabled = value;
            groupBox3.Enabled = value;
            btnimagen.Enabled = value;
        }
        public void Limpiarcampo() {
            txtidcuarto.Clear( );
            txtidservicio.Clear( );
            txtiImagen.Clear( );
            txtdireccion.Clear( );
            txtNombreimg.Clear( );
            txtPrecio.Clear( );
            txtTamao.Clear( );
            nmNum.Value = 0;
            cmbAgua.Text = "";
            cmbAmueblado.Text = "";
            cmbBaño.Text = "";
            cmbCategoria.Text = "";
            cmbDispobible.Text = "";
            cmbInternet.Text = "";
            cmbTv.Text = "";
        }
        public void habilitarcampo(bool value) {
            txtidcuarto.Enabled = value;
            txtidservicio.Enabled = value;
            txtiImagen.Enabled = value;
            label1.Enabled = value;
            txtNombreimg.Enabled = value;
            txtPrecio.Enabled = value;
            txtTamao.Enabled = value;
            nmNum.Enabled = value;
            cmbAgua.Enabled = value;
            cmbAmueblado.Enabled = value;
            cmbBaño.Enabled = value;
            cmbCategoria.Enabled = value;
            cmbDispobible.Enabled = value;
            cmbInternet.Enabled = value;
            cmbTv.Enabled = value;
            groupBox1.Enabled = value;
            groupBox2.Enabled = value;
            groupBox3.Enabled = value;
        }
        // En este metodo mandamos a llamar los datos que vamos a mostar.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            int indice = dataGridView1.CurrentRow.Index;

            txtidcuarto.Text = objCuarto.GetCuartos(indice).IdCuarto.ToString( );
            cmbDispobible.Text = objCuarto.GetCuartos(indice).Disponible;
            nmNum.Value = objCuarto.GetCuartos(indice).No_de_cuarto;
            txtTamao.Text = objCuarto.GetCuartos(indice).Tamanio;
            cmbCategoria.Text = objCuarto.GetCuartos(indice).Categoria;
            txtdireccion.Text = objCuarto.GetCuartos(indice).Direccion;
            txtPrecio.Text = objCuarto.GetCuartos(indice).Precio.ToString( );
            txtidservicio.Text = objservicios.Getservicios(indice).IdServicios.ToString( );
            cmbBaño.Text = objservicios.Getservicios(indice).Banio;
            cmbInternet.Text = objservicios.Getservicios(indice).Internet;
            cmbTv.Text = objservicios.Getservicios(indice).Cablevision;
            cmbAmueblado.Text = objservicios.Getservicios(indice).Amueblado;
            cmbAgua.Text = objservicios.Getservicios(indice).Agua_caliente;
            txtiImagen.Text = objimagen.Getimagenes(indice).NumImagenes.ToString( );
            txtNombreimg.Text = objimagen.Getimagenes(indice).Nombre_imagenes;

            habilitarcampo(true);
            btnimg.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            button1.Enabled = false;
            dataGridView1.Enabled = true;
            txtNombreimg.Enabled = false;


        }



        // Habilitamos los campos de inicio.
        private void btnNuevo_Click(object sender, EventArgs e) {
            habilitarcampo(true);
            habilitarbotones(true);

            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;

        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            // Este metodo es la que valida si hay un campo que no este lleno.
            errorProvider1.Clear( );

            string Disponible = cmbDispobible.Text;
            if (Disponible == "") {
                errorProvider1.SetError(cmbDispobible, "El id del cuarto ya existe");
                cmbDispobible.SelectAll( );
                return;
            }
            int No_de_cuarto = (int)nmNum.Value;

            if (No_de_cuarto <= 0) {
                errorProvider1.SetError(nmNum, "Debes de ingresar el numero del cuarto");
                nmNum.Select( );
                return;
            }
            string Tamanio = txtTamao.Text;
            if (Tamanio == "") {
                errorProvider1.SetError(txtTamao, "Debes de ingresar una medida de M2");
                txtTamao.SelectAll( );
                return;
            }


            string Categoria = cmbCategoria.Text;
            if (Categoria == "") {
                errorProvider1.SetError(cmbCategoria, "Debes de ingresar un valor Mediano,Pequeño,Grande");
                cmbCategoria.SelectAll( );
                return;
            }
            string Direccion = txtdireccion.Text;
            if (Direccion == "") {
                errorProvider1.SetError(label1, "Debes de ingresar la dirección de tu cuarto");
                txtdireccion.SelectAll( );
                return;
            }

            int Precio = Convert.ToInt32(txtPrecio.Text);
            if (txtPrecio == null) {
                MessageBox.Show("rellene el campo");
                return;
            }

            errorProvider1.Clear( );




            string Banio = cmbBaño.Text;

            if (cmbBaño.Text == "") {
                MessageBox.Show("Selecione un campo");
                cmbBaño.Focus( );
                return;
            }


            string Internet = cmbInternet.Text;
            if (cmbInternet.Text == "") {
                MessageBox.Show("Selecione un campo");
                cmbInternet.Focus( );
                return;
            }

            string Cablevision = cmbTv.Text;
            if (cmbTv.Text == "") {
                MessageBox.Show("Selecione un campo");
                cmbTv.Focus( );
                return;
            }

            string Amueblado = cmbAmueblado.Text;
            if (cmbAmueblado.Text == "") {
                MessageBox.Show("Selecione un campo");
                cmbAmueblado.Focus( );
                return;
            }

            string Agua_caliente = cmbAgua.Text;
            if (cmbAgua.Text == "") {
                MessageBox.Show("Selecione un campo");
                cmbAgua.Focus( );
                return;
            }







            string Nombre_imagenes = txtNombreimg.Text;
            if (Nombre_imagenes == "") {
                errorProvider1.SetError(txtNombreimg, "Ingrese el nombre de la imagen para poder guardar");
                txtNombreimg.SelectAll( );
                txtNombreimg.Focus( );
                return;


            }

            bool res = objtotal.Insertarcuarto(Disponible, No_de_cuarto, Tamanio, Categoria, Direccion,
                Precio, Banio, Internet, Cablevision, Amueblado, Agua_caliente, Nombre_imagenes);
            saveFileDialog1.InitialDirectory = "C:\\Users\\wm\\Desktop\\";

            saveFileDialog1.InitialDirectory = "C:\\Users\\wm\\Desktop\\";
            saveFileDialog1.Filter = "archivo JPG|*.jpg|Archivo PNG|*png|Archivo JPEG|*jpg ";
            if (saveFileDialog1.ShowDialog( ) == DialogResult.OK) ;
            {
                Image img = pictureBox1.Image;
                img.Save(saveFileDialog1.FileName);
            }
            if (res)
                if (res) {
                    Limpiarcampo( );


                    objservicios.ConsultaServicio(0, dataGridView1);
                    objimagen.ConsultarImagenes(0, dataGridView1);
                    objCuarto.ConsultarCuarto(0, dataGridView1);
                } else {
                    return;
                }
        }



        private void btnimagen_Click(object sender, EventArgs e) {



        }


        private void btnCancelar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Realmente desea cancelar la operación?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                this.Hide( );
            }
        }

        byte[] arreglo = null;

        private void button3_Click(object sender, EventArgs e) {
            openFileDialog1.InitialDirectory = "C:\\Users\\wm\\Desktop\\img\\";
            openFileDialog1.Filter = "archivo JPG|*.jpg|Archivo PNG|*png|Archivo JPEG|*jpg ";
            if (openFileDialog1.ShowDialog( ) == DialogResult.OK) {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                txtNombreimg.Text = openFileDialog1.FileName;

                //Byte[] imagen = System.IO.File.ReadAllBytes(saveFileDialog1.FileName);
                // string im = Convert.ToBase64String(imagen);
                //   txtNombreimg.Text = im;
            }
        }

        // Aqui validamos los campos para que no reciban caracteres especiales.
        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e) {
            if (txtiImagen.TextLength > 30) {
                if (e.KeyChar != Convert.ToChar(Keys.Back)) {
                    e.Handled = true;
                }
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != '/' && e.KeyChar != Convert.ToChar(Keys.Back)) {
                e.Handled = true;
            }
        }

        private void txtNombreimg_KeyPress(object sender, KeyPressEventArgs e) {
            if (txtiImagen.TextLength > 30) {
                if (e.KeyChar != Convert.ToChar(Keys.Back)) {
                    e.Handled = true;
                }
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != '/' && e.KeyChar != Convert.ToChar(Keys.Back)) {
                e.Handled = true;
            }
        }

        private void cmbDispobible_KeyPress(object sender, KeyPressEventArgs e) {
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back)) {
                    e.Handled = true;
                }
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != '#' && e.KeyChar != '/' && e.KeyChar != '@' && e.KeyChar != '*' && e.KeyChar != '/'
                && e.KeyChar != '$' && e.KeyChar != '%' && e.KeyChar != Convert.ToChar(Keys.Back)) {
                e.Handled = true;
            }
        }

        private void txtidcuarto_TextChanged(object sender, EventArgs e) {

        }

        private void txtidcuarto_KeyPress(object sender, KeyPressEventArgs e) {
            Metodos.ValidarNum(txtidcuarto, e, 5);
        }

        private void nmNum_KeyPress(object sender, KeyPressEventArgs e) {
            Metodos.ValidarNum1(nmNum, e, 3);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e) {
            Metodos.ValidarPrecio(txtPrecio, e, 5);
        }

        private void txtidservicio_KeyPress(object sender, KeyPressEventArgs e) {
            Metodos.ValidarNum(txtiImagen, e, 3);
        }

        private void cmbCategoria_KeyPress(object sender, KeyPressEventArgs e) {
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back)) {
                    e.Handled = true;
                }
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != '#' && e.KeyChar != '/' && e.KeyChar != '@' && e.KeyChar != '*' && e.KeyChar != '/'
                && e.KeyChar != '$' && e.KeyChar != '%' && e.KeyChar != Convert.ToChar(Keys.Back)) {
                e.Handled = true;
            }
        }

        private void cmbBaño_KeyPress(object sender, KeyPressEventArgs e) {
            Metodos.ValidarLetras(cmbBaño, e, 10);
        }

        private void cmbInternet_KeyPress(object sender, KeyPressEventArgs e) {
            Metodos.ValidarLetras(cmbInternet, e, 10);
        }

        private void cmbTv_KeyPress(object sender, KeyPressEventArgs e) {
            Metodos.ValidarLetras(cmbTv, e, 10);
        }

        private void txtTamao_KeyPress(object sender, KeyPressEventArgs e) {
            Metodos.ValidarPrecio(txtTamao, e, 10);
        }

        private void txtiImagen_KeyPress(object sender, KeyPressEventArgs e) {
            Metodos.ValidarNum(txtiImagen, e, 3);
        }
        //Fin.

        private void button1_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Desea editar el cuarto seleccionado", "Alerta...", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK) {


                errorProvider1.Clear( );
                groupBox1.Enabled = true;

                int IdCuarto = Convert.ToInt32(txtidcuarto.Text);

                string Disponible = cmbDispobible.Text;
                if (Disponible == "") {
                    errorProvider1.SetError(cmbDispobible, "Reñene este campo.");
                    cmbDispobible.SelectAll( );
                    return;
                }
                int No_de_cuarto = (int)nmNum.Value;


                string Tamanio = txtTamao.Text;
                if (Tamanio == "") {
                    errorProvider1.SetError(txtTamao, "Debes de ingresar una medida de M2.");
                    txtTamao.SelectAll( );
                    return;
                }
                string Categoria = cmbCategoria.Text;
                if (Categoria == "") {
                    errorProvider1.SetError(cmbCategoria, "Debes de ingresar un valor Mediano,Pequeño,Grande");
                    cmbCategoria.SelectAll( );
                    return;
                }
                string Direccion = label1.Text;
                if (Direccion == "") {
                    errorProvider1.SetError(label1, "Debes de ingresar la dirección de tu cuarto");
                    txtdireccion.SelectAll( );
                    return;
                }
                int Precio = Convert.ToInt32(txtPrecio.Text);
                errorProvider1.Clear( );
                int IdServicios = Convert.ToInt32(txtidservicio.Text);

                string Banio = cmbBaño.Text;
                if (cmbBaño.Text == "") {
                    MessageBox.Show("Selecione un campo");
                    cmbBaño.Focus( );
                    return;
                }


                string Internet = cmbInternet.Text;
                if (cmbInternet.Text == "") {
                    MessageBox.Show("Selecione un campo");
                    cmbInternet.Focus( );
                    return;
                }

                string Cablevision = cmbTv.Text;
                if (cmbTv.Text == "") {
                    MessageBox.Show("Selecione un campo");
                    cmbTv.Focus( );
                    return;
                }

                string Amueblado = cmbAmueblado.Text;
                if (cmbAmueblado.Text == "") {
                    MessageBox.Show("Selecione un campo");
                    cmbAmueblado.Focus( );
                    return;
                }

                string Agua_caliente = cmbAgua.Text;
                if (cmbAgua.Text == "") {
                    MessageBox.Show("Selecione un campo");
                    cmbAgua.Focus( );
                    return;
                }

                int Cuarto_idcuarto = Convert.ToInt32(txtidcuarto.Text);
                int NumImagenes = Convert.ToInt32(txtiImagen.Text);

                string Nombre_imagenes = txtNombreimg.Text;
                arreglo = File.ReadAllBytes(txtNombreimg.Text);

                string base64 = Convert.ToBase64String(arreglo);


                int idcuarto = Convert.ToInt32(txtidcuarto.Text);
                bool res = objCuarto.ModificarCuarto(idcuarto, Disponible, No_de_cuarto, Tamanio, Categoria, Direccion, Precio /*Propietario_idpropietario*/);
                bool res1 = objservicios.ModificarServicio(IdServicios, Banio, Internet, Cablevision, Amueblado, Agua_caliente, Cuarto_idcuarto);
                bool res2 = objimagen.ModificarImagenes(NumImagenes, Nombre_imagenes, Cuarto_idcuarto);
                saveFileDialog1.InitialDirectory = "C:\\Users\\wm\\Desktop\\";
                saveFileDialog1.Filter = "archivo JPG|*.jpg|Archivo PNG|*png|Archivo JPEG|*jpg ";
                if (res) {
                    objservicios.ConsultaServicio(0, dataGridView1);
                    objimagen.ConsultarImagenes(0, dataGridView1);
                    objCuarto.ConsultarCuarto(0, dataGridView1);
                    Limpiarcampo( );
                } else if (res1) {

                    objservicios.ConsultaServicio(0, dataGridView1);
                    objimagen.ConsultarImagenes(0, dataGridView1);
                    objCuarto.ConsultarCuarto(0, dataGridView1);

                    objtotal = new Cuartosincluidoscontroller( );
                    objCuarto = new CuartosController( );
                    objimagen = new ImagenesController( );
                    objservicios = new ServiciosController( );
                    Limpiarcampo( );

                } else if (saveFileDialog1.ShowDialog( ) == DialogResult.OK) {
                    Image img = pictureBox1.Image;
                    img.Save(saveFileDialog1.FileName);

                } else if (res2) {
                    objservicios.ConsultaServicio(0, dataGridView1);
                    objimagen.ConsultarImagenes(0, dataGridView1);
                    objCuarto.ConsultarCuarto(0, dataGridView1);
                    Limpiarcampo( );

                } else {

                    return;

                }
                habilitarcampo(false);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Estas seguro de eliminar el cuarto seleccionado?", "Alerta...", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK) {
                int IdCuarto = Convert.ToInt32(txtidcuarto.Text);
                bool res = objCuarto.EliminarCuarto(IdCuarto);
                if (res) {
                    Limpiarcampo( );
                    habilitarcampo(false);
                    txtidcuarto.Enabled = true;
                    //  habilitarbotones(false);
                    btnNuevo.Enabled = true;
                    objCuarto.ConsultarCuarto(0, dataGridView1);
                }
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e) {
            habilitarcampo(true);

            button1.Enabled = true;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            txtNombreimg.Enabled = false;

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e) {

            errorProvider1.Clear( );

            //   int IdCuarto = Convert.ToInt32(txtidcuarto.Text);
            string Disponible = cmbDispobible.Text;
            if (Disponible == "") {
                errorProvider1.SetError(cmbDispobible, "Rellene este Campo");
                cmbDispobible.SelectAll( );
                return;
            }
            int No_de_cuarto = (int)nmNum.Value;

            if (No_de_cuarto <= 0) {
                errorProvider1.SetError(nmNum, "Debes de ingresar el numero del cuarto");
                nmNum.Select( );
                return;
            }
            string Tamanio = txtTamao.Text;
            if (Tamanio == "") {
                errorProvider1.SetError(txtTamao, "Debes de ingresar una medida de M2");
                txtTamao.SelectAll( );
                return;
            }


            string Categoria = cmbCategoria.Text;
            if (Categoria == "") {
                errorProvider1.SetError(cmbCategoria, "Debes de ingresar un valor Mediano,Pequeño,Grande");
                cmbCategoria.SelectAll( );
                return;
            }
            string Direccion = txtdireccion.Text;
            if (Direccion == "") {
                errorProvider1.SetError(txtdireccion, "Debes de ingresar la dirección de tu cuarto");
                txtdireccion.SelectAll( );
                return;
            }

            int Precio = Convert.ToInt32(txtPrecio.Text);
            if (Precio == null) {
                errorProvider1.SetError(txtPrecio, "Debes de ingresar el Precio de tu cuarto");
                txtdireccion.SelectAll( );
                return;
            }

            errorProvider1.Clear( );




            string Banio = cmbBaño.Text;

            if (cmbBaño.Text == "") {
                MessageBox.Show("Selecione un campo");
                cmbBaño.Focus( );
                return;
            }


            string Internet = cmbInternet.Text;
            if (cmbInternet.Text == "") {
                MessageBox.Show("Selecione un campo");
                cmbInternet.Focus( );
                return;
            }

            string Cablevision = cmbTv.Text;
            if (cmbTv.Text == "") {
                MessageBox.Show("Selecione un campo");
                cmbTv.Focus( );
                return;
            }

            string Amueblado = cmbAmueblado.Text;
            if (cmbAmueblado.Text == "") {
                MessageBox.Show("Selecione un campo");
                cmbAmueblado.Focus( );
                return;
            }

            string Agua_caliente = cmbAgua.Text;
            if (cmbAgua.Text == "") {
                MessageBox.Show("Selecione un campo");
                cmbAgua.Focus( );
                return;
            }
            if (txtNombreimg.Text == "") {
                MessageBox.Show("Agrege una imagen", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            arreglo = File.ReadAllBytes(txtNombreimg.Text);
            string base64 = Convert.ToBase64String(arreglo);
            // string nombre = txtnombre.Text;
            txtNombreimg.Enabled = false;

            string Nombre_imagenes = txtNombreimg.Text;
            if (Nombre_imagenes == "") {
                errorProvider1.SetError(txtNombreimg, "Ingrese el nombre de la imagen para poder guardar");
                txtNombreimg.SelectAll( );
                txtNombreimg.Focus( );
                return;


            }
            if (pictureBox1.Image == null) {
                MessageBox.Show("Porfavor Seleccione una imágen", "Informacón",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool res = objtotal.Insertarcuarto(Disponible, No_de_cuarto, Tamanio, Categoria, Direccion,
                Precio, Banio, Internet, Cablevision, Amueblado, Agua_caliente, base64);
            saveFileDialog1.InitialDirectory = "C:\\Users\\wm\\Desktop\\";

            saveFileDialog1.InitialDirectory = "C:\\Users\\wm\\Desktop\\";
            saveFileDialog1.Filter = "archivo JPG|*.jpg|Archivo PNG|*png|Archivo JPEG|*jpg ";
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK) ;
            //{
            //    //Image img = pictureBox1.Image;
            //    //img.Save(saveFileDialog1.FileName);
            //}
            if (res)
                if (res) {
                    dataGridView1.Enabled = true;
                    Limpiarcampo( );


                    objservicios.ConsultaServicio(0, dataGridView1);
                    objimagen.ConsultarImagenes(0, dataGridView1);
                    objCuarto.ConsultarCuarto(0, dataGridView1);
                } else {
                    return;
                }
            dataGridView1.Enabled = true;

        }

        private void bunifuFlatButton1_Click_2(object sender, EventArgs e) {
            if (MessageBox.Show("¿Desea editar el cuarto seleccionado?", "Alerta...", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK) {
                errorProvider1.Clear( );
                groupBox1.Enabled = true;

                int IdCuarto = Convert.ToInt32(txtidcuarto.Text);

                string Disponible = cmbDispobible.Text;
                if (Disponible == "") {
                    errorProvider1.SetError(cmbDispobible, "El id del cuarto ya existe");
                    cmbDispobible.SelectAll( );
                    return;
                }
                int No_de_cuarto = (int)nmNum.Value;


                string Tamanio = txtTamao.Text;
                if (Tamanio == "") {
                    errorProvider1.SetError(txtTamao, "Debes de ingresar una medida de M2");
                    txtTamao.SelectAll( );
                    return;
                }
                string Categoria = cmbCategoria.Text;
                if (Categoria == "") {
                    errorProvider1.SetError(cmbCategoria, "Debes de ingresar un valor Mediano,Pequeño,Grande");
                    cmbCategoria.SelectAll( );
                    return;
                }
                string Direccion = txtdireccion.Text;
                if (Direccion == "") {
                    errorProvider1.SetError(label1, "Debes de ingresar la dirección de tu cuarto");
                    txtdireccion.SelectAll( );
                    return;
                }
                int Precio = Convert.ToInt32(txtPrecio.Text);
                errorProvider1.Clear( );
                int IdServicios = Convert.ToInt32(txtidservicio.Text);

                string Banio = cmbBaño.Text;
                if (cmbBaño.Text == "") {
                    MessageBox.Show("Selecione un campo");
                    cmbBaño.Focus( );
                    return;
                }


                string Internet = cmbInternet.Text;
                if (cmbInternet.Text == "") {
                    MessageBox.Show("Selecione un campo");
                    cmbInternet.Focus( );
                    return;
                }

                string Cablevision = cmbTv.Text;
                if (cmbTv.Text == "") {
                    MessageBox.Show("Selecione un campo");
                    cmbTv.Focus( );
                    return;
                }

                string Amueblado = cmbAmueblado.Text;
                if (cmbAmueblado.Text == "") {
                    MessageBox.Show("Selecione un campo");
                    cmbAmueblado.Focus( );
                    return;
                }

                string Agua_caliente = cmbAgua.Text;
                if (cmbAgua.Text == "") {
                    MessageBox.Show("Selecione un campo");
                    cmbAgua.Focus( );
                    return;
                }

                int Cuarto_idcuarto = Convert.ToInt32(txtidcuarto.Text);
                int NumImagenes = Convert.ToInt32(txtiImagen.Text);

                string Nombre_imagenes = txtNombreimg.Text;
                int idcuarto = Convert.ToInt32(txtidcuarto.Text);
                bool res = objCuarto.ModificarCuarto(idcuarto, Disponible, No_de_cuarto, Tamanio, Categoria, Direccion, Precio /*Propietario_idpropietario*/);
                bool res1 = objservicios.ModificarServicio(IdServicios, Banio, Internet, Cablevision, Amueblado, Agua_caliente, Cuarto_idcuarto);
                bool res2 = objimagen.ModificarImagenes(NumImagenes, Nombre_imagenes, Cuarto_idcuarto);
                saveFileDialog1.InitialDirectory = "C:\\Users\\wm\\Desktop\\";
                saveFileDialog1.Filter = "archivo JPG|*.jpg|Archivo PNG|*png|Archivo JPEG|*jpg ";
                if (res) {




                    objservicios.ConsultaServicio(0, dataGridView1);
                    objimagen.ConsultarImagenes(0, dataGridView1);
                    objCuarto.ConsultarCuarto(0, dataGridView1);
                    Limpiarcampo( );

                } else if (res1) {



                    objservicios.ConsultaServicio(0, dataGridView1);
                    objimagen.ConsultarImagenes(0, dataGridView1);
                    objCuarto.ConsultarCuarto(0, dataGridView1);

                    objtotal = new Cuartosincluidoscontroller( );
                    objCuarto = new CuartosController( );
                    objimagen = new ImagenesController( );
                    objservicios = new ServiciosController( );
                    Limpiarcampo( );
                }
                  //else if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                  //{
                  //    Image img = pictureBox1.Image;
                  //    img.Save(saveFileDialog1.FileName);
                  //}
                  else if (res2) {
                    objservicios.ConsultaServicio(0, dataGridView1);
                    objimagen.ConsultarImagenes(0, dataGridView1);
                    objCuarto.ConsultarCuarto(0, dataGridView1);
                    Limpiarcampo( );
                } else {
                    return;
                }

                habilitarcampo(false);

            }
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnimagen.Enabled = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Estas seguro de eliminar el cuarto seleccionado?", "Alerta...", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK) {
                int IdCuarto = Convert.ToInt32(txtidcuarto.Text);
                bool res = objCuarto.EliminarCuarto(IdCuarto);
                if (res) {
                    Limpiarcampo( );
                    habilitarcampo(false);
                    txtidcuarto.Enabled = true;

                    btnNuevo.Enabled = true;
                    objCuarto.ConsultarCuarto(0, dataGridView1);
                }
            }
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnimagen.Enabled = false;
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e) {
            if (MessageBox.Show("¿Realmente desea cancelar la operación?", "Advertencia", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK) {
                this.Hide( );
            }
        }

        private void cmbInternet_KeyPress_1(object sender, KeyPressEventArgs e) {
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back)) {
                    e.Handled = true;
                }
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != '#' &&
                e.KeyChar != '/' && e.KeyChar != '@' && e.KeyChar != '*' && e.KeyChar != '/'
                && e.KeyChar != '$' && e.KeyChar != '%' && e.KeyChar != Convert.ToChar(Keys.Back)) {
                e.Handled = true;
            }
        }

        private void txtdireccion_TextChanged(object sender, EventArgs e) {

        }

        private void bunifuFlatButton2_Click_2(object sender, EventArgs e) {
            MessageBox.Show("Ahora usted Podra  agregar más imágenes al cuarto que usted ha seleccionado",
                      "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ImagenesView img = new ImagenesView( );
            img.Show( );

            img.txtIdcuarto.Text = txtidcuarto.Text;
        }

        private void btnEditar_Click(object sender, EventArgs e) {

        }

        private void btnservicio_Click(object sender, EventArgs e) {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {




            if (radioButton1.Checked == true) {
                dataGridView1.Enabled = true;
                MessageBox.Show("¡Ahora usted Podra Editar, Eliminar y agregar más imágenes al cuarto que usted seleccione!",
                    "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {


            if (radioButton2.Checked == true) {
                dataGridView1.Enabled = false;
                MessageBox.Show("¡No tendra acceso a  los Datos de la tabla, Sera necesario Habilitar la tabla!",
                   "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}

