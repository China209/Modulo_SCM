using CapaVistaModuloSCM.Mantenimientos;
using CapaVistaModuloSCM.Mantenimientos.Bodega;
using CapaVistaModuloSCM.Mantenimientos.Encargado_Bodega;
using CapaVistaModuloSCM.Mantenimientos.Marca;
using CapaVistaModuloSCM.Mantenimientos.Vehiculo;
using CapaVistaModuloSCM.Procesos;
using CapaVistaSeguridad;
using System;
/*
 Este formulario es el principal 
 */
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaModuloSCM.MDI
{
    public partial class frmMDI : Form
    {
        //MDI
        public frmMDI()
        {
            InitializeComponent();
        }
        //Para cada vez que cargue este formulario mostrar en login
        private void frmMDI_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            textBox1.Text = login.usuario();
        }
        //Direcciona a formulario marca
        private void marcaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2311", textBox1.Text) == 1)
            {
                bit.user(textBox1.Text);
                frmMarca Bancos = new frmMarca(textBox1.Text, this);
                Bancos.MdiParent = this;
                Bancos.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Direcciona al formulario bodega
        private void bodegaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2313", textBox1.Text) == 1)
            {
                bit.user(textBox1.Text);
                frmBodega Bancos = new frmBodega(textBox1.Text, this);
                Bancos.MdiParent = this;
                Bancos.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Direcciona al formulario vehiculo
        private void vehiculoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2312", textBox1.Text) == 1)
            {
                bit.user(textBox1.Text);
                frmVehiculo Bancos = new frmVehiculo(textBox1.Text, this);
                Bancos.MdiParent = this;
                Bancos.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Direcciona al formulario encargado bodega
        private void encargadoBodegaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2314", textBox1.Text) == 1)
            {
                bit.user(textBox1.Text);
                frmEncargadoBodega Bancos = new frmEncargadoBodega(textBox1.Text, this);
                Bancos.MdiParent = this;
                Bancos.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //MUestra la fecha y hora actual
        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
        //Mostrar Compras y Pedidos
        private void comprasYPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2316", textBox1.Text) == 1)
            {
                bit.user(textBox1.Text);
                frmCompras Bancos = new frmCompras();
                Bancos.MdiParent = this;
                Bancos.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Mostrar Proveedores
        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2307", textBox1.Text) == 1)
            {
                bit.user(textBox1.Text);
                frmProveedor Bancos = new frmProveedor(textBox1.Text, this);
                Bancos.MdiParent = this;
                Bancos.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Mostrar Correo Proveedor
        private void correoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2309", textBox1.Text) == 1)
            {
                bit.user(textBox1.Text);
                frmCorreoProveedor Bancos = new frmCorreoProveedor(textBox1.Text, this);
                Bancos.MdiParent = this;
                Bancos.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Mostrar Telefono
        private void teléfonoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2308", textBox1.Text) == 1)
            {
                bit.user(textBox1.Text);
                frmTelefonoProveedor Bancos = new frmTelefonoProveedor(textBox1.Text, this);
                Bancos.MdiParent = this;
                Bancos.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Mostrar Pais
        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2310", textBox1.Text) == 1)
            {
                bit.user(textBox1.Text);
                frmPais Bancos = new frmPais(textBox1.Text, this);
                Bancos.MdiParent = this;
                Bancos.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Mostrar Ruta
        private void rutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2306", textBox1.Text) == 1)
            {
                bit.user(textBox1.Text);
                frmRuta Bancos = new frmRuta(textBox1.Text, this);
                Bancos.MdiParent = this;
                Bancos.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Ayuda MDI
        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudasModuloSCM/AyudasSCMASII.chm", "MDI.html");
        }
    }
}
