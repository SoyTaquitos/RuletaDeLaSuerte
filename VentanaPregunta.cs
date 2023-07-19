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
        private Ruleta ruleta;       
        public VentanaPregunta(Ruleta ruleta)
        {
            InitializeComponent();
            this.ruleta = ruleta;
        }
        private void VentanaPregunta_Load(object sender, EventArgs e)
        {
            //Cambios para hacer las preguntas con los Radio Botones 
            if (ruleta.AnguloFinal == 720 | ruleta.AnguloFinal == 1800)
            {
                label1.Text = "hola";
            }     
                  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Respuesta correcta");
            Close();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
