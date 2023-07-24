using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERSOR_DE_MONEDA
{
    public class ConvPesoArg
    {
        double total;
        public ConvPesoArg() 
        {
        }
        public double dolar(double a)
        {
            total = a * 0.0066;
            return total;
        }
        public double pesomex(double a)
        {
            total = a * 0.13;
            return total;
        }
        public double euro(double a)
        {
            total = a * 0.0068;
            return total;
        }
        public double librasest(double a)
        {
            total = a * 0.0058;
            return total;
        }
        public double pesochil(double a)
        {
            total = a * 6.20;
            return total;
        }
        public double quetzal(double a)
        {
            total = a * 0.052;
            return total;
        }
        public double yenjap(double a)
        {
            total = a * 0.97;
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
