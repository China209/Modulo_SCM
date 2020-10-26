using CapaVista.Mantenimientos;
using CapaVista.Mantenimientos.Pais;
using CapaVista.Mantenimientos.Producto;
using CapaVista.Mantenimientos.Proveedores;
using CapaVista.Mantenimientos.Vehiculo;
using CapaVistaMuduloSCM.Mantenimientos.Departamento;
using CapaVistaMuduloSCM.Mantenimientos.Marca;
using CapaVistaMuduloSCM.Mantenimientos.Municipio;
using CapaVistaMuduloSCM.Mantenimientos.Ruta;
using CapaVistaMuduloSCM.Mantenimientos.Sucursal;
using System;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void frmMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult drResultadoMensaje;
            drResultadoMensaje = MessageBox.Show("¿Realmente desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (drResultadoMensaje == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBodega bodega = new frmBodega();
            bodega.Show();
        }

        private void encargadoBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEncargadoBodega encargado = new frmEncargadoBodega();
            encargado.Show();
        }

        private void estadoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadoProducto estado = new frmEstadoProducto();
            estado.Show();
        }

        private void fábricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFabrica fabrica = new frmFabrica();
            fabrica.Show();
        }

        private void líneaDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLineaProducto lineaProducto = new frmLineaProducto();
            lineaProducto.Show();
        }

        private void categoriaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria_Producto categoria_Producto = new frmCategoria_Producto();
            categoria_Producto.Show();
        }

        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPais pais = new frmPais();
            pais.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto producto = new frmProducto();
            producto.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedor_Principal proveedor = new frmProveedor_Principal();
            proveedor.Show();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehiculo vehiculo = new frmVehiculo();
            vehiculo.Show();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartamento departamento = new frmDepartamento();
            departamento.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarca marca = new frmMarca();
            marca.Show();
        }

        private void municipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMunicipio frmMunicipio = new frmMunicipio();
            frmMunicipio.Show();
        }

        private void rutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRuta ruta = new frmRuta();
            ruta.Show();
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSucursal sucursal = new frmSucursal();
            sucursal.Show();
        }
    }
}
