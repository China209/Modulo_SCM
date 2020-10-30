using CapaModeloModuloSCM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaModuloSCM.Mantenimientos.Vehiculo
{
    public partial class frmVehiculo : Form
    {
        string UsuarioAplicacion;
        static Form FormularioPadre;
        clsConexion con = new clsConexion();
        public frmVehiculo(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
            cargarMarca();
        }
        private void cargarMarca()
        {
            try
            {
                string Marca = "SELECT * FROM MARCA";
                OdbcCommand comando = new OdbcCommand(Marca, con.conexion());
                OdbcDataReader mostrarMuni = comando.ExecuteReader();
                while (mostrarMuni.Read())
                {
                    comboBox1.Items.Add(mostrarMuni.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos al combo");
                Console.WriteLine(ex.Message);
            }
        }
        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            navegador1.aplicacion = 2312;
            navegador1.tbl = "vehiculo";
            navegador1.campoEstado = "estado_vehiculo";
            navegador1.MDIformulario = FormularioPadre;
            foreach (Control C in this.Controls)
            {
                if (C.Tag != null)
                {
                    if (C.Tag.ToString() == "saltar")
                    {

                    }
                    else
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
            }
            navegador1.control = lista;
            navegador1.formulario = this;
            navegador1.DatosActualizar = dgvVehiculo;
            navegador1.procActualizarData();
            navegador1.procCargar();
          //  navegador1.ayudaRuta = "AyudasSeguridad/Modulo/ayuda.chm";
          //  navegador1.ruta = "Ayuda-Modulo.html";
        }
    }
}
