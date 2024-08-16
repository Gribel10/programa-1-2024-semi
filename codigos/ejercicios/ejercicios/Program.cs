using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uso de matrices. Calcular el suelo de una persona.
            Console.Write("Sueldo: ");
            double sueldo = double.Parse(Console.ReadLine()),
                afp = sueldo * 6.25 / 100,
                isss = sueldo * 3 / 100;
            isss = sueldo * 3 / 100,
                isr = 0;
            sueldo -= afp;

            double isr = 0;
            for (int i = 0; i < 5; i++)
            {
                if (sueldo >= matriz[i, 0] && sueldo <= matriz[i, 1])
                {
                    isr = (sueldo - (matriz[i, 0] - 0.01)) * matriz[i, 2] / 100 + matriz[i, 3];

                    //Pausa
                    Console.ReadLine();







                }
        }
    }
