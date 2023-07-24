using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERSOR_DE_MONEDA
{
   public class ConvLibraEst
    {
        double total;
        public ConvLibraEst()
        {
        }
        public double dolar(double a)
        {
            total = a * 1.13;
            return total;
        }
        public double pesomex(double a)
        {
            total = a * 22.64;
            return total;
        }
        public double euro(double a)
        {
            total = a * 1.16;
            return total;
        }
        public double pesochil(double a)
        {
            total = a * 1063.17;
            return total;
        }
        public double quetzal(double a)
        {
            total = a * 8.89;
            return total;
        }
        public double yenjap(double a)
        {
            total = a * 166.95;
            return total;
        }
        public double pesoarg(double a)
        {
            total = a * 171.49;
            return total;
        }
        public double pesocol(double a)
        {
            total = a * 5183.27;
            return total;
        }
        public double bolivianos(double a)
        {
            total = a * 7.80;
            return total;
        }
        public double bolivarven(double a)
        {
            total = a * 9.36;
            return total;
        }
    }
}
