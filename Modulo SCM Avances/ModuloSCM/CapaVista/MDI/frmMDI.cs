using CapaVistaModuloSCM.Mantenimientos.Bodega;
using CapaVistaModuloSCM.Mantenimientos.Encargado_Bodega;
using CapaVistaModuloSCM.Mantenimientos.Marca;
using CapaVistaModuloSCM.Mantenimientos.Vehiculo;
using CapaVistaSeguridad;
using System;
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
        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            textBox1.Text = login.usuario();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void encargadoBodegaToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
