using System;
using System.Collections.Generic;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            string[] nombreMaterias = new string[4] { "Programación", "Aplicaciones", "Hardware", "Sistemas Operativos" };
            List<Alumno> alumnos = new List<Alumno>();
            Console.Write("Ingrese cantidad de alumnos: ");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < cantidad; i++)
            {
                Alumno alumno = new Alumno();                
                Console.WriteLine($"Datos del alumno {i + 1}");
                Console.Write("Nombre: ");
                alumno.Nombre = Console.ReadLine();
                Console.Write("Apellido: ");
                alumno.Apellido = Console.ReadLine();
                Console.Write("Curso: ");
                alumno.Curso = Console.ReadLine();
                for(int j = 0; j < nombreMaterias.Length; j++)
                {
                    Materia materia = new Materia();
                    materia.Nombre = nombreMaterias[j];
                    Console.Write($"Ingrese la nota de {nombreMaterias[j]}: ");
                    materia.Nota = int.Parse(Console.ReadLine());
                    alumno.Materias.Add(materia);
                }
                Console.WriteLine();
                alumnos.Add(alumno);
            }
            foreach(Alumno alumno in alumnos)
            {
                Console.WriteLine($"Datos del alumno {alumnos.IndexOf(alumno) + 1}");
                Console.WriteLine($"Nombre y Apellido: {alumno.NombreCompleto()}");
                Console.WriteLine($"Curso: {alumno.Curso}");
                Console.WriteLine($"Notas:");
                foreach (Materia materia in alumno.Materias)
                {
                    Console.WriteLine($"{materia.Nombre}: {materia.Nota}");
                }
                Console.WriteLine();
                Console.WriteLine($"Promedio: {alumno.CalcularPromedio()}");
                Console.WriteLine();
            }
        }
    }
}
