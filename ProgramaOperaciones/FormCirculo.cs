using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaOperaciones
{
    public partial class FormCirculo : Form
    {
        public FormCirculo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCirculo_Click(object sender, EventArgs e)
        {
            double radio, respuestaCirculo;
            double pi = 3.1514;
            radio = int.Parse(textBoxCirculoRadio.Text);
            respuestaCirculo = pi * radio;
            textBoxCirculoRespuesta.Text = respuestaCirculo.ToString();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            FormPrincipal fp = new FormPrincipal();
            fp.StartPosition = FormStartPosition.CenterScreen;
            fp.Show();
            this.Hide();
        }
    }
}
