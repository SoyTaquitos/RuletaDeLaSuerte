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
            preguntasMatematicas[1] = new Pregunta("Matemáticas", "10 + 10 ÷ 0.5", new List<string> { "5", "15", "30" }, "30");
            preguntasMatematicas[2] = new Pregunta("Matemáticas", "¿Cuál es el siguiente elemento de ésta serie ? 1, 1, 4, 9, 25, ? ", new List<string> { "36", "49", "64", "81" }, "64");
            preguntasMatematicas[3] = new Pregunta("Matemáticas", "0² - 2⁰", new List<string> { "0", "1", "-1", "-2" }, "-1");
            preguntasMatematicas[4] = new Pregunta("Matemáticas", "(5x³)²  es equivalente a: ", new List<string> { "25x^5", "5x^6", "10x^6", "25x^6" }, "25x^6");
            preguntasMatematicas[5] = new Pregunta("Matemáticas", "2⁰ - 2⁰ - (-2⁰)", new List<string> { "1", "-1", "2", "-2" }, "1");

            //Agregar las preguntas de física
            preguntasFisica[1] = new Pregunta("Física", "¿Cuál de las siguientes magnitudes es una cantidad escalar?", new List<string> { " Velocidad", "Fuerza", "Temperatura"}, "Temperatura");
            preguntasFisica[2] = new Pregunta("Física", "¿Qué ley establece que la presión y el volumen de un gas son inversamente proporcionales, manteniendo la temperatura constante?", new List<string> { "Ley de Ohm","Ley de Coulomb","Ley de Boyle" }, "Ley de Boyle");
            preguntasFisica[3] = new Pregunta("Física", "¿Cuál de las siguientes fuerzas es responsable de mantener unidos los electrones alrededor del núcleo en un átomo?", new List<string> { "Fuerza gravitatoria", "Fuerza electromagnética", "Fuerza nuclear fuerte" }, "Fuerza electromagnética");
            preguntasFisica[4] = new Pregunta("Física", "¿Cuál es la aceleración de un objeto en caída libre, en la Tierra?", new List<string> { "9.8 m/s²", "3.14 m/s²", "6.7 m/s²" }, "9.8 m/s²");
            preguntasFisica[5] = new Pregunta("Física", "¿Qué tipo de energía se debe transferir a un electrón para sacarlo de un átomo?", new List<string> { "Energía cinética ", "Energía potencial", " Energía de ionización" }, "Energía de ionización");
            // Agregar las preguntas de computación
            preguntasComputacion[1] = new Pregunta("Computación", " ¿Qué es un algoritmo?", new List<string> { "Un error en el código", "Un conjunto de instrucciones ordenadas para resolver un problema", "Un tipo de dato en programación" }, "Un conjunto de instrucciones ordenadas para resolver un problema");
            preguntasComputacion[2] = new Pregunta("Computación", "¿Qué es una variable en programación?", new List<string> { "Una función matemática", "Un bloque de código que se repite varias veces", "Un espacio de memoria para almacenar datos" }, "Un espacio de memoria para almacenar datos");
            preguntasComputacion[3] = new Pregunta("Computación", "¿Qué es la recursión en programación?", new List<string> { "Un tipo de bucle", "Una función que se llama a sí misma", "Una técnica de encriptación de datos" }, "Una función que se llama a sí misma");
            preguntasComputacion[4] = new Pregunta("Computación", "¿Qué significa el término ''debugging'' en programación?", new List<string> { "Crear nuevos programas desde cero", "Depurar y corregir errores en el código", "Añadir nuevas características a un software existente" }, "Depurar y corregir errores en el código");
            preguntasComputacion[5] = new Pregunta("Computación", "¿Qué es un bucle ''while'' en programación?", new List<string> { "Una estructura de control que se repite un número fijo de veces", "Un tipo de dato que puede almacenar múltiples valores", "Una estructura de control que se repite mientras una condición sea verdadera" }, "Una estructura de control que se repite mientras una condición sea verdadera");
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
