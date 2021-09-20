using System;
using System.Collections.Generic;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
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
                Console.WriteLine();
                alumnos.Add(alumno);
            }
            foreach(Alumno a in alumnos)
            {
                Console.WriteLine($"Datos del alumno {alumnos.IndexOf(a) + 1}");
                Console.WriteLine($"Nombre: {a.Nombre}");
                Console.WriteLine($"Apellido: {a.Apellido}");
                Console.WriteLine($"Curso: {a.Curso}");
                Console.WriteLine();
            }
        }
    }
}
