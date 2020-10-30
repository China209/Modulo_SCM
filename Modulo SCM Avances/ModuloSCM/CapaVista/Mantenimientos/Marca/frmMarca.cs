using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaModuloSCM.Mantenimientos.Marca
{
    public partial class frmMarca : Form
    {
        string UsuarioAplicacion;
        static Form FormularioPadre;
        public frmMarca(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            navegador1.aplicacion = 2311;
            navegador1.tbl = "marca";
            navegador1.campoEstado = "estado_marca";
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
            navegador1.DatosActualizar = dgvMarcaVista;
            navegador1.procActualizarData();
            navegador1.procCargar();
    //       navegador1.ayudaRuta = "AyudasSeguridad/Modulo/ayuda.chm";
    //        navegador1.ruta = "Ayuda-Modulo.html";
        }
    }
}
