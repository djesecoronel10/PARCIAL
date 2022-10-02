using System;
using System.Linq;
using System.Security.Cryptography;
using Entidades;

namespace Presentacion
{
    public class PresentacionPre: PresentacionPromedio
    {
        public void Lista()
        {
            Console.Clear();
            Console.WriteLine("------LISTADO ESTUDIANTES DE PREGRADO------");

            foreach (var com in servicio.Listar().Where(Persona => Persona.GetType() == typeof(Pregrado)).Cast<Pregrado>())
            {
                Console.WriteLine($"Numero de Identificacion: {com.ID}");
                Console.WriteLine($"Nombres y Apellidos: {com.Nombre} {com.Apellido}");
                Console.WriteLine($"Carrera: {com.Carrera}");
                Console.WriteLine($"Semestre: {com.Semestre}");
                Console.WriteLine($"Nota Corte 1: {com.NotasCorte1}");
                Console.WriteLine($"Nota Corte 2: {com.NotasCorte2}");
                Console.WriteLine($"Nota Corte 3: {com.NotasCorte3}");
                
                Console.WriteLine();
            }

            Console.Write("Digite cualquier letra para continuar... ");Console.ReadKey();
        }
    }
}