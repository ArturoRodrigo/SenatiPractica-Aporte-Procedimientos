using SenatiPractica.common.instructor;
using SenatiPractica.common;
using SenatiPractica.negocio.instructor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenatiPractica.presentacion.instructor
{
    public partial class FrmEditarInstructor : Form
    {
        private NegocioInstructor _negocioInstructor = new NegocioInstructor();
        private EntidadInstructor _entidadInstructor;

        public delegate void InstructorGrillaLoadEventHandler();
        public event InstructorGrillaLoadEventHandler InstructorGrillaLoaded;
        public FrmEditarInstructor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _entidadInstructor.Dni = txtDni.Text;
            _entidadInstructor.Nombres = txtNombres.Text;
            _entidadInstructor.Apellidos = txtApellidos.Text;

            int num = _negocioInstructor.EditarInstructorN(_entidadInstructor);

            if (num != 0)
            {

                if (InstructorGrillaLoaded != null)
                {
                    InstructorGrillaLoaded(); //Invoco al evento refrescar grilla
                }

                MessageBox.Show("Operacion Satisfactoria");

                Close();
            }
        }

        private void FrmEditarInstructor_Shown(object sender, EventArgs e)
        {
            txtDni.Text = _entidadInstructor.Dni;
            txtNombres.Text = _entidadInstructor.Nombres;
            txtApellidos.Text = _entidadInstructor.Apellidos;
        }

    }
}
