using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERSOR_DE_MONEDA
{
   public class ConvBolivianos
    {
        double total;
        public ConvBolivianos() 
        {
        }
        public double dolar(double a)
        {
            total = a * 0.15;
            return total;
        }
        public double pesomex(double a)
        {
            total = a * 2.91;
            return total;
        }
        public double euro(double a)
        {
            total = a * 0.15;
            return total;
        }
        public double librasest(double a)
        {
            total = a * 0.13;
            return total;
        }
        public double pesochil(double a)
        {
            total = a * 136.48;
            return total;
        }
        public double quetzal(double a)
        {
            total = a * 1.14;
            return total;
        }
        public double yenjap(double a)
        {
            total = a * 21.44;
            return total;
        }
        public double pesoarg(double a)
        {
            total = a * 22.01;
            return total;
        }
        public double pesocol(double a)
        {
            total = a * 665.75;
            return total;
        }
        public double bolivarven(double a)
        {
            total = a * 1.20;
            return total;
        }
    }
}
