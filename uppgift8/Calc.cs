using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift8
{
    class Calc
    {
        double numOne { get; set; }
        double numTwo { get; set; }

        public Calc(double a, double b) 
        {
            numOne = a;
            numTwo = b;
        }

        public double Add()
        {
            double result = numOne + numTwo;
            return result;
        }
        public double Sub()
        {
            double result = numOne - numTwo;
            return result;
        }
        public double Multi()
        {
            double result = numOne * numTwo;
            return result;
        }
        public double Div()
        {
            double result = numOne / numTwo;
            return result;
        }
    }
}
