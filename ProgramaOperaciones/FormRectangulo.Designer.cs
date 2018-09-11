namespace ProgramaOperaciones
{
    partial class FormRectangulo
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
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRectanguloRespuesta = new System.Windows.Forms.TextBox();
            this.buttonRectanguloRespuesta = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base";
            // 
            // textBoxBase
            // 
            this.textBoxBase.Location = new System.Drawing.Point(94, 51);
            this.textBoxBase.Name = "textBoxBase";
            this.textBoxBase.Size = new System.Drawing.Size(100, 26);
            this.textBoxBase.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Altura";
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(278, 54);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(102, 26);
            this.textBoxAltura.TabIndex = 4;
            this.textBoxAltura.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxRectanguloRespuesta
            // 
            this.textBoxRectanguloRespuesta.Location = new System.Drawing.Point(430, 54);
            this.textBoxRectanguloRespuesta.Name = "textBoxRectanguloRespuesta";
            this.textBoxRectanguloRespuesta.Size = new System.Drawing.Size(100, 26);
            this.textBoxRectanguloRespuesta.TabIndex = 6;
            // 
            // buttonRectanguloRespuesta
            // 
            this.buttonRectanguloRespuesta.Location = new System.Drawing.Point(225, 109);
            this.buttonRectanguloRespuesta.Name = "buttonRectanguloRespuesta";
            this.buttonRectanguloRespuesta.Size = new System.Drawing.Size(94, 38);
            this.buttonRectanguloRespuesta.TabIndex = 7;
            this.buttonRectanguloRespuesta.Text = "Calcular";
            this.buttonRectanguloRespuesta.UseVisualStyleBackColor = true;
            this.buttonRectanguloRespuesta.Click += new System.EventHandler(this.buttonRectanguloRespuesta_Click);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(12, 139);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(46, 30);
            this.buttonRegresar.TabIndex = 17;
            this.buttonRegresar.Text = "<-";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // FormRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 181);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.buttonRectanguloRespuesta);
            this.Controls.Add(this.textBoxRectanguloRespuesta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBase);
            this.Controls.Add(this.label1);
            this.Name = "FormRectangulo";
            this.Text = "Area Rectangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRectanguloRespuesta;
        private System.Windows.Forms.Button buttonRectanguloRespuesta;
        private System.Windows.Forms.Button buttonRegresar;
    }
}