using CapaControlador;
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

namespace CapaVistaMuduloSCM.Mantenimientos.Municipio
{
    public partial class frmMunicipio : Form
    {

        private clsMunicipio municipio;
        private int iIDAux, sEstado, IDepartamento;
        private string sNombreAux, sDescAux;
        clsControlMunicipio controlMunicipio = new clsControlMunicipio();
        public frmMunicipio()
        {
            InitializeComponent();
            CargarCombobox();
            cargarDatos();
            LimpiarComponentes();
        }


        private void CargarCombobox()
        {
            cmbDepartamento.DisplayMember = "nombre_departamento";
            cmbDepartamento.ValueMember = "pk_id_departamento";
            cmbDepartamento.DataSource = controlMunicipio.obtenerCamposCombobox();
            cmbDepartamento.SelectedIndex = -1;
            cmbDepartamento.Refresh();
        }


        private void cargarDatos()
        {
            dgvVistaDatos.DataSource = controlMunicipio.obtenerTodo();

        }

        private clsMunicipio llenarCampos()
        {
            clsMunicipio auxAplicativo = new clsMunicipio();
            auxAplicativo.IDepartamento = int.Parse(cmbDepartamento.SelectedValue.ToString());
            auxAplicativo.SNombre = txtNombre.Text;
            auxAplicativo.SDescripcion = txtDescripcion.Text;
            auxAplicativo.IEstado = 1;
            return auxAplicativo;
        }


        private void LimpiarComponentes()
        {

            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            cmbDepartamento.SelectedIndex = -1;
        }

        private bool guardarDatos()
        {
            this.municipio = llenarCampos();
            try
            {
                controlMunicipio.insertarMunicipio(this.municipio);
                cargarDatos();
                MessageBox.Show("Datos Correctamente Guardados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar los Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {

            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();

        }

        private void bntAgregar_Click(object sender, EventArgs e)
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

        private void bntAgregar_Click_1(object sender, EventArgs e)
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

        private void dgvVistaDatos_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                iIDAux = int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["pk_id_municipio"].Value.ToString());
                sNombreAux = dgvVistaDatos.Rows[e.RowIndex].Cells["fk_id_departamento"].Value.ToString();
                sDescAux = dgvVistaDatos.Rows[e.RowIndex].Cells["nombre_municipio"].Value.ToString();
                IDepartamento= int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["descripcion_municipio"].Value.ToString());
                sEstado = int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["estado_departamento"].Value.ToString());
                this.cmsEM.Show(this.dgvVistaDatos, e.Location);
                cmsEM.Show(Cursor.Position);
            }
        }
    }

    
}
