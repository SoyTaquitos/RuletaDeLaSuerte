using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuletaDeLaSuerte
{
    class Vector
    {
        private Pregunta[] preguntasMatematicas;
        private Pregunta[] preguntasFisica;
        private Pregunta[] preguntasComputacion;
        private Random random;
        public Vector()
        {
            preguntasMatematicas = new Pregunta[5];
            preguntasFisica = new Pregunta[5];
            preguntasComputacion = new Pregunta[5];
            random = new Random();

            // Agregar las preguntas de matemáticas
            preguntasMatematicas[1] = new Pregunta("Matemáticas", "10 + 10 ÷ 0.5", new List<string> { "5", "15", "30", "40" }, "30");
            preguntasMatematicas[2] = new Pregunta("Matemáticas", "¿Cuál es el siguiente elemento de ésta serie ? 1, 1, 4, 9, 25, ? ", new List<string> { "36", "49", "64", "81" }, "64");
            /* Agregar las preguntas de física
            preguntasFisica[1] = new Pregunta("Física", "Enunciado de la pregunta 1 de Física", opciones1, "Respuesta correcta 1 de Física");
            preguntasFisica[2] = new Pregunta("Física", "Enunciado de la pregunta 2 de Física", opciones2, "Respuesta correcta 2 de Física");
            // Agregar las preguntas de computación
            preguntasComputacion[1] = new Pregunta("Computación", "Enunciado de la pregunta 1 de Computación", opciones1, "Respuesta correcta 1 de Computación");
            preguntasComputacion[2] = new Pregunta("Computación", "Enunciado de la pregunta 2 de Computación", opciones2, "Respuesta correcta 2 de Computación");*/
        }
        public Pregunta ObtenerPreguntaMatematicas()
        {
            int indicePregunta = random.Next(preguntasMatematicas.Length);
            return preguntasMatematicas[indicePregunta];
        }

        public Pregunta ObtenerPreguntaFisica()
        {
            int indicePregunta = random.Next(preguntasFisica.Length);
            return preguntasFisica[indicePregunta];
        }

        public Pregunta ObtenerPreguntaComputacion()
        {
            int indicePregunta = random.Next(preguntasComputacion.Length);
            return preguntasComputacion[indicePregunta];
        }
    }
}
