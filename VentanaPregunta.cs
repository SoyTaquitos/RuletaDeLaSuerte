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
        public VentanaPregunta()
        {
            InitializeComponent();
        }

        private void VentanaPregunta_Load(object sender, EventArgs e)
        {
            //Cambios para hacer las preguntas con los Radio Botones
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
