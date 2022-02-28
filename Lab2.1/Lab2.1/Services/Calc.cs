using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2._1.Services
{
    public class Calc
    {
        public int a { get; set; }
        public int b { get; set; }

        public Calc()
        {
            Random rand = new Random();
            a = rand.Next(0, 10);
            b = rand.Next(0, 10);
        }

        public string Add()
        {
            return a + " + " + b + " = " + (a + b);
        }

        public string Sub()
        {
            return a + " - " + b + " = " + (a - b);
        }

        public string Mul()
        {
            return a + " * " + b + " = " + (a * b);
        }

        public string Div()
        {
            if (b != 0)
            {
                return a + " / " + b + " = " + (a / b);
            }
            else
            {
                return "Division by 0!";
            }
        }
    }
}

