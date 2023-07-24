using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERSOR_DE_MONEDA
{
   public class ConvPesoCol
    {
        double total;
        public ConvPesoCol() 
        {
        }
        public double dolar(double a)
        {
            total = a * 0.00022;
            return total;
        }
        public double pesomex(double a)
        {
            total = a * 0.0044;
            return total;
        }
        public double euro(double a)
        {
            total = a * 0.00022;
            return total;
        }
        public double librasest(double a)
        {
            total = a * 0.00019;
            return total;
        }
        public double pesochil(double a)
        {
            total = a * 0.21;
            return total;
        }
        public double quetzal(double a)
        {
            total = a * 0.0017;
            return total;
        }
        public double yenjap(double a)
        {
            total = a * 0.032;
            return total;
        }
        public double pesoarg(double a)
        {
            total = a * 0.033;
            return total;
        }
        public double bolivianos(double a)
        {
            total = a * 0.0015;
            return total;
        }
        public double bolivarven(double a)
        {
            total = a * 0.0018;
            return total;
        }
    }
}
