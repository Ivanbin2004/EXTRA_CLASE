using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONVERSOR_DE_MONEDA
{
    public partial class Form1 : Form
    {
        double a;
            double total1, total2, total3, total4, total5, total6, total7,total8, total9, total10;

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }
        ConvDolarAm dolarAm = new ConvDolarAm();
        ConvPesoMex peso = new ConvPesoMex();
        ConvEuro euro = new ConvEuro();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        ConvLibraEst libra = new ConvLibraEst();
        ConvPesoChil chileno = new ConvPesoChil();
        ConvQuetzal quetzales = new ConvQuetzal();
        ConvYenJap yen = new ConvYenJap();
        ConvPesoArg ar = new ConvPesoArg();
        ConvPesoCol c = new ConvPesoCol();
        ConvBolivianos b = new ConvBolivianos();
        ConvBolivarVen ven = new ConvBolivarVen();
        private void button1_Click(object sender, EventArgs e)
        {
            int d = dataGridView1.Rows.Add();
            if (radioButton1.Checked == true)
            {
                a = Convert.ToDouble(textBox1.Text);
                total1 = dolarAm.peso(a);
                total2 = dolarAm.euro(a);
                total3 = dolarAm.libraesterlina(a);
                total4 = dolarAm.pesochileno(a);
                total5 = dolarAm.quetzal(a);
                total6 = dolarAm.yenjapones(a);
                total7 = dolarAm.pesoarg(a);
                total8 = dolarAm.pesocol(a);
                total9 = dolarAm.bolivianos(a);
                total10 = dolarAm.bolivarvenez(a);

                dataGridView1.Rows[d].Cells[1].Value = total1;
                dataGridView1.Rows[d].Cells[2].Value = total2;
                dataGridView1.Rows[d].Cells[3].Value = total3;
                dataGridView1.Rows[d].Cells[4].Value = total4;
                dataGridView1.Rows[d].Cells[5].Value = total5;
                dataGridView1.Rows[d].Cells[6].Value = total6;
                dataGridView1.Rows[d].Cells[7].Value = total7;
                dataGridView1.Rows[d].Cells[8].Value = total8;
                dataGridView1.Rows[d].Cells[9].Value = total9;
                dataGridView1.Rows[d].Cells[10].Value = total10;

            }
            if (radioButton2.Checked == true)
            {
                a = Convert.ToDouble(textBox1.Text);
                total1 = peso.dolar(a);
                total2 = peso.euro(a);
                total3 = peso.libraest(a);
                total4 = peso.pesochil(a);
                total5 = peso.quetzal(a);
                total6 = peso.yenjap(a);
                total7 = peso.pesoarg(a);
                total8 = peso.pesocol(a);
                total9 = peso.bolivianos(a);
                total10 = peso.bolivarven(a);

                dataGridView1.Rows[d].Cells[0].Value = total1;
                dataGridView1.Rows[d].Cells[2].Value = total2;
                dataGridView1.Rows[d].Cells[3].Value = total3;
                dataGridView1.Rows[d].Cells[4].Value = total4;
                dataGridView1.Rows[d].Cells[5].Value = total5;
                dataGridView1.Rows[d].Cells[6].Value = total6;
                dataGridView1.Rows[d].Cells[7].Value = total7;
                dataGridView1.Rows[d].Cells[8].Value = total8;
                dataGridView1.Rows[d].Cells[9].Value = total9;
                dataGridView1.Rows[d].Cells[10].Value = total10;
            }
            if (radioButton3.Checked == true)
            {
                a = Convert.ToDouble(textBox1.Text);
                total1 = euro.dolar(a);
                total2 = euro.pesomex(a);
                total3 = euro.librasest(a);
                total4 = euro.pesochil(a);
                total5 = euro.quetzal(a);
                total6 = euro.yenjap(a);
                total7 = euro.pesoarg(a);
                total8 = euro.pesocol(a);
                total9 = euro.bolivianos(a);
                total10 = euro.bolivarven(a);

                dataGridView1.Rows[d].Cells[0].Value = total1;
                dataGridView1.Rows[d].Cells[1].Value = total2;
                dataGridView1.Rows[d].Cells[3].Value = total3;
                dataGridView1.Rows[d].Cells[4].Value = total4;
                dataGridView1.Rows[d].Cells[5].Value = total5;
                dataGridView1.Rows[d].Cells[6].Value = total6;
                dataGridView1.Rows[d].Cells[7].Value = total7;
                dataGridView1.Rows[d].Cells[8].Value = total8;
                dataGridView1.Rows[d].Cells[9].Value = total9;
                dataGridView1.Rows[d].Cells[10].Value = total10;
            }
            if (radioButton4.Checked == true)
            {
                a = Convert.ToDouble(textBox1.Text);
                total1 = libra.dolar(a);
                total2 = libra.pesomex(a);
                total3 = libra.euro(a);
                total4 = libra.pesochil(a);
                total5 = libra.quetzal(a);
                total6 = libra.yenjap(a);
                total7 = libra.pesoarg(a);
                total8 = libra.pesocol(a);
                total9 = libra.bolivianos(a);
                total10 = libra.bolivarven(a);

                dataGridView1.Rows[d].Cells[0].Value = total1;
                dataGridView1.Rows[d].Cells[1].Value = total2;
                dataGridView1.Rows[d].Cells[2].Value = total3;
                dataGridView1.Rows[d].Cells[4].Value = total4;
                dataGridView1.Rows[d].Cells[5].Value = total5;
                dataGridView1.Rows[d].Cells[6].Value = total6;
                dataGridView1.Rows[d].Cells[7].Value = total7;
                dataGridView1.Rows[d].Cells[8].Value = total8;
                dataGridView1.Rows[d].Cells[9].Value = total9;
                dataGridView1.Rows[d].Cells[10].Value = total10;
            }
            if (radioButton5.Checked == true)
            {
                a = Convert.ToDouble(textBox1.Text);
                total1 = chileno.dolar(a);
                total2 = chileno.pesomex(a);
                total3 = chileno.euro(a);
                total4 = chileno.librasest(a);
                total5 = chileno.quetzal(a);
                total6 = chileno.yenjap(a);
                total7 = chileno.pesoarg(a);
                total8 = chileno.pesocol(a);
                total9 = chileno.bolivianos(a);
                total10 = chileno.bolivarven(a);

                dataGridView1.Rows[d].Cells[0].Value = total1;
                dataGridView1.Rows[d].Cells[1].Value = total2;
                dataGridView1.Rows[d].Cells[2].Value = total3;
                dataGridView1.Rows[d].Cells[3].Value = total4;
                dataGridView1.Rows[d].Cells[5].Value = total5;
                dataGridView1.Rows[d].Cells[6].Value = total6;
                dataGridView1.Rows[d].Cells[7].Value = total7;
                dataGridView1.Rows[d].Cells[8].Value = total8;
                dataGridView1.Rows[d].Cells[9].Value = total9;
                dataGridView1.Rows[d].Cells[10].Value = total10;
            }
            if (radioButton6.Checked == true)
            {
                a = Convert.ToDouble(textBox1.Text);
                total1 = quetzales.dolar(a);
                total2 = quetzales.pesomex(a);
                total3 = quetzales.euro(a);
                total4 = quetzales.librasest(a);
                total5 = quetzales.pesochil(a);
                total6 = quetzales.yenjap(a);
                total7 = quetzales.pesoarg(a);
                total8 = quetzales.pesocol(a);
                total9 = quetzales.bolivianos(a);
                total10 = quetzales.bolivarven(a);

                dataGridView1.Rows[d].Cells[0].Value = total1;
                dataGridView1.Rows[d].Cells[1].Value = total2;
                dataGridView1.Rows[d].Cells[2].Value = total3;
                dataGridView1.Rows[d].Cells[3].Value = total4;
                dataGridView1.Rows[d].Cells[4].Value = total5;
                dataGridView1.Rows[d].Cells[6].Value = total6;
                dataGridView1.Rows[d].Cells[7].Value = total7;
                dataGridView1.Rows[d].Cells[8].Value = total8;
                dataGridView1.Rows[d].Cells[9].Value = total9;
                dataGridView1.Rows[d].Cells[10].Value = total10;
            }
            if (radioButton7.Checked == true)
            {
                a = Convert.ToDouble(textBox1.Text);
                total1 = yen.dolar(a);
                total2 = yen.pesomex(a);
                total3 = yen.euro(a);
                total4 = yen.librasest(a);
                total5 = yen.pesochil(a);
                total6 = yen.quetzal(a);
                total7 = yen.pesoarg(a);
                total8 = yen.pesocol(a);
                total9 = yen.bolivianos(a);
                total10 = yen.bolivarven(a);

                dataGridView1.Rows[d].Cells[0].Value = total1;
                dataGridView1.Rows[d].Cells[1].Value = total2;
                dataGridView1.Rows[d].Cells[2].Value = total3;
                dataGridView1.Rows[d].Cells[3].Value = total4;
                dataGridView1.Rows[d].Cells[4].Value = total5;
                dataGridView1.Rows[d].Cells[5].Value = total6;
                dataGridView1.Rows[d].Cells[7].Value = total7;
                dataGridView1.Rows[d].Cells[8].Value = total8;
                dataGridView1.Rows[d].Cells[9].Value = total9;
                dataGridView1.Rows[d].Cells[10].Value = total10;
            }
            if (radioButton8.Checked == true)
            {
                a = Convert.ToDouble(textBox1.Text);
                total1 = ar.dolar(a);
                total2 = ar.pesomex(a);
                total3 = ar.euro(a);
                total4 = ar.librasest(a);
                total5 = ar.pesochil(a);
                total6 = ar.quetzal(a);
                total7 = ar.yenjap(a);
                total8 = ar.pesocol(a);
                total9 = ar.bolivianos(a);
                total10 = ar.bolivarven(a);

                dataGridView1.Rows[d].Cells[0].Value = total1;
                dataGridView1.Rows[d].Cells[1].Value = total2;
                dataGridView1.Rows[d].Cells[2].Value = total3;
                dataGridView1.Rows[d].Cells[3].Value = total4;
                dataGridView1.Rows[d].Cells[4].Value = total5;
                dataGridView1.Rows[d].Cells[5].Value = total6;
                dataGridView1.Rows[d].Cells[6].Value = total7;
                dataGridView1.Rows[d].Cells[8].Value = total8;
                dataGridView1.Rows[d].Cells[9].Value = total9;
                dataGridView1.Rows[d].Cells[10].Value = total10;
            }
            if (radioButton9.Checked == true)
            {
                a = Convert.ToDouble(textBox1.Text);
                total1 = c.dolar(a);
                total2 = c.pesomex(a);
                total3 = c.euro(a);
                total4 = c.librasest(a);
                total5 = c.pesochil(a);
                total6 = c.quetzal(a);
                total7 = c.yenjap(a);
                total8 = c.pesoarg(a);
                total9 = c.bolivianos(a);
                total10 = c.bolivarven(a);

                dataGridView1.Rows[d].Cells[0].Value = total1;
                dataGridView1.Rows[d].Cells[1].Value = total2;
                dataGridView1.Rows[d].Cells[2].Value = total3;
                dataGridView1.Rows[d].Cells[3].Value = total4;
                dataGridView1.Rows[d].Cells[4].Value = total5;
                dataGridView1.Rows[d].Cells[5].Value = total6;
                dataGridView1.Rows[d].Cells[6].Value = total7;
                dataGridView1.Rows[d].Cells[7].Value = total8;
                dataGridView1.Rows[d].Cells[9].Value = total9;
                dataGridView1.Rows[d].Cells[10].Value = total10;
            }
            if (radioButton10.Checked == true)
            {
                a = Convert.ToDouble(textBox1.Text);
                total1 = b.dolar(a);
                total2 = b.pesomex(a);
                total3 = b.euro(a);
                total4 = b.librasest(a);
                total5 = b.pesochil(a);
                total6 = b.quetzal(a);
                total7 = b.yenjap(a);
                total8 = b.pesoarg(a);
                total9 = b.pesocol(a);
                total10 = b.bolivarven(a);

                dataGridView1.Rows[d].Cells[0].Value = total1;
                dataGridView1.Rows[d].Cells[1].Value = total2;
                dataGridView1.Rows[d].Cells[2].Value = total3;
                dataGridView1.Rows[d].Cells[3].Value = total4;
                dataGridView1.Rows[d].Cells[4].Value = total5;
                dataGridView1.Rows[d].Cells[5].Value = total6;
                dataGridView1.Rows[d].Cells[6].Value = total7;
                dataGridView1.Rows[d].Cells[7].Value = total8;
                dataGridView1.Rows[d].Cells[8].Value = total9;
                dataGridView1.Rows[d].Cells[10].Value = total10;
            }
            if (radioButton11.Checked == true)
            {
                a = Convert.ToDouble(textBox1.Text);
                total1 = ven.dolar(a);
                total2 = ven.pesomex(a);
                total3 = ven.euro(a);
                total4 = ven.librasest(a);
                total5 = ven.pesochil(a);
                total6 = ven.quetzal(a);
                total7 = ven.yenjap(a);
                total8 = ven.pesoarg(a);
                total9 = ven.pesocol(a);
                total10 = ven.bolivianos(a);

                dataGridView1.Rows[d].Cells[0].Value = total1;
                dataGridView1.Rows[d].Cells[1].Value = total2;
                dataGridView1.Rows[d].Cells[2].Value = total3;
                dataGridView1.Rows[d].Cells[3].Value = total4;
                dataGridView1.Rows[d].Cells[4].Value = total5;
                dataGridView1.Rows[d].Cells[5].Value = total6;
                dataGridView1.Rows[d].Cells[6].Value = total7;
                dataGridView1.Rows[d].Cells[7].Value = total8;
                dataGridView1.Rows[d].Cells[9].Value = total9;
                dataGridView1.Rows[d].Cells[10].Value = total10;
            }

        }
    }
}
