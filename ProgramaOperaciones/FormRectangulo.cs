﻿using System;
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
    public partial class FormRectangulo : Form
    {
        public FormRectangulo()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonRectanguloRespuesta_Click(object sender, EventArgs e)
        {
            double bas, altura, respuesta;
            bas = Double.Parse(textBoxBase.Text);
            altura = Double.Parse(textBoxAltura.Text);
            respuesta = bas * altura;
            textBoxRectanguloRespuesta.Text = respuesta.ToString();
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
