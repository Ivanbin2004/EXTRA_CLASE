using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERSOR_DE_MONEDA
{
    public class ConvDolarAm
    {
        double total;
    public ConvDolarAm()
        {
        }
        public double peso (double a)
        {
            total = a * 19.98;
            return total;
        }
        public double euro(double a)
        {
            total = a * 1.02;
            return total;
        }
        public double libraesterlina(double a)
        {
            total = a * 0.88;
            return total;
        }
        public double pesochileno(double a)
        {
            total = a * 938.01;
            return total;
        }
        public double quetzal(double a)
        {
            total = a * 7.84;
            return total;
        }
        public double yenjapones(double a)
        {
            total = a * 147.32;
            return total;
        }
        public double pesoarg(double a)
        {
            total = a * 151.29;
            return total;
        }
        public double pesocol(double a)
        {
            total = a * 4575.71;
            return total;
        }
        public double bolivianos(double a)
        {
            total = a * 6.88;
            return total;
        }
        public double bolivarvenez(double a)
        {
            total = a * 8.26;
            return total;
        }
    }
}
