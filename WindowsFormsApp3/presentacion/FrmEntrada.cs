using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SenatiPractica.common.alumno;
using SenatiPractica.negocio;
using SenatiPractica.negocio.alumno;
using SenatiPractica.presentacion.alumno;
using SenatiPractica.common.alumno;
using SenatiPractica.presentacion;
using SenatiPractica.presentacion;

namespace SenatiPractica.presentacion
{
    public partial class FrmEntrada : Form
    {
        public FrmEntrada()
        {
            InitializeComponent();
        }
        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
            frmMenuPrincipal.Show();
        }
        private void btnInstructores_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipalInstructor frmMenuPrincipalInstructor = new FrmMenuPrincipalInstructor();
            frmMenuPrincipalInstructor.Show();
            
        }
    }
}
