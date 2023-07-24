using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERSOR_DE_MONEDA
{
   public class ConvPesoChil
    {
        double total;
        public ConvPesoChil() 
        { 
        }
        public double dolar(double a)
        {
            total = a * 0.0011;
            return total;
        }
        public double pesomex(double a)
        {
            total = a * 0.021;
            return total;
        }
        public double euro(double a)
        {
            total = a * 0.0011;
            return total;
        }
        public double librasest(double a)
        {
            total = a * 0.00094;
            return total;
        }
        public double quetzal(double a)
        {
            total = a * 0.0084;
            return total;
        }
        public double yenjap(double a)
        {
            total = a * 0.16;
            return total;
        }
        public double pesoarg(double a)
        {
            total = a * 0.27;
            return total;
        }
        public double pesocol(double a)
        {
            total = a * 30.24;
            return total;
        }
        public double bolivianos(double a)
        {
            total = a * 0.045;
            return total;
        }
        public double bolivarven(double a)
        {
            total = a * 0.055;
            return total;
        }
    }
}
