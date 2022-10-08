using System;
using System.Runtime.CompilerServices;

namespace Entidades
{
    public abstract class Persona{
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Carrera { get; set; }
        public int Semestre { get; set; }

        public Persona()
        {}

        public Persona(int id, string nombre, string apellido, string carrera, int semestre){
            
            ID = id;
            Nombre = nombre;
            Apellido = apellido;
            Carrera = carrera;
            Semestre = semestre;

        }

        public virtual void CargarPersonas(string[] data){

            ID = int.Parse(data[1]);
            Nombre = data[2];
            Apellido = data[3];
            Carrera = data[4];
            Semestre = int.Parse(data[5]);

        }
    }
}