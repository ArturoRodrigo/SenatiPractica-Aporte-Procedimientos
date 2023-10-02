using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SenatiPractica.datos.instructor;
using SenatiPractica.common.instructor;
using SenatiPractica.common;

namespace SenatiPractica.negocio.instructor
{
    internal class NegocioInstructor
    {
        private DatosInstructor _datosInstructor = new DatosInstructor();

        public int InsertarInstructorN(EntidadInstructor instructor)
        {
            //validaciones
            if (instructor.Dni.Length != 8)
            {
                MessageBox.Show("Longitud de dni incorrecta");
                return 0;
            }
            if (instructor.Nombres.Length == 0)
            {
                MessageBox.Show("Nombres esta vacio");
                return 0;
            }
            if (instructor.Apellidos.Length == 0)
            {
                MessageBox.Show("Apellidos esta vacio");
                return 0;
            }

            int numRes = _datosInstructor.InsertarInstructor(instructor);
            return numRes;
        }

        public DataTable ObtenerTodosInstructoresN()
        {

            return _datosInstructor.ObtenerTodosInstructores();
        }
        public DataTable BuscarInstructorByTipoAndParametroN(ETipoBusquedaInstructor tipo, string parametro)
        {

            //validaciones
            if (tipo == ETipoBusquedaInstructor.Dni) { //DNI
                if (Regex.IsMatch(parametro, "[aeiouAEIOU]", RegexOptions.IgnoreCase))
                {
                     MessageBox.Show("El DNI no puede tener vocales");
                     return null;
                }
            }
                                                       
              return _datosInstructor.BuscarInstructorByTipoAndParametro(tipo,parametro);
        }
                                                       
        public int EditarInstructorN(EntidadInstructor instructor)
        {
             //validaciones
             if (instructor.Dni.Length != 8)
             {
                  MessageBox.Show("Longitud de dni incorrecta");
                  return 0;
             }
             if (instructor.Nombres.Length == 0) {
                  MessageBox.Show("Nombres esta vacio");
                  return 0;
             }
             if (instructor.Apellidos.Length == 0)
             {
                  MessageBox.Show("Apellidos esta vacio");
                  return 0;
             }
                                                       
               return _datosInstructor.EditarInstructor(instructor);
               
        }
        /*
        public int EliminarInstructorN(int idInstructor)
        {
            return _datosInstructor.EliminarInstructor(Instructor);
        }
        */
    }
}
