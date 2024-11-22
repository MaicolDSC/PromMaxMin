using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromMaxMinEje2
{
    internal class Estudiante
    {
        private string[] nombre;
        private int[] calificacion;
        public string[] Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int[] Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }
    }
}
