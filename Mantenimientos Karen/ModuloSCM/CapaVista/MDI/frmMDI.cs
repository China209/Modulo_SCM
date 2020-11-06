using CapaVistaModuloSCM.Mantenimientos;
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
            txtVistaUsuario.Text = login.usuario();
        }

        //MUestra la fecha y hora actual
        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        //Mostrar Proveedores
        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2307", txtVistaUsuario.Text) == 1)
            {
                bit.user(txtVistaUsuario.Text);
                frmProveedor Bancos = new frmProveedor(txtVistaUsuario.Text, this);
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
            if (seguridad.PermisosAcceso("2309", txtVistaUsuario.Text) == 1)
            {
                bit.user(txtVistaUsuario.Text);
                frmCorreoProveedor Bancos = new frmCorreoProveedor(txtVistaUsuario.Text, this);
                Bancos.MdiParent = this;
                Bancos.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Mostrar Telefono proveedor
        private void teléfonoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2308", txtVistaUsuario.Text) == 1)
            {
                bit.user(txtVistaUsuario.Text);
                frmTelefonoProveedor Bancos = new frmTelefonoProveedor(txtVistaUsuario.Text, this);
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
            if (seguridad.PermisosAcceso("2310", txtVistaUsuario.Text) == 1)
            {
                bit.user(txtVistaUsuario.Text);
                frmPais Bancos = new frmPais(txtVistaUsuario.Text, this);
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
            if (seguridad.PermisosAcceso("2306", txtVistaUsuario.Text) == 1)
            {
                bit.user(txtVistaUsuario.Text);
                frmRuta Bancos = new frmRuta(txtVistaUsuario.Text, this);
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
