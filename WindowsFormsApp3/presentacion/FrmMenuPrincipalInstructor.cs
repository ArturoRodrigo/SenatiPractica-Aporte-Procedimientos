using SenatiPractica.common.instructor;
using SenatiPractica.negocio.instructor;
using SenatiPractica.presentacion.alumno;
using SenatiPractica.presentacion.instructor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenatiPractica.presentacion
{
    public partial class FrmMenuPrincipalInstructor : Form
    {
        private NegocioInstructor _negocioInstructor = new NegocioInstructor();
        private EntidadInstructor _instructorSeleccionado = new EntidadInstructor();
        public FrmMenuPrincipalInstructor()
        {
            InitializeComponent();
        }
        private void FrmMenuPrincipalInstructor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FrmMenuPrincipalInstructor_Shown(object sender, EventArgs e)
        {
            CargarTodosInstructores();
            MessageBox.Show("Bienvenido al Sistema", "Acceso al Sistema",
                           MessageBoxButtons.OK);
        }
        private void FrmMenuPrincipalInstructor_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
        private void btnIngresarI_Click(object sender, EventArgs e)
        {
            FrmIngresarInstructor frmIngresarInstructor = new FrmIngresarInstructor();
            frmIngresarInstructor.InstructorGrillaLoaded += CargarTodosInstructores;//Usamos eventos para refrescar la grilla
            frmIngresarInstructor.ShowDialog();
        }
        private void CargarTodosInstructores()
        {
            //En caso el DataSource es null, no muestra nada en la grilla
            dgvInstructores.DataSource = _negocioInstructor.ObtenerTodosInstructoresN();
            SeleccionarInstructorLoad();
        }
        public void SeleccionarInstructorLoad()
        {
            if (dgvInstructores.Rows.Count == 0)
            {
                return;
            }

            string id = dgvInstructores.CurrentRow.Cells[0].Value.ToString();
            string dni = dgvInstructores.CurrentRow.Cells[1].Value.ToString();
            string nombres = dgvInstructores.CurrentRow.Cells[2].Value.ToString();
            string apellidos = dgvInstructores.CurrentRow.Cells[3].Value.ToString();
            
            _instructorSeleccionado.Id = Convert.ToInt32(id);
            _instructorSeleccionado.Dni = dni;
            _instructorSeleccionado.Nombres = nombres;
            _instructorSeleccionado.Apellidos = apellidos;
            
        }

        private void dgvInstructores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarInstructorLoad();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarInstructor frmBuscarInstructor = new FrmBuscarInstructor();
            DialogResult dr = frmBuscarInstructor.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                ETipoBusquedaInstructor tipo = frmBuscarInstructor.Tipo;
                string parametro = frmBuscarInstructor.Parametro;

                DataTable result = _negocioInstructor.BuscarInstructorByTipoAndParametroN(tipo, parametro);
                if (result != null)
                {
                    dgvInstructores.DataSource = result;
                    if (result.Rows.Count > 0)
                    {
                        MessageBox.Show("Se encontraron " + result.Rows.Count + " registros", "Busqueda de Instructor", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros");
                    }
                }
            }
            
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvInstructores.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }
            FrmEditarInstructor frmEditarInstructor = new FrmEditarInstructor();
            frmEditarInstructor.InstructorGrillaLoaded += CargarTodosInstructores;//Usamos eventos para refrescar la grilla
            frmEditarInstructor.ShowDialog();
        }
        /*
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInstructores.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }
            DialogResult resultado = MessageBox.Show("Desea eliminar el registro con dni:" + _instructorSeleccionado.Dni + "?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {
                int num = _negocioInstructor.EliminarInstructorN(_instructorSeleccionado.Id);
                if (num != 0)
                {
                    CargarTodosInstructores();
                    MessageBox.Show("Operacion Satisfactoria");
                }
            }
        }
        */
        
        
        
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTodosInstructores();
        }
    }
}
