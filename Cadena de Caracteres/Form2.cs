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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myString = this.textBox1cardena.Text;
            char[] myChars = myString.ToCharArray();
            //longitud de la cadena
            this.textlongitud.Text = myChars.Length.ToString();

            //cadena minuscula
            this.textminus.Text = myString.ToLower();
            //cadena mayuscula
            this.textmayus.Text = myString.ToUpper();

            //elimina espacios iniciales y finales
            this.textsinespacio.Text = myString.Trim();

            //ejemplo padleft
            this.textleft.Text = myString.PadLeft(30);
            //ejemplo PadRigth
            this.textRigth.Text = myString.PadRight(30, '+');
            for (int i=0; i<myChars.Length; i++)
            {
                Console.WriteLine($"{myChars[i]}");
            }
            //limpiar lista
            this.listBox1lista.Items.Clear();
            foreach(char caracter in myChars)
            {
                Console.WriteLine("{0}", caracter);
                this.listBox1lista.Items.Add(caracter.ToString());

            }
        }
    }
}
