using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codigos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //suma de dos numeros pero con el tipo sbyte

            Console.Write("Num1: ");
            int num1 = int.Parse(Console.ReadLine());
            sbyte num1 = sbyte.Parse(Console.ReadLine());

            Console.Write("Num 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Num2: ");
            sbyte num2 = sbyte.Parse(Console.ReadLine());

            int respuesta = num1 + num2;
            Console.WriteLine("La suma de {0} + {1} = {2}", num1, num2, respuesta);
            int suma = num1 + num2;

            Console.WriteLine("La suma de {0} + {1} = {2}", num1, num2, suma);

            //Pausa.
            Console.ReadLine();
        }
    }
}
