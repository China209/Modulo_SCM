﻿using CapaVistaModuloSCM.Mantenimientos;
using CapaVistaModuloSCM.Mantenimientos.Bodega;
using CapaVistaModuloSCM.Mantenimientos.Categoria_Producto;
using CapaVistaModuloSCM.Mantenimientos.Departamento;
using CapaVistaModuloSCM.Mantenimientos.Encargado_Bodega;
using CapaVistaModuloSCM.Mantenimientos.Fabrica;
using CapaVistaModuloSCM.Mantenimientos.Linea_Producto;
using CapaVistaModuloSCM.Mantenimientos.Marca;
using CapaVistaModuloSCM.Mantenimientos.Municipio;
using CapaVistaModuloSCM.Mantenimientos.Producto;
using CapaVistaModuloSCM.Mantenimientos.Tipo_de_Movimiento;
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
            txtVistaUsuario.Text = login.usuario();
        }
        //Direcciona a formulario marca
        private void marcaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2311", txtVistaUsuario.Text) == 1)
            {
                bit.user(txtVistaUsuario.Text);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmMarca);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmMarca(txtVistaUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
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
            if (seguridad.PermisosAcceso("2313", txtVistaUsuario.Text) == 1)
            {
                bit.user(txtVistaUsuario.Text);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmBodega);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmBodega(txtVistaUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
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
            if (seguridad.PermisosAcceso("2312", txtVistaUsuario.Text) == 1)
            {
                bit.user(txtVistaUsuario.Text);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmVehiculo);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmVehiculo(txtVistaUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
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
            if (seguridad.PermisosAcceso("2314", txtVistaUsuario.Text) == 1)
            {
                bit.user(txtVistaUsuario.Text);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmEncargadoBodega);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmEncargadoBodega(txtVistaUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
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
            if (seguridad.PermisosAcceso("2319", txtVistaUsuario.Text) == 1)
            {
                bit.user(txtVistaUsuario.Text);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmVistaCompraPedido);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmVistaCompraPedido(this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
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
            if (seguridad.PermisosAcceso("2307", txtVistaUsuario.Text) == 1)
            {
                bit.user(txtVistaUsuario.Text);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProveedor);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmProveedor(txtVistaUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
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
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmCorreoProveedor);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmCorreoProveedor(txtVistaUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
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
            if (seguridad.PermisosAcceso("2308", txtVistaUsuario.Text) == 1)
            {
                bit.user(txtVistaUsuario.Text);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmTelefonoProveedor);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmTelefonoProveedor(txtVistaUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
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
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmPais);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmPais(txtVistaUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
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
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmRuta);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmRuta(txtVistaUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
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
        //Abrir Linea
        private void líneaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2301", txtVistaUsuario.Text) == 1)
            {
                bit.user(txtVistaUsuario.Text);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmLineaProducto);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmLineaProducto(txtVistaUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Abrir Categoria
        private void categoríaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2302", txtVistaUsuario.Text) == 1)
            {
                bit.user(txtVistaUsuario.Text);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmCategoriaProducto);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario=new frmCategoriaProducto(txtVistaUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Abrir Producto
        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2303", txtVistaUsuario.Text) == 1)
            {
                bit.user(txtVistaUsuario.Text);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProducto);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmProducto(txtVistaUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Abrir Municipio
        private void municipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2305", txtVistaUsuario.Text) == 1)
            {
                bit.user(txtVistaUsuario.Text);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmMunicipio);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmMunicipio(txtVistaUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Abrir Departamento
        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2304", txtVistaUsuario.Text) == 1)
            {
                bit.user(txtVistaUsuario.Text);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmDepartamento);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmDepartamento(txtVistaUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Abrir Fabrica
        private void fábricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2318", txtVistaUsuario.Text) == 1)
            {
                bit.user(txtVistaUsuario.Text);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmFabrica);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmFabrica(txtVistaUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
        //Abrir Tipo de Movimiento
        private void tipoDeMovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2315", txtVistaUsuario.Text) == 1)
            {
                bit.user(txtVistaUsuario.Text);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmTipoMovimiento);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmTipoMovimiento(txtVistaUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void movimientoDeInventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVistaBitacora bit = new clsVistaBitacora();
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if (seguridad.PermisosAcceso("2317", txtVistaUsuario.Text) == 1)
            {
                bit.user(txtVistaUsuario.Text);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmMovimientoInventarios);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmMovimientoInventarios();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
    }
}
