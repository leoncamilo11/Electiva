namespace ProgramaOperaciones
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxTriangulo = new System.Windows.Forms.PictureBox();
            this.pictureBoxRectangulo = new System.Windows.Forms.PictureBox();
            this.pictureBoxCuadrado = new System.Windows.Forms.PictureBox();
            this.pictureBoxCirculo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTriangulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectangulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuadrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCirculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Area Figuras";
            // 
            // pictureBoxTriangulo
            // 
            this.pictureBoxTriangulo.Image = global::ProgramaOperaciones.Properties.Resources.triangulo;
            this.pictureBoxTriangulo.Location = new System.Drawing.Point(613, 279);
            this.pictureBoxTriangulo.Name = "pictureBoxTriangulo";
            this.pictureBoxTriangulo.Size = new System.Drawing.Size(148, 132);
            this.pictureBoxTriangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTriangulo.TabIndex = 3;
            this.pictureBoxTriangulo.TabStop = false;
            this.pictureBoxTriangulo.Click += new System.EventHandler(this.pictureBoxTriangulo_Click);
            // 
            // pictureBoxRectangulo
            // 
            this.pictureBoxRectangulo.Image = global::ProgramaOperaciones.Properties.Resources.rectangulo;
            this.pictureBoxRectangulo.Location = new System.Drawing.Point(420, 116);
            this.pictureBoxRectangulo.Name = "pictureBoxRectangulo";
            this.pictureBoxRectangulo.Size = new System.Drawing.Size(147, 132);
            this.pictureBoxRectangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRectangulo.TabIndex = 2;
            this.pictureBoxRectangulo.TabStop = false;
            this.pictureBoxRectangulo.Click += new System.EventHandler(this.pictureBoxRectangulo_Click);
            // 
            // pictureBoxCuadrado
            // 
            this.pictureBoxCuadrado.Image = global::ProgramaOperaciones.Properties.Resources.cuadrado;
            this.pictureBoxCuadrado.InitialImage = global::ProgramaOperaciones.Properties.Resources.cuadrado;
            this.pictureBoxCuadrado.Location = new System.Drawing.Point(232, 279);
            this.pictureBoxCuadrado.Name = "pictureBoxCuadrado";
            this.pictureBoxCuadrado.Size = new System.Drawing.Size(144, 132);
            this.pictureBoxCuadrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCuadrado.TabIndex = 1;
            this.pictureBoxCuadrado.TabStop = false;
            this.pictureBoxCuadrado.Click += new System.EventHandler(this.pictureBoxCuadrado_Click);
            // 
            // pictureBoxCirculo
            // 
            this.pictureBoxCirculo.Image = global::ProgramaOperaciones.Properties.Resources.circulo;
            this.pictureBoxCirculo.InitialImage = global::ProgramaOperaciones.Properties.Resources.circulo;
            this.pictureBoxCirculo.Location = new System.Drawing.Point(41, 116);
            this.pictureBoxCirculo.Name = "pictureBoxCirculo";
            this.pictureBoxCirculo.Size = new System.Drawing.Size(139, 132);
            this.pictureBoxCirculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCirculo.TabIndex = 0;
            this.pictureBoxCirculo.TabStop = false;
            this.pictureBoxCirculo.Click += new System.EventHandler(this.pictureBoxCirculo_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxTriangulo);
            this.Controls.Add(this.pictureBoxRectangulo);
            this.Controls.Add(this.pictureBoxCuadrado);
            this.Controls.Add(this.pictureBoxCirculo);
            this.Name = "FormPrincipal";
            this.Text = "Programa Operaciones Figuras";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTriangulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectangulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCuadrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCirculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCirculo;
        private System.Windows.Forms.PictureBox pictureBoxCuadrado;
        private System.Windows.Forms.PictureBox pictureBoxRectangulo;
        private System.Windows.Forms.PictureBox pictureBoxTriangulo;
        private System.Windows.Forms.Label label1;
    }
}

