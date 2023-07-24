using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERSOR_DE_MONEDA
{
   public class ConvEuro
    {
        double total;
        public ConvEuro() 
        { 
        }
        public double dolar(double a)
        {
            total = a * 0.98;
            return total;
        }
        public double pesomex(double a)
        {
            total = a * 19.57;
            return total;
        }
        public double librasest(double a)
        {
            total = a * 0.86;
            return total;
        }
        public double pesochil(double a)
        {
            total = a * 919.31;
            return total;
        }
        public double quetzal(double a)
        {
            total = a * 7.69;
            return total;
        }
        public double yenjap(double a)
        {
            total = a * 144.22;
            return total;
        }
        public double pesoarg(double a)
        {
            total = a * 148.30;
            return total;
        }
        public double pesocol(double a)
        {
            total = a * 4483.13;
            return total;
        }
        public double bolivianos(double a)
        {
            total = a * 6.74;
            return total;
        }
        public double bolivarven(double a)
        {
            total = a * 8.09;
            return total;
        }
    }
}
