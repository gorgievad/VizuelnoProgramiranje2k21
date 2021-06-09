using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        Double result = 0.0;
        bool done = false;
        String prev = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void backspaceSign_Click(object sender, EventArgs e)
        { // da se izbrise brojceto
            textBox1.Clear();
            label1.Text = " ";
        }

        private void number3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") // za da ne se napisat brojkite vrz defaultnata nula
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "3";
        }

        private void number8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") // za da ne se napisat brojkite vrz defaultnata nula
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "8";
        }

        private void number7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") // za da ne se napisat brojkite vrz defaultnata nula
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "7";
        }

        private void number6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") // za da ne se napisat brojkite vrz defaultnata nula
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "6";
        }

        private void number5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") // za da ne se napisat brojkite vrz defaultnata nula
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "5";
        }

        private void number4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") // za da ne se napisat brojkite vrz defaultnata nula
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "4";
        }

        private void number9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") // za da ne se napisat brojkite vrz defaultnata nula
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "9";
        }

        private void number2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") // za da ne se napisat brojkite vrz defaultnata nula
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "2";
        }

        private void number1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") // za da ne se napisat brojkite vrz defaultnata nula
                textBox1.Clear();
            textBox1.Text = textBox1.Text+"1";
        }

        private void number0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") // za da ne se napisat brojkite vrz defaultnata nula
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "0";
        }

        private void periodSign_Click(object sender, EventArgs e)
        { // za da dozvole samo 1 tocka da moze se napise kaj decimalnite
            if (textBox1.Text.Contains(".")==false)
                textBox1.Text = textBox1.Text + ".";
        }
        private void basicoperands(String name)
        {
            label1.Text = label1.Text + textBox1.Text + name;
            textBox1.Clear();
        }
        private void otheroperands(String name)
        {
            label1.Text = label1.Text + name + "(" + textBox1.Text + ")"; // voa e za log (x), ln (x), factorial (x), trigonometriskite
            textBox1.Clear();
        }
        private void multSign_Click(object sender, EventArgs e)
        {
            basicoperands(multSign.Text);
        }

        private void divisionSign_Click(object sender, EventArgs e)
        {
            basicoperands(divisionSign.Text);
        }

        private void minusSign_Click(object sender, EventArgs e)
        {
            basicoperands(minusSign.Text);
        }

        private void plusSign_Click(object sender, EventArgs e)
        {
            basicoperands(plusSign.Text);
        }

        private void rootFunction_Click(object sender, EventArgs e)
        {
            otheroperands(rootFunction.Name);
        }

        private void xpoweryFunction_Click(object sender, EventArgs e)
        {
            otheroperands(xpoweryFunction.Name);
        }

        private void tenpowerxFunction_Click(object sender, EventArgs e)
        {
            otheroperands(tenpowerxFunction.Name);
        }

        private void logFunction_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                otheroperands(logFunction.Text);
            }
            else
            {
                MessageBox.Show("Мора да внесете бројка прво");
            }
        }

        private void lnFunction_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                otheroperands(lnFunction.Text);
            }
            else
            {
                MessageBox.Show("Мора да внесете бројка прво");
            }
        }

        private void xsquaredFunction_Click(object sender, EventArgs e)
        {
            otheroperands(xsquaredFunction.Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nfactorialFunction_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                otheroperands("fact");
            }
            else
            {
                MessageBox.Show("Мора да внесете бројка прво");
            }
        }

        private void piSign_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") // za da ne se napisat brojkite vrz defaultnata nula
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "3.14159265358979323";
        }

        private void eSign_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") // za da ne se napisat brojkite vrz defaultnata nula
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "2.71828182845904523";
        }

        private void sinFunction_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                otheroperands(sinFunction.Text);
            }
            else
            {
                MessageBox.Show("Мора да внесете бројка прво");
            }
        }

        private void tanFunction_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                otheroperands(tanFunction.Text);
            }
            else
            {
                MessageBox.Show("Мора да внесете бројка прво");
            }
        }

        private void cosFunction_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                otheroperands(cosFunction.Text);
            }
            else
            {
                MessageBox.Show("Мора да внесете бројка прво");
            }
        }

        private void cotFunction_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                otheroperands(cotFunction.Text);
            }
            else 
            {
                MessageBox.Show("Мора да внесете бројка прво");
            }
        }
    }
}
