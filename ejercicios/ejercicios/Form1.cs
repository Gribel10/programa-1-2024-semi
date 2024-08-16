using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Propiedad de los operadores aritmeticos
            Boolean comprobar = true;
            Console.WriteLine("El valor es: {0}", comprobar);
            //Prioridad de los operadores aritmeticos.
            //se pone el sufijo m para la division con decimales.
            decimal respuesta = 5 + 8 - 2 * 5 / 4m + 1; //14.75 valor incorrecto; 11.5 -> Valor correcto
            Console.WriteLine("La respuesta es: {0}", respuesta);

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Hola {0} bienvenido", nombre);

            DateTime fechaActual = new DateTime();
            fechaActual = DateTime.Now;
            Console.WriteLine("La fecha actual es: {0}", fechaActual);
            Console.WriteLine("La division de 5/4 es {0}", 5 / 4);
            //Pausa.
            Console.ReadLine();
        }
    }
}
