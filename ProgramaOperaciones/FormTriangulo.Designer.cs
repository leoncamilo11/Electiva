namespace ProgramaOperaciones
{
    partial class FormTriangulo
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
            this.buttonTrianguloRespuesta = new System.Windows.Forms.Button();
            this.textBoxTrianguloRespuesta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTrianguloAltura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTrianguloBase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTrianguloRespuesta
            // 
            this.buttonTrianguloRespuesta.Location = new System.Drawing.Point(214, 102);
            this.buttonTrianguloRespuesta.Name = "buttonTrianguloRespuesta";
            this.buttonTrianguloRespuesta.Size = new System.Drawing.Size(94, 38);
            this.buttonTrianguloRespuesta.TabIndex = 15;
            this.buttonTrianguloRespuesta.Text = "Calcular";
            this.buttonTrianguloRespuesta.UseVisualStyleBackColor = true;
            this.buttonTrianguloRespuesta.Click += new System.EventHandler(this.buttonTrianguloRespuesta_Click);
            // 
            // textBoxTrianguloRespuesta
            // 
            this.textBoxTrianguloRespuesta.Location = new System.Drawing.Point(419, 47);
            this.textBoxTrianguloRespuesta.Name = "textBoxTrianguloRespuesta";
            this.textBoxTrianguloRespuesta.Size = new System.Drawing.Size(100, 26);
            this.textBoxTrianguloRespuesta.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "=";
            // 
            // textBoxTrianguloAltura
            // 
            this.textBoxTrianguloAltura.Location = new System.Drawing.Point(267, 47);
            this.textBoxTrianguloAltura.Name = "textBoxTrianguloAltura";
            this.textBoxTrianguloAltura.Size = new System.Drawing.Size(102, 26);
            this.textBoxTrianguloAltura.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "*";
            // 
            // textBoxTrianguloBase
            // 
            this.textBoxTrianguloBase.Location = new System.Drawing.Point(83, 44);
            this.textBoxTrianguloBase.Name = "textBoxTrianguloBase";
            this.textBoxTrianguloBase.Size = new System.Drawing.Size(100, 26);
            this.textBoxTrianguloBase.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Base";
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(12, 117);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(46, 30);
            this.buttonRegresar.TabIndex = 16;
            this.buttonRegresar.Text = "<-";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // FormTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 159);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.buttonTrianguloRespuesta);
            this.Controls.Add(this.textBoxTrianguloRespuesta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTrianguloAltura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTrianguloBase);
            this.Controls.Add(this.label1);
            this.Name = "FormTriangulo";
            this.Text = "Area Triangulo";
            this.Load += new System.EventHandler(this.FormTriangulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTrianguloRespuesta;
        private System.Windows.Forms.TextBox textBoxTrianguloRespuesta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTrianguloAltura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTrianguloBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegresar;
    }
}