using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaMuduloSCM.Mantenimientos.Linea_Producto
{
    public partial class frmLineaProducto : Form
    {
        //variables para el navegador
        string UsuarioAplicacion;
        static Form FormularioPadre;

        
        public frmLineaProducto(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;

            //tooltips, ayuda al usuario
            tltAyuda.SetToolTip(txtCodigo, "Código de ingreso");
            tltAyuda.SetToolTip(txtDescripcion, "Ingrese una descripcion");
            tltAyuda.SetToolTip(txtNombre, "Ingrese un nombre para la categoria de producto");
            tltAyuda.SetToolTip(cmbEstado, "Ingrese el estado como valor 1 ");
        }

        //funcion del navegador
        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            navegador1.aplicacion = 2301;
            navegador1.tbl = "linea_producto";
            navegador1.campoEstado = "estado_linea_producto";
            navegador1.MDIformulario = FormularioPadre;
            foreach (Control C in this.Controls)
            {
                if ((C.Tag != null) && (!C.Tag.ToString().Equals("")))
                {
                    if (C is TextBox)
                    {
                        lista.Add(C);

                    }
                    else if (C is ComboBox)
                    {
                        lista.Add(C);

                    }
                    else if (C is DateTimePicker)
                    {
                        lista.Add(C);
                    }
                }
            }
            navegador1.control = lista;
            navegador1.formulario = this;
            navegador1.DatosActualizar = dgvLinea;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "AyudasSeguridad/Modulo/ayuda.chm";
            navegador1.ruta = "Ayuda-Modulo.html";
        }

        //funciones para permitir solo numeros o letras
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsLetter(cCaracter) && cCaracter != 8 && cCaracter != 32)
            {
                e.Handled = true;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsLetter(cCaracter) && cCaracter != 8 && cCaracter != 32)
            {
                e.Handled = true;
            }
        }
    }
}

