using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuletaDeLaSuerte
{
    class Vector
    {
        private EstablecerPregunta[] preguntas;
        private Random random;

        public Vector()
        {
            preguntas = new EstablecerPregunta[15]; // 5 preguntas de matemáticas, 5 de física y 5 de computación
            random = new Random();
            // Preguntas de matemáticas
            preguntas[0] = new EstablecerPregunta("Matemáticas", "10 + 10 ÷ 0.5", new List<string> { "5", "15", "30" }, "30");
            preguntas[1] = new EstablecerPregunta("Matemáticas", "¿Cuál es el siguiente elemento de esta serie? 3, 5, 8, 13, 21, ?", new List<string> { "46", "28", "34" }, "34");
            preguntas[2] = new EstablecerPregunta("Matemáticas", "0² - 2⁰", new List<string> { "0", "1", "-1", "-2" }, "-1");
            preguntas[3] = new EstablecerPregunta("Matemáticas", "(5x³)² es equivalente a:", new List<string> { "25x^5", "25x^6", "5x^5" }, "25x^6");
            preguntas[4] = new EstablecerPregunta("Matemáticas", "2⁰ - 2⁰ - (-2⁰)", new List<string> { "1", "2", "0" }, "1");
            // Preguntas de física
            preguntas[5] = new EstablecerPregunta("Física", "¿Cuál de las siguientes magnitudes es una cantidad escalar?", new List<string> { "Velocidad", "Temperatura", "Aceleración" }, "Temperatura");
            preguntas[6] = new EstablecerPregunta("Física", "¿Qué ley establece que la presión y el volumen de un gas son inversamente proporcionales, manteniendo la temperatura constante?", new List<string> { "Ley de Ohm", "Ley de Boyle", "Ley de Archimedes" }, "Ley de Boyle");
            preguntas[7] = new EstablecerPregunta("Física", "¿Cuál de las siguientes fuerzas es responsable de mantener unidos los electrones alrededor del núcleo en un átomo?", new List<string> { "Fuerza gravitatoria", "Fuerza electromagnética", "Fuerza nuclear débil" }, "Fuerza electromagnética");
            preguntas[8] = new EstablecerPregunta("Física", "¿Cuál es la aceleración de un objeto en caída libre, en la Tierra?", new List<string> { "9.8 m/s²", "3.14 m/s²", "6.7 m/s²" }, "9.8 m/s²");
            preguntas[9] = new EstablecerPregunta("Física", "¿Qué tipo de energía se debe transferir a un electrón para sacarlo de un átomo?", new List<string> { "Energía cinética", "Energía potencial", "Energía de ionización" }, "Energía de ionización");
            // Preguntas de computación
            preguntas[10] = new EstablecerPregunta("Computación", "¿Qué es un algoritmo?", new List<string> { "Un error en el código", "Un conjunto de instrucciones ordenadas para resolver un problema", "Un tipo de dato en programación" }, "Un conjunto de instrucciones ordenadas para resolver un problema");
            preguntas[11] = new EstablecerPregunta("Computación", "¿Qué es una variable en programación?", new List<string> { "Un bloque de código que se repite varias veces", "Un espacio de memoria para almacenar datos", "Un programa que permite el acceso a internet" }, "Un espacio de memoria para almacenar datos");
            preguntas[12] = new EstablecerPregunta("Computación", "¿Qué es la recursión en programación?", new List<string> { "Un tipo de bucle", "Una función que se llama a sí misma", "Una operación matemática avanzada" }, "Una función que se llama a sí misma");
            preguntas[13] = new EstablecerPregunta("Computación", "¿Qué significa el término 'debugging' en programación?", new List<string> { "Crear nuevos programas desde cero", "Depurar y corregir errores en el código", "Añadir nuevas características a un software existente" }, "Depurar y corregir errores en el código");
            preguntas[14] = new EstablecerPregunta("Computación", "¿Qué es un bucle 'while' en programación?", new List<string> { "Una estructura de control que se repite un número fijo de veces", "Una estructura de control que se repite mientras una condición sea verdadera", "Un tipo de bucle que se repite infinitamente" }, "Una estructura de control que se repite mientras una condición sea verdadera");
        }

        public EstablecerPregunta ObtenerPreguntaMatematicasAleatoria()
        {
            int indicePregunta = random.Next(0, 5); // Índices 1 a 5 para preguntas de matemáticas
            return preguntas[indicePregunta];
        }
        public EstablecerPregunta ObtenerPreguntaFisicaAleatoria()
        {
            int indicePregunta = random.Next(5, 10); // Índices 5 a 10 para preguntas de física
            return preguntas[indicePregunta];
        }
        public EstablecerPregunta ObtenerPreguntaComputacionAleatoria()
        {
            int indicePregunta = random.Next(10, 15); // Índices 10 a 15 para preguntas de computación
            return preguntas[indicePregunta];
        }
        public EstablecerPregunta ObtenerPreguntaAleatoria()
        {
            int indicePregunta = random.Next(0, 15); // Índices 0 a 15 para preguntas aleatorias
            return preguntas[indicePregunta];
        }
    }
}
