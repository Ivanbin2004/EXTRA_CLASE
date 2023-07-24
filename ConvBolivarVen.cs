using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERSOR_DE_MONEDA
{
   public class ConvBolivarVen
    {
        double total;
        public ConvBolivarVen() 
        {
        }
        public double dolar(double a)
        {
            total = a * 0.12;
            return total;
        }
        public double pesomex(double a)
        {
            total = a * 2.42;
            return total;
        }
        public double euro(double a)
        {
            total = a * 0.12;
            return total;
        }
        public double librasest(double a)
        {
            total = a * 0.11;
            return total;
        }
        public double pesochil(double a)
        {
            total = a * 113.58;
            return total;
        }
        public double quetzal(double a)
        {
            total = a * 0.95;
            return total;
        }
        public double yenjap(double a)
        {
            total = a * 17.85;
            return total;
        }
        public double pesoarg(double a)
        {
            total = a * 18.32;
            return total;
        }
        public double pesocol(double a)
        {
            total = a * 554.06;
            return total;
        }
        public double bolivianos(double a)
        {
            total = a * 0.83;
            return total;
        }
    }
}
