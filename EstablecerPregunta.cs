using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuletaDeLaSuerte
{
    class EstablecerPregunta
    {
        public string Materia { get; set; }
        public string Enunciado { get; set; }
        public List<string> Opciones { get; set; }
        public string RespuestaCorrecta { get; set; }

        public EstablecerPregunta(string materia, string enunciado, List<string> opciones, string respuestaCorrecta)
        {
            Materia = materia;
            Enunciado = enunciado;
            Opciones = opciones;
            RespuestaCorrecta = respuestaCorrecta;
        }
    }
}
