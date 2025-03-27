using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepOnline.Controlador
{
    // Objetivo Esta clase es para validar algunos campos y sobre todo que las cajas de texto no reciban inyecciones sql.
    // Autor Autor Equipo DepOnline.
    // Fecha de Creacion 24 noviembre del 2018.
    // Fecha de Modificación. 23 de diciembre del 2018.
    class Metodos
    {
        //Metodo para vaciar campos
        public static void VaciarCampos(Object[] objetos)
        {
            for (int i = 0; i < objetos.Length; i++)
            {
                try
                {
                    TextBox caja = (TextBox)objetos[i];
                    caja.Text = "";
                }
                catch (Exception)
                {
                    Console.WriteLine("Solo se pueden vaciar campos de texto");
                }

            }
        }

        //Metodo para vaciar campos.
        public static Boolean ValidarVacios(Object[] objetos)
        {
            Boolean vacio = false;
            for (int i = 0; i < objetos.Length; i++)
            {
                TextBox caja = (TextBox)objetos[i];
                if (caja.Text.Equals("") || caja.Text.Equals(" "))
                {
                    vacio = true;
                }
            }
            return vacio;
        }

        //Metodo para deshabilitar objetos.
        public static void HabilitarCampos(Object[] objetos, Boolean valor)
        {

            for (int i = 0; i < objetos.Length; i++)
            {
                try
                {
                    TextBox caja = (TextBox)objetos[i];
                    caja.Enabled = valor;
                }
                catch (Exception)
                {
                    try
                    {
                        Button caja = (Button)objetos[i];
                        caja.Enabled = valor;
                    }
                    catch (Exception)
                    {
                        try
                        {
                            ComboBox caja = (ComboBox)objetos[i];
                            caja.Enabled = valor;
                        }
                        catch (Exception)
                        {
                            try
                            {
                                DateTimePicker caja = (DateTimePicker)objetos[i];
                                caja.Enabled = valor;
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                }

            }
        }
     
        // Metodo de Validar numero
        public static void ValidarNum(TextBox caja, KeyPressEventArgs e, int longitud)
        {
            TextBox cajanew = caja;
           
            if (cajanew.TextLength > longitud)
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
                // e.Handled = true;

            }
            if (!Char.IsNumber(e.KeyChar) &&
                e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
            



        }
        //Metodo para validar Numero en numericump.
        public static void ValidarNum1( NumericUpDown num, KeyPressEventArgs e, int longitud)
        {
           
            NumericUpDown numnew = num;

            if (num.Value> longitud)
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
                // e.Handled = true;

            }
            if (!Char.IsNumber(e.KeyChar) &&
                e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }




        }
        // Solo Hace validar los  Precios.
        public static void ValidarPrecio(TextBox caja, KeyPressEventArgs e, int longitud)
        {
            TextBox cajanew = caja;
            if (cajanew.TextLength > longitud)
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
                // e.Handled = true;

            }
            if (!Char.IsNumber(e.KeyChar) &&
                e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        public static void ValidarLetras(ComboBox cajanew, KeyPressEventArgs e, int longitud)
        {
            if (cajanew.SelectedIndex > longitud)
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
            }

            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void ValidarPlaca(TextBox cajanew, KeyPressEventArgs e, int longitud)
        {
            if (cajanew.TextLength > longitud)
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
            }
            if (!Char.IsLetter(e.KeyChar) && !Char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        public static void ValidarModelo(TextBox cajanew, KeyPressEventArgs e, int longitud)
        {
            if (cajanew.TextLength > longitud)
            {
                if (e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
            }
            if (!Char.IsSeparator(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !Char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back)
                && e.KeyChar != '-' && e.KeyChar != '.' && e.KeyChar != '!')
            {
                e.Handled = true;
            }
        }
    }

}

