﻿using System;
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
    public partial class Ruleta : Form
    {
        public Ruleta()
        {            
            InitializeComponent();
          
        }
        private string[] nombresMaterias = { "Matemáticas", "     Física", "Computación", "    Aleatoria" }; // Nombres de las materias en el orden de la ruleta
        private void DibujarRuleta()
        {
            // Cargar la imagen de la ruleta
            Image ruletaImage = Properties.Resources.Dos1;
            // Reemplaza "ruta_de_la_imagen/ruleta.png" con la ruta correcta de tu imagen de la ruleta

            Image ruletaModificada = (Image)ruletaImage.Clone();

            // Crear una instancia de Graphics para dibujar en la imagen de la ruleta
            using (Graphics graphics = Graphics.FromImage(ruletaModificada))
            {
                // Fuente y color para el texto
                Font font = new Font("Arial", 15, FontStyle.Bold);
                Brush brush = Brushes.White;

                // Coordenadas y tamaño del área donde se dibujará el texto
                int x = 180; // Ajusta las coordenadas según la posición deseada
                int y = 110;
                int width = 140; // Ajusta el tamaño según el tamaño del texto
                int height = 20;

                // Iterar sobre los nombres de las materias y dibujar el texto en la imagen de la ruleta
                for (int i = 0; i < nombresMaterias.Length; i++)
                {
                    string materia = nombresMaterias[i];
                    Rectangle rect = new Rectangle(x, y, width, height);
                    graphics.DrawString(materia, font, brush, rect);

                    // Rotar las coordenadas para el próximo texto  
                    graphics.TranslateTransform(ruletaImage.Width / 2, ruletaImage.Height / 2);
                    graphics.RotateTransform(360 / nombresMaterias.Length);
                    graphics.TranslateTransform(-ruletaImage.Width / 2, -ruletaImage.Height / 2);
                }
            }

            // Mostrar la imagen de la ruleta modificada en el PictureBox
            pictureBox1.Image = ruletaModificada;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DibujarRuleta();                   
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private Random random = new Random();
        private int TotalDeRotaciones = 0;
        private int NumeroDeVueltas;
        private int VelocidadEnLaQueDaVueltas = 200; //De cuanto en cuanto aumenta para llegar "TotalDeRotaciones"
        private void button1_Click(object sender, EventArgs e)
        {            
            // Establece el número de vueltas aleatoriamente (Vueltas completas)
            NumeroDeVueltas = random.Next(4, 12) * 360;

            // Inicia la rotación de la ruleta
            timer1.Start();
        }

        private string ObtenerPreguntaAleatoria(List<string> preguntas)
        {
            int indice = random.Next(preguntas.Count);
            return preguntas[indice];
        }

        // Calcula el índice de la casilla seleccionada
        public int AnguloFinal;
        private float currentRotationAngle = 0f; // Variable para rastrear el ángulo de rotación actual
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Agrega todas las preguntas necesarias a las listas correspondientes

            Random random = new Random();
            Pregunta preguntaAleatoria;
            // Realiza una rotación en VelocidadEnLaQueDaVueltas
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone); //Gira 90 grados 
            pictureBox1.Invalidate(); // Vuelve a dibujar la ruleta
                                      // Actualiza el ángulo de rotación actual
            currentRotationAngle += 90f;

            // Actualiza el contador de rotación total.
            TotalDeRotaciones += VelocidadEnLaQueDaVueltas;

            // Comprueba si se alcanzó NumeroDeVueltas
            if (TotalDeRotaciones >= NumeroDeVueltas)
            {
                // Detiene la rotación de la ruleta
                timer1.Stop();

                float sectorAngle = 360f / nombresMaterias.Length;
                int selectedMateriaIndex = (int)(currentRotationAngle / sectorAngle) % nombresMaterias.Length;

                // Asegúrate de que el índice esté dentro del rango válido
                if (selectedMateriaIndex < 0)
                    selectedMateriaIndex += nombresMaterias.Length;

                // Obtiene el nombre de la materia seleccionada
                string selectedMateria = nombresMaterias[selectedMateriaIndex].Trim();

                

                // Asigna el ángulo final
                AnguloFinal = (int)currentRotationAngle;
                if (AnguloFinal == 720 || AnguloFinal == 1800)
                {                  
                    MessageBox.Show("Usted recibira una pregunta de Matematicas");                                                     
                    VentanaPregunta ventanaPregunta = new VentanaPregunta("matematicas");
                    ventanaPregunta.ShowDialog();
                }

                if (AnguloFinal == 990 || AnguloFinal == 1350)
                {
                    MessageBox.Show("Usted recibira una pregunta de Física");                   
                    VentanaPregunta ventanaPregunta = new VentanaPregunta("fisica");
                    ventanaPregunta.ShowDialog();
                }

                if (AnguloFinal == 540 || AnguloFinal == 1620)
                {
                    MessageBox.Show("Usted recibira una pregunta de Computación");
                    VentanaPregunta ventanaPregunta = new VentanaPregunta("computación");
                    ventanaPregunta.ShowDialog();                                    
                }
                if (AnguloFinal == 810 || AnguloFinal == 1170 || AnguloFinal == 1530)
                {
                    MessageBox.Show("Usted recibira una pregunta Aleatoria");                                     
                }
                // Reiniciar el ángulo de rotación actual
                currentRotationAngle = 0f;
                // Reinicia el contador de TotalDeRotaciones
                TotalDeRotaciones = 0;
                DibujarRuleta();
            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
               
    }
}
