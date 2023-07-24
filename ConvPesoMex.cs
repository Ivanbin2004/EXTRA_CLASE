using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERSOR_DE_MONEDA
{
    public class ConvPesoMex
    {
        double total;
        public ConvPesoMex() 
        { 
        }
        public double dolar(double a)
        {
            total = a * 0.050;
            return total;
        }
        public double euro(double a)
        {
            total = a * 0.051;
            return total;
        }
        public double libraest(double a)
        {
            total = a * 0.044;
            return total;
        }
        public double pesochil(double a)
        {
            total = a * 46.97;
            return total;
        }
        public double quetzal(double a)
        {
            total = a * 0.39;
            return total;
        }
        public double yenjap(double a)
        {
            total = a * 7.37;
            return total;
        }
        public double pesoarg(double a)
        {
            total = a * 7.57;
            return total;
        }
        public double pesocol(double a)
        {
            total = a * 229.12;
            return total;
        }
        public double bolivianos(double a)
        {
            total = a * 0.34;
            return total;
        }
        public double bolivarven(double a)
        {
            total = a * 0.41;
            return total;
        }
    }
}
