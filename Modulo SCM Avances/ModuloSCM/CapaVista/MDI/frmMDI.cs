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
    }
}
