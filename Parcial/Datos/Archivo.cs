using System.Collections.Generic;
using System.IO;
using Entidades;

namespace Datos
{
    public class Archivo
    {
        private string ruta;
        private Persona persona;
        public Archivo(string ruta)
        {
            this.ruta = ruta;
        }

        public List<Persona> CargarContactos()
        {

            var rd = new StreamReader(ruta);
            var Persona = new List<Persona>();

            var dato = rd.ReadLine();
            while (dato != null)
            {
                var id = dato.Split(';')[0];
                if (id == "PRE")
                {
                    persona = new Pregrado();
                    persona.CargarDatos(dato.Split(';'));
                }
                else
                {
                    persona = new Postgrado();
                    persona.CargarDatos(dato.Split(';'));
                }
                Persona.Add(persona);
                dato = rd.ReadLine();
            }
            
            rd.Close();
            return Persona;
        }
    }
}