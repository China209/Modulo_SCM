using CapaVistaMuduloSCM.Mantenimientos.Municipio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaMuduloSCM.Mantenimientos;
using CapaVistaSeguridad;
using CapaVistaMuduloSCM.Mantenimientos.Linea_Producto;
using CapaVistaMuduloSCM.Mantenimientos.Categoria_Producto;
using CapaVistaMuduloSCM.Mantenimientos.Producto;
using CapaVistaMuduloSCM.Mantenimientos.Fabrica;

namespace CapaVistaMuduloSCM.MDI
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

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2304", textBox1.Text) == 1)
            {
                bit.user(textBox1.Text);
                frmDepartamento Depto = new frmDepartamento(textBox1.Text, this);
                Depto.MdiParent = this;
                Depto.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }

        
    }


        private void municipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2305", textBox1.Text) == 1)
            {
                bit.user(textBox1.Text);
                frmMunicipio Municipio = new frmMunicipio(textBox1.Text, this);
                Municipio.MdiParent = this;
                Municipio.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

      

        private void SucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2301", textBox1.Text) == 1)
            {
                bit.user(textBox1.Text);
                frmLineaProducto Linea = new frmLineaProducto(textBox1.Text, this);
                Linea.MdiParent = this;
                Linea.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void CategoriaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2302", textBox1.Text) == 1)
            {
                bit.user(textBox1.Text);
                frmCategoriaProducto categoriaProducto = new frmCategoriaProducto(textBox1.Text, this);
                categoriaProducto.MdiParent = this;
                categoriaProducto.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2303", textBox1.Text) == 1)
            {
                bit.user(textBox1.Text);
                frmProducto categoriaProducto = new frmProducto(textBox1.Text, this);
                categoriaProducto.MdiParent = this;
                categoriaProducto.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void módulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fabricaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2318", textBox1.Text) == 1)
            {
                bit.user(textBox1.Text);
                frmFabrica fabrica = new frmFabrica(textBox1.Text, this);
                fabrica.MdiParent = this;
                fabrica.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
    }
}
