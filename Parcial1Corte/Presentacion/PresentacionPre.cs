using System;
using System.Linq;
using System.Security.Cryptography;
using Entidades;

namespace Presentacion{
    public class PresentacionPre: PresentacionPromedio{
        public void Lista(){
            Console.Clear();
            Console.WriteLine("------LISTADO ESTUDIANTES DE PREGRADO------");





            foreach (var com in servicio.Listar().Where(Persona => Persona.GetType() == typeof(Pregrado)).Cast<Pregrado>()){
                Console.WriteLine("");
                Console.WriteLine("******DATOS DEL ESTUDIANTE******");
                Console.WriteLine("");
                Console.WriteLine($"NUMERO IDENTIFICACION: {com.ID}");
                Console.WriteLine("");
                Console.WriteLine($"NOMBRES: {com.Nombre}");
                Console.WriteLine("");
                Console.WriteLine($"APELLIDOS: {com.Apellido}");
                Console.WriteLine("");
                Console.WriteLine($"CARRERA: {com.Carrera}");
                Console.WriteLine("");
                Console.WriteLine($"SEMESTRE: {com.Semestre}");
                Console.WriteLine("");
                Console.WriteLine($"NOTA CORTE 1: {com.NotasCorte1}");
                Console.WriteLine("");
                Console.WriteLine($"NOTA CORTE 2: {com.NotasCorte2}");
                Console.WriteLine("");
                Console.WriteLine($"NOTA CORTE 3: {com.NotasCorte3}");




                
                Console.WriteLine();
            }

            Console.Write("Oprima una tecla para continuar.");Console.ReadKey();
        }
    }
}