using System;
using System.Linq;
using Entidades;

namespace Presentacion
{
    public class PresentacionPost : PresentacionPromedio
    {
        public void Lista(){
            Console.Clear();
            Console.WriteLine("------LISTADO DE ESTUDIANTES DE POSTGRADO------");






            foreach (var com in servicio.Listar().Where(persona => persona.GetType() == typeof(Postgrado))
                         .Cast<Postgrado>()){
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
                Console.WriteLine($"PROMEDIO DEL ESTUDIANTE: {com.PromedioGeneral}");





                
                Console.WriteLine();
            }


            Console.Write("Oprima una tecla para continuar.");Console.ReadKey();
        }
    }
}