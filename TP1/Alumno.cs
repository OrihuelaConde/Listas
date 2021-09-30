using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Curso { get; set; }
        public List<Materia> Materias { get; set; } = new List<Materia>();

        public string NombreCompleto()
        {
            return Nombre + ", " + Apellido;
        }

        public int CalcularPromedio()
        {
            int total = 0;
            foreach(Materia materia in Materias)
            {
                total += materia.Nota;
            }
            return total / Materias.Count;
        }
    }
}
