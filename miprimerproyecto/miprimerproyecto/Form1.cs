using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miprimerproyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //suma de dos numeros 
            Console.Write("Num1.");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Num 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int respuesta = num1 + num2;
            Console.WriteLine("La suma de {0} + {1} = {2}", num1, num2, respuesta);

            //Pausa.
            Console.ReadLine();

        }
    }
}
