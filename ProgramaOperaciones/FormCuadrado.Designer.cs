namespace ProgramaOperaciones
{
    partial class FormCuadrado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCuadradoRespuesta = new System.Windows.Forms.TextBox();
            this.buttonCuadrado = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado";
            // 
            // textBoxLado
            // 
            this.textBoxLado.Location = new System.Drawing.Point(109, 50);
            this.textBoxLado.Name = "textBoxLado";
            this.textBoxLado.Size = new System.Drawing.Size(100, 26);
            this.textBoxLado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            // 
            // textBoxCuadradoRespuesta
            // 
            this.textBoxCuadradoRespuesta.Location = new System.Drawing.Point(276, 50);
            this.textBoxCuadradoRespuesta.Name = "textBoxCuadradoRespuesta";
            this.textBoxCuadradoRespuesta.Size = new System.Drawing.Size(101, 26);
            this.textBoxCuadradoRespuesta.TabIndex = 3;
            // 
            // buttonCuadrado
            // 
            this.buttonCuadrado.Location = new System.Drawing.Point(179, 108);
            this.buttonCuadrado.Name = "buttonCuadrado";
            this.buttonCuadrado.Size = new System.Drawing.Size(92, 37);
            this.buttonCuadrado.TabIndex = 4;
            this.buttonCuadrado.Text = "Calcular";
            this.buttonCuadrado.UseVisualStyleBackColor = true;
            this.buttonCuadrado.Click += new System.EventHandler(this.buttonCuadrado_Click);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(12, 132);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(46, 30);
            this.buttonRegresar.TabIndex = 17;
            this.buttonRegresar.Text = "<-";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // FormCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 174);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.buttonCuadrado);
            this.Controls.Add(this.textBoxCuadradoRespuesta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLado);
            this.Controls.Add(this.label1);
            this.Name = "FormCuadrado";
            this.Text = "Area Cuadrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCuadradoRespuesta;
        private System.Windows.Forms.Button buttonCuadrado;
        private System.Windows.Forms.Button buttonRegresar;
    }
}