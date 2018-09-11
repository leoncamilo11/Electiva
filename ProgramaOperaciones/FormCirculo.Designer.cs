namespace ProgramaOperaciones
{
    partial class FormCirculo
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
            this.textBoxCirculoRadio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCirculoRespuesta = new System.Windows.Forms.TextBox();
            this.buttonCirculo = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radio";
            // 
            // textBoxCirculoRadio
            // 
            this.textBoxCirculoRadio.Location = new System.Drawing.Point(126, 50);
            this.textBoxCirculoRadio.Name = "textBoxCirculoRadio";
            this.textBoxCirculoRadio.Size = new System.Drawing.Size(100, 26);
            this.textBoxCirculoRadio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxCirculoRespuesta
            // 
            this.textBoxCirculoRespuesta.Location = new System.Drawing.Point(296, 50);
            this.textBoxCirculoRespuesta.Name = "textBoxCirculoRespuesta";
            this.textBoxCirculoRespuesta.Size = new System.Drawing.Size(93, 26);
            this.textBoxCirculoRespuesta.TabIndex = 3;
            // 
            // buttonCirculo
            // 
            this.buttonCirculo.Location = new System.Drawing.Point(173, 113);
            this.buttonCirculo.Name = "buttonCirculo";
            this.buttonCirculo.Size = new System.Drawing.Size(108, 37);
            this.buttonCirculo.TabIndex = 4;
            this.buttonCirculo.Text = "Calcular";
            this.buttonCirculo.UseVisualStyleBackColor = true;
            this.buttonCirculo.Click += new System.EventHandler(this.buttonCirculo_Click);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(12, 135);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(46, 30);
            this.buttonRegresar.TabIndex = 17;
            this.buttonRegresar.Text = "<-";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // FormCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 177);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.buttonCirculo);
            this.Controls.Add(this.textBoxCirculoRespuesta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCirculoRadio);
            this.Controls.Add(this.label1);
            this.Name = "FormCirculo";
            this.Text = "Area Circulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCirculoRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCirculoRespuesta;
        private System.Windows.Forms.Button buttonCirculo;
        private System.Windows.Forms.Button buttonRegresar;
    }
}