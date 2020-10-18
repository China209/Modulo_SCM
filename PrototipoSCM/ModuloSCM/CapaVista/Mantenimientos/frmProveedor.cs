
using CapaControlador.ControladorModulo;
using CapaModelo.Clases_Modulo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Mantenimientos.Proveedores
{
    public partial class frmProveedor_Principal : Form
    {
        clsControladorProveedor controlProveedor = new clsControladorProveedor();
        private clsProveedor proveedor;
        public frmProveedor_Principal()
        {
            InitializeComponent();
            txtCodigo.Enabled = true;
            cargarDatos();
        }

        private void frmProveedor_Principal_Load(object sender, EventArgs e)
        {

        }

        // cargar todos los datos a utilzar 
        private void cargarDatos()
        {
            dgvProveedor.DataSource = controlProveedor.obtenerTodo();
        }

        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void frmProveedor_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult drResultadoMensaje;
            drResultadoMensaje = MessageBox.Show("¿Realmente desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (drResultadoMensaje == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        // Metodo para retornar todos los datos 
        private clsProveedor llenarCampos()
        {
            clsProveedor auxProveedor = new clsProveedor();
            auxProveedor.SRazon_social = txtRazon.Text;
            auxProveedor.SRepresentantelegal = txtRepresentante.Text;
            auxProveedor.Snit_Proveedor = txtNit.Text;
            auxProveedor.IEstado_proveedor = 1;
            return auxProveedor;
        }
    }
}
