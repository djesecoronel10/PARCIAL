using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Datos;
using Entidades;

namespace Logica
{
    public class AccionesPersona
    {
        private List<Persona> persona;
        private Archivo archivo;

        private List<string> mPregrado = new List<string>
        {
            "SISTEMAS", "DERECHO", "ENFERMERIA", "LICENCIATURA", "MUSICA"
        };

        private List<string> mPostgrado = new List<string>()
        {
            "DESARROLLO SOFTWARE", "DERECHO", "ADMINISTRATIVO", "AUDITORIA EN SALUD"
        };

        public AccionesPersona()
        {
            persona = new List<Persona>();
            archivo = new Archivo("Registro-Academico.dat");
            CargarPersonas();
        }

        public List<Persona> Listar()
        {
            return persona;
        }

        private void CargarPersonas()
        {
            persona = archivo.CargarPersonas();
        }

        public string Promedio(string materia)
        {
            double promedio = 0;
            var numEstudiantes = 0;

            foreach (var estudiante in persona)
            {
                if (estudiante.Carrera.Equals(materia) && mPregrado.Contains(materia))
                {
                    var com = (Pregrado)estudiante;
                    var promEstudiantes = (com.NotasCorte1 + com.NotasCorte2 + com.NotasCorte3) / 3;
                    promedio += promEstudiantes;
                    numEstudiantes += 1;
                }
                else if (estudiante.Carrera.Equals(materia) && mPostgrado.Contains(materia))
                {
                    var es = (Postgrado)estudiante;
                    promedio += es.PromedioGeneral;
                    numEstudiantes += 1;
                }
            }

            var promedioFinal = promedio / numEstudiantes;
            return $"NUESTRA BASE ARROJA QUE EL PROMEDIO GENERAL PARA LA CARRERA {materia} ES {promedioFinal}";
        }

        public string Destacado(string materia)
        {
            double promMayor = 0;
            string destacado = "";
            string destacado1 = "";
            foreach (var estudiante in persona)
            {
                double promEstudiante;
                if (estudiante.Carrera.Equals(materia) && mPregrado.Contains(materia))
                {
                    var com = (Pregrado)estudiante;
                    promEstudiante = (com.NotasCorte1 + com.NotasCorte2 + com.NotasCorte3) / 3;

                    if (!(promEstudiante > promMayor)) continue;
                    promMayor = promEstudiante;
                    destacado = com.Nombre;
                    destacado1 = com.Apellido;
                }
                else if (estudiante.Carrera.Equals(materia) && mPostgrado.Contains(materia))
                {
                    var es = (Postgrado)estudiante;
                    promEstudiante = es.PromedioGeneral;

                    if (!(promEstudiante > promMayor)) continue;
                    promMayor = promEstudiante;
                    destacado = es.Nombre;
                    destacado1 = es.Apellido;
                }
            }
            return $"LE OFRECEMOS UN RECONOCIMIENTO AL ESTUDIANTE {destacado} {destacado1} POR SU EXCELENTE DESEMPE?O ACADEMICO. ELICITACIONES!";
        }
    }
}