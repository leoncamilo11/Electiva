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
    public partial class FormCuadrado : Form
    {
        public FormCuadrado()
        {
            InitializeComponent();
        }

        private void buttonCuadrado_Click(object sender, EventArgs e)
        {
            double lado, respuesCuadrado;
            lado = double.Parse(textBoxLado.Text);
            respuesCuadrado = lado * lado;
            textBoxCuadradoRespuesta.Text = respuesCuadrado.ToString();
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
