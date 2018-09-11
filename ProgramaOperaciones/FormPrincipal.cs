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
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
            //FormPrincipal fp = new FormPrincipal();
            //fp.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBoxCirculo_Click(object sender, EventArgs e)
        {
            FormCirculo fc = new FormCirculo();
            fc.StartPosition = FormStartPosition.CenterScreen;
            fc.Show();
            this.Hide();
        }

        private void pictureBoxCuadrado_Click(object sender, EventArgs e)
        {
            FormCuadrado fcu = new FormCuadrado();
            fcu.StartPosition = FormStartPosition.CenterScreen;
            fcu.Show();
            this.Hide();
        }

        private void pictureBoxRectangulo_Click(object sender, EventArgs e)
        {
            FormRectangulo fr = new FormRectangulo();
            fr.StartPosition = FormStartPosition.CenterScreen;
            fr.Show();
            this.Hide();
        }

        private void pictureBoxTriangulo_Click(object sender, EventArgs e)
        {
            FormTriangulo ft = new FormTriangulo();
            ft.StartPosition = FormStartPosition.CenterScreen;
            ft.Show();
            this.Hide();
        }
    }
}
