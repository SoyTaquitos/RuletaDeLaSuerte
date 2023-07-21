using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuletaDeLaSuerte
{
    class Pregunta
    {
        public string Materia { get; set; }
        public string Enunciado { get; set; }
        public List<string> Opciones { get; set; }
        public string RespuestaCorrecta { get; set; }

        public Pregunta(string materia, string enunciado, List<string> opciones, string respuestaCorrecta)
        {
            Materia = materia;
            Enunciado = enunciado;
            Opciones = opciones;
            RespuestaCorrecta = respuestaCorrecta;
        }

        public static Pregunta ObtenerPreguntaMatematicas()
        {
            List<Pregunta> preguntasMatematicas = new List<Pregunta>
        {
            new Pregunta("Matemáticas", "10 + 10 ÷ 0,5", new List<string> { "5", "15", "30", "40" }, "30"),
            new Pregunta("Matemáticas", "¿Cuál es el siguiente elemento de ésta serie? 1, 1, 4, 9, 25, ?", new List<string> { "36", "49", "64", "81" }, "64"),
            new Pregunta("Matemáticas", "0² - 2⁰", new List<string> { "0", "1", "-1", "-2" }, "-1"),
            new Pregunta("Matemáticas", "(5x³)²  es equivalente a: ", new List<string> { "25x^5", "5x^6", "10x^6", "25x^6" }, "25x^6"),
            new Pregunta("Matemáticas", "2⁰ - 2⁰ - (-2⁰)", new List<string> { "1", "-1", "2", "-2" }, "1")
        };

            Random random = new Random();
            int indice = random.Next(preguntasMatematicas.Count);
            return preguntasMatematicas[indice];
        }

        public static Pregunta ObtenerPreguntaFisica()
        {
            List<Pregunta> preguntasFisica = new List<Pregunta>
        {
            new Pregunta("Física", "¿Qué es la fuerza de gravedad?", new List<string> { "La fuerza que mantiene unidos los átomos en una molécula.", "La fuerza que mantiene a los objetos en la Tierra.", "La fuerza que atrae a los objetos hacia el centro de la Tierra.", "La fuerza que hace que los objetos se muevan en el espacio.", "." }, "La fuerza que atrae a los objetos hacia el centro de la Tierra."),
            new Pregunta("Física", "Ley de Newton: Fuerza y aceleración", new List<string> { "La primera ley de Newton establece que la fuerza es directamente proporcional a la aceleración.", "La segunda ley de Newton establece que la fuerza es inversamente proporcional a la aceleración.", "La segunda ley de Newton establece que la fuerza es igual a la masa multiplicada por la aceleración.", "La tercera ley de Newton establece que la fuerza es igual al cambio de momento lineal.", "." }, "La segunda ley de Newton establece que la fuerza es igual a la masa multiplicada por la aceleración."),
            new Pregunta("Física", "¿Cuál es la velocidad de la luz en el vacío?", new List<string> { "300,000 kilómetros por hora", "3,000 kilómetros por segundo", "300,000 metros por segundo", "3,000,000 metros por segundo", "." }, "300,000 metros por segundo"),
            new Pregunta("Física", "Ley de Newton: Ley de la inercia", new List<string> { "La primera ley de Newton se conoce como la ley de la inercia.", "La segunda ley de Newton se conoce como la ley de la inercia.", "La tercera ley de Newton se conoce como la ley de la inercia.", "Ninguna de las anteriores.", "." }, "La primera ley de Newton se conoce como la ley de la inercia."),
            new Pregunta("Física", "¿Qué es la ley de la acción y reacción?", new List<string> { "Por cada acción, hay una reacción igual en magnitud pero en dirección opuesta.", "La fuerza de un objeto es igual a su masa multiplicada por su aceleración.", "La fuerza que ejerce un objeto sobre otro es igual y opuesta a la fuerza que ejerce el segundo objeto sobre el primero.", "La fuerza que experimenta un objeto es proporcional al producto de la masa y la aceleración.", "." }, "La fuerza que ejerce un objeto sobre otro es igual y opuesta a la fuerza que ejerce el segundo objeto sobre el primero.")
        };

            Random random = new Random();
            int indice = random.Next(preguntasFisica.Count);
            return preguntasFisica[indice];
        }

        public static Pregunta ObtenerPreguntaInformatica()
        {
            List<Pregunta> preguntasInformatica = new List<Pregunta>
        {
            new Pregunta("Informática", "¿Qué es un algoritmo?", new List<string> { "Un lenguaje de programación", "Un sistema operativo", "Una secuencia de pasos para resolver un problema", "Una unidad de almacenamiento", "." }, "Una secuencia de pasos para resolver un problema"),
            new Pregunta("Informática", "¿Cuál de los siguientes lenguajes de programación se utiliza para crear aplicaciones móviles?", new List<string> { "Java", "HTML", "SQL", "CSS", "." }, "Java"),
            new Pregunta("Informática", "¿Qué es la memoria RAM?", new List<string> { "Un dispositivo de almacenamiento permanente.", "Una unidad de procesamiento central.", "Una memoria volátil utilizada para almacenar datos en tiempo de ejecución.", "Un lenguaje de programación.", "." }, "Una memoria volátil utilizada para almacenar datos en tiempo de ejecución."),
            new Pregunta("Informática", "¿Qué es la recursión en programación?", new List<string> { "Una estructura de control que permite repetir un bloque de código varias veces.", "Un paradigma de programación que se basa en la interacción de objetos para resolver problemas.", "Un método utilizado para organizar y estructurar el código en diferentes archivos.", "Un proceso en el que una función se llama a sí misma directa o indirectamente.", "." }, "Un proceso en el que una función se llama a sí misma directa o indirectamente."),
            new Pregunta("Informática", "¿Qué es un compilador?", new List<string> { "Un tipo de software malicioso", "Un lenguaje de programación", "Un dispositivo de entrada", "Un programa que traduce código fuente a código ejecutable", "."}, "Un programa que traduce código fuente a código ejecutable"),
        };

            Random random = new Random();
            int indice = random.Next(preguntasInformatica.Count);
            return preguntasInformatica[indice];
        }

        public static Pregunta ObtenerPregunta(string materia)
        {
            switch (materia)
            {
                case "Matemáticas":
                    return ObtenerPreguntaMatematicas();
                case "Física":
                    return ObtenerPreguntaFisica();
                case "Informática":
                    return ObtenerPreguntaInformatica();
                default:
                    return null;
            }
        }
    }
}
