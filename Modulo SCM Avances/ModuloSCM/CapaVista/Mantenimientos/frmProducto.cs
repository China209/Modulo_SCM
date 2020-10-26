using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador.ControladorModulo;

using CapaModelo.Clases_Modulo;
using System.Text.RegularExpressions;

namespace CapaVista.Mantenimientos.Producto
{

    public partial class frmProducto : Form
    {
        clsControladorProducto controlProducto = new clsControladorProducto();
        private clsProducto Producto;
        // metodos para manejear los datos 
        public frmProducto()
        {
            InitializeComponent();
            CargarComboboxLinea();
            CargarComboboxCategoria();
            cargarDatos();
            txtCodigo.Enabled = true;
        }

        //busqueda de datos el el combo box
        private void CargarComboboxCategoria()
        {
            cmbCategoria.DisplayMember = "pk_id_categoria_producto";
            cmbCategoria.ValueMember = "pk_id_categoria_producto";
            cmbCategoria.DataSource = controlProducto.obtenerCamposCombobox("pk_id_categoria_producto", "descripcion_categoria_producto", "CATEGORIA_PRODUCTO", " estado_categoria_producto");
            cmbCategoria.SelectedIndex = -1;
        }

        private void CargarComboboxLinea()
        {
            cmbLinea.DisplayMember = "pk_id_linea_producto";
            cmbLinea.ValueMember = "pk_id_linea_producto";
            cmbLinea.DataSource = controlProducto.obtenerCamposCombobox("pk_id_linea_producto", "nombre_linea_producto", "LINEA_PRODUCTO", "estado_linea_producto");
            cmbLinea.SelectedIndex = -1;
        }
        // cargar todos los datos a utilzar 
        private void cargarDatos()
        {
            dgvProducto.DataSource = controlProducto.obtenerTodo();
        }

        // Metodo para retornar todos los datos 
        private clsProducto llenarCampos()
        {
            clsProducto auxProducto = new clsProducto();
            auxProducto.ILinea_Producto = int.Parse(cmbLinea.Text.ToString());
            auxProducto.ICategoria_producto = int.Parse(cmbCategoria.Text.ToString());
            auxProducto.Snombre_producto = txtNombre.Text;
            auxProducto.DPrecio_producto = double.Parse(txtMedida.Text.ToString());
            auxProducto.DMedida_producto = double.Parse(txtPrecio.Text.ToString());
            auxProducto.SDescripcion_producto = txtDescripcion.Text;
            auxProducto.IEstado = 1;
            return auxProducto;
        }

        // Metodo para verificar la inserción de los datos 
        private bool guardarDatos()
        {
            this.Producto = llenarCampos();
            try
            {
                if (ValidarTextbox() == true)
                {
                    controlProducto.insertarProducto(this.Producto);
                    cargarDatos();
                    MessageBox.Show("Datos Correctamente Guardados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar los Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return false;
            }
        }



        //metodo para validar los atributos que estan vacios 
        private bool ValidarTextbox()
        {

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese Nombre", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = "";
                txtNombre.Focus();
                return false;
            }
            else if (txtMedida.Text == "")
            {
                MessageBox.Show("Ingrese Medida", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMedida.Text = "";
                txtMedida.Focus();
                return false;
            }
            else if (txtPrecio.Text == "")
            {
                MessageBox.Show("Ingrese Precio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Text = "";
                txtPrecio.Focus();
                return false;
            }
            else if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Ingrese Descripcion", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Text = "";
                txtDescripcion.Focus();
                return false;
            }
            
            else if (!Regex.Match(txtNombre.Text, @"^[A-Za-z]+([\ A-Za-z]+)*$").Success)
            {
                MessageBox.Show("Datos del campo nombre invalido", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = "";
                txtNombre.Focus();
                return false;
            }
            if (txtNombre.Text == "" && txtMedida.Text == "")
            {
                MessageBox.Show("Llene los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarComponentes();
                return false;
            }
            return true;

        }


        private void frmProducto_Load(object sender, EventArgs e)
        {

        }

        // metodo para limpiar los componentes cuando la insercion de los datos fue correcta 
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (guardarDatos() == true)
            {
                LimpiarComponentes();
            }
            else
            {
                LimpiarComponentes();
            }
        }

        // metodo para limpiar todos los atributos del formulario 
        private void LimpiarComponentes()
        {
            cmbLinea.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
            txtNombre.Text = "";
            txtMedida.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Focus();

        }

        // metodo para validar la salida 
        private void frmAplicativo_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
