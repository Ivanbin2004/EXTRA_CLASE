using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERSOR_DE_MONEDA
{
  public  class ConvYenJap
    {
        double total;
        public ConvYenJap() 
        {
        }
        public double dolar(double a)
        {
            total = a * 0.0068;
            return total;
        }
        public double pesomex(double a)
        {
            total = a * 0.14;
            return total;
        }
        public double euro(double a)
        {
            total = a * 0.0069;
            return total;
        }
        public double librasest(double a)
        {
            total = a * 0.0060;
            return total;
        }
        public double pesochil(double a)
        {
            total = a * 6.37;
            return total;
        }
        public double quetzal(double a)
        {
            total = a * 0.053;
            return total;
        }
        public double pesoarg(double a)
        {
            total = a * 1.03;
            return total;
        }
        public double pesocol(double a)
        {
            total = a * 31.06;
            return total;
        }
        public double bolivianos(double a)
        {
            total = a * 0.047;
            return total;
        }
        public double bolivarven(double a)
        {
            total = a * 0.056;
            return total;
        }
    }
}
