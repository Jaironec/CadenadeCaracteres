
namespace Cadena_de_Caracteres
{
    partial class Form2ChatArray
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
            this.textBox1Cadena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2Resul = new System.Windows.Forms.TextBox();
            this.button1Aceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1posicion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa una cadena de caracteres";
            // 
            // textBox1Cadena
            // 
            this.textBox1Cadena.Location = new System.Drawing.Point(188, 43);
            this.textBox1Cadena.Name = "textBox1Cadena";
            this.textBox1Cadena.Size = new System.Drawing.Size(185, 20);
            this.textBox1Cadena.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "El carácter de la posición";
            // 
            // textBox2Resul
            // 
            this.textBox2Resul.Location = new System.Drawing.Point(153, 137);
            this.textBox2Resul.Name = "textBox2Resul";
            this.textBox2Resul.Size = new System.Drawing.Size(100, 20);
            this.textBox2Resul.TabIndex = 4;
            this.textBox2Resul.TextChanged += new System.EventHandler(this.textBox2Resul_TextChanged);
            // 
            // button1Aceptar
            // 
            this.button1Aceptar.Location = new System.Drawing.Point(30, 181);
            this.button1Aceptar.Name = "button1Aceptar";
            this.button1Aceptar.Size = new System.Drawing.Size(75, 23);
            this.button1Aceptar.TabIndex = 5;
            this.button1Aceptar.Text = "Aceptar";
            this.button1Aceptar.UseVisualStyleBackColor = true;
            this.button1Aceptar.Click += new System.EventHandler(this.button1Aceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese el Caracter a Mostrar";
            // 
            // textBox1posicion
            // 
            this.textBox1posicion.Location = new System.Drawing.Point(161, 88);
            this.textBox1posicion.Name = "textBox1posicion";
            this.textBox1posicion.Size = new System.Drawing.Size(100, 20);
            this.textBox1posicion.TabIndex = 7;
            // 
            // Form2ChatArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 215);
            this.Controls.Add(this.textBox1posicion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1Aceptar);
            this.Controls.Add(this.textBox2Resul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1Cadena);
            this.Controls.Add(this.label1);
            this.Name = "Form2ChatArray";
            this.Text = "Jairon Ejercicio Form2ChatArray";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1Cadena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2Resul;
        private System.Windows.Forms.Button button1Aceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1posicion;
    }
}