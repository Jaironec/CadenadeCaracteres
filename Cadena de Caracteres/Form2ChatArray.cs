using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadena_de_Caracteres
{
    public partial class Form2ChatArray : Form
    {
        public Form2ChatArray()
        {
            InitializeComponent();
        }

        private void button1Aceptar_Click(object sender, EventArgs e)
        {
            string MyString = this.textBox1Cadena.Text;
            char Mychar = MyString[int.Parse(this.textBox1posicion.Text)];
            Console.WriteLine("El caracter es: {0}", Mychar);

            this.textBox2Resul.Text = Mychar.ToString();
        }

        private void textBox2Resul_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
