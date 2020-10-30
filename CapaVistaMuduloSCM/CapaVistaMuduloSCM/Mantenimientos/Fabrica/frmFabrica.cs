using CapaModelo;
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

namespace CapaVistaMuduloSCM.Mantenimientos.Fabrica
{
    public partial class frmFabrica : Form
    {
        //variables para el navegador
        string UsuarioAplicacion;
        static Form FormularioPadre;
        clsConexion conexion = new clsConexion();

        public frmFabrica(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
            
            //procedimiento para llamar los datos del municipio
            ProcMunicipio();

            //tooltips, ayudas al usuario
            tltAyuda.SetToolTip(txtCodigo, "Código de ingreso");
            tltAyuda.SetToolTip(txtDimension, "Ingrese una dimension");
            tltAyuda.SetToolTip(txtDireccion, "Ingrese una direccion");
            tltAyuda.SetToolTip(txtTelefono, "Ingrese el numero de telefono");
            tltAyuda.SetToolTip(txtDescripcion, "Ingrese una descripcion");
            tltAyuda.SetToolTip(cmbIdMunicipio, "Seleccione el numero del Municipio");
            tltAyuda.SetToolTip(cmbMunicipio, "Seleccione el nombre del Municipio");
            tltAyuda.SetToolTip(cmbEstado, "Ingrese el estado como valor 1 ");
        }


        //procedimiento para obtener los datos del municipio
        void ProcMunicipio()
        {
            try
            {
                string Municipio = "Select * from municipio ";
                OdbcCommand comm = new OdbcCommand(Municipio, conexion.conexion());
                OdbcDataReader mostrarMunicipio = comm.ExecuteReader();

                while (mostrarMunicipio.Read())
                {
                    cmbIdMunicipio.Items.Add(mostrarMunicipio.GetInt32(0));
                    cmbMunicipio.Items.Add(mostrarMunicipio.GetString(2));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Prueba");
            }

        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        //funcion del navegador
        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            navegador1.aplicacion = 2318;
            navegador1.tbl = "fabrica";
            navegador1.campoEstado = "estado_fabrica";
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
            navegador1.DatosActualizar = dgvFabrica;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "AyudasSeguridad/Modulo/ayuda.chm";
            navegador1.ruta = "Ayuda-Modulo.html";
        }

        //funciones para obtener los datos del municipio 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMunicipio.SelectedIndex = cmbIdMunicipio.SelectedIndex;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIdMunicipio.SelectedIndex = cmbMunicipio.SelectedIndex;
        }

        //funciones para solo permitir letras o numeros
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsDigit(cCaracter) && cCaracter != 8 && cCaracter != 32)
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
