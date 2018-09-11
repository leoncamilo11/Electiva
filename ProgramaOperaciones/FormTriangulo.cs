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
    public partial class FormTriangulo : Form
    {
        public FormTriangulo()
        {
            InitializeComponent();
        }

        private void FormTriangulo_Load(object sender, EventArgs e)
        {

        }

        private void buttonTrianguloRespuesta_Click(object sender, EventArgs e)
        {
            double bas, altura, respuesta;
            bas = Double.Parse(textBoxTrianguloBase.Text);
            altura = Double.Parse(textBoxTrianguloAltura.Text);
            respuesta = (bas * altura)/2;
            textBoxTrianguloRespuesta.Text = respuesta.ToString();
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
