using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERSOR_DE_MONEDA
{
   public class ConvQuetzal
    {
        double total;
        public ConvQuetzal() 
        { 
        }
        public double dolar(double a)
        {
            total = a * 0.13;
            return total;
        }
        public double pesomex(double a)
        {
            total = a * 2.55;
            return total;
        }
        public double euro(double a)
        {
            total = a * 0.13;
            return total;
        }
        public double librasest(double a)
        {
            total = a * 0.11;
            return total;
        }
        public double pesochil(double a)
        {
            total = a * 119.69;
            return total;
        }
        public double yenjap(double a)
        {
            total = a * 18.80;
            return total;
        }
        public double pesoarg(double a)
        {
            total = a * 19.31;
            return total;
        }
        public double pesocol(double a)
        {
            total = a * 583.85;
            return total;
        }
        public double bolivianos(double a)
        {
            total = a * 0.88;
            return total;
        }
        public double bolivarven(double a)
        {
            total = a * 1.05;
            return total;
        }
    }
}
