using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuletaDeLaSuerte
{
    public partial class VentanaPregunta : Form
    {
        private List<Pregunta> preguntas;
        private int indicePregunta;
        Vector v;
        public VentanaPregunta(string materia)
        {
            v = new Vector();
            InitializeComponent();
            if (materia == "matematicas")
            {
                // Obtener una pregunta aleatoria de matemáticas desde Vector
                Pregunta preguntaMatematicasAleatoria = v.ObtenerPreguntaMatematicas();

                // Mostrar la pregunta y opciones en los controles
                MostrarPreguntaEnControles(preguntaMatematicasAleatoria);
            }
            if (materia == "física")
            {
                // Obtener una pregunta aleatoria de fisica desde Vector
                Pregunta preguntaFisicaAleatoria = v.ObtenerPreguntaFisica();

                // Mostrar la pregunta y opciones en los controles
                MostrarPreguntaEnControles(preguntaFisicaAleatoria);
            }
            if (materia == "computación")
            {
                // Obtener una pregunta aleatoria de computacion desde Vector
                Pregunta preguntaComputacionAleatoria = v.ObtenerPreguntaComputacion();

                // Mostrar la pregunta y opciones en los controles
                MostrarPreguntaEnControles(preguntaComputacionAleatoria);
            }

        }
        private void MostrarPreguntaEnControles(Pregunta pregunta)
        {
            // Asignar el enunciado de la pregunta al Label
            label1.Text = pregunta.Enunciado;

            // Asignar las opciones de respuesta a los RadioButtons
            radioButton1.Text = pregunta.Opciones[1];
            radioButton2.Text = pregunta.Opciones[2];
            radioButton3.Text = pregunta.Opciones[3];
        }

        private void VentanaPregunta_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (indicePregunta >= 0 && indicePregunta < preguntas.Count)
            {
                Pregunta preguntaActual = preguntas[indicePregunta];
                string respuestaSeleccionada = ObtenerRespuestaSeleccionada();

                // Verificar si la respuesta seleccionada es correcta
                if (respuestaSeleccionada == preguntaActual.RespuestaCorrecta)
                {
                    // Mostrar ventana emergente con respuesta correcta
                    MessageBox.Show("¡Respuesta correcta!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Mostrar ventana emergente con respuesta incorrecta
                    MessageBox.Show("Respuesta incorrecta.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Cerrar la ventana de preguntas
                this.Close();
            }
        }
        private string ObtenerRespuestaSeleccionada()
        {
            if (radioButton1.Checked)
                return radioButton1.Text;
            if (radioButton2.Checked)
                return radioButton2.Text;
            if (radioButton3.Checked)
                return radioButton3.Text;

            // Si no se ha seleccionado ninguna respuesta, devolver cadena vacía
            return "";
        }
        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
