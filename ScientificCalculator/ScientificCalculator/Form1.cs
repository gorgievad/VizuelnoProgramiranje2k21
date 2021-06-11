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
        Double prev = 0;
        Double saved = 0;
        String op = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void backspaceSign_Click(object sender, EventArgs e)
        { // da se izbrise brojceto
            textBox1.Clear();
            label1.Text = " ";
            done = false;
            result = 0.0;
            prev = 0;
        }

        private void number3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || done == true) // za da ne se napisat brojkite vrz defaultnata nula
            {
                textBox1.Clear();
                label1.Text = "";
            }
            done = false;
            textBox1.Text = textBox1.Text + "3";
            //prev = 3;
        }

        private void number8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || done == true)
            {
                textBox1.Clear();
                label1.Text = "";
            }
            done = false;
            textBox1.Text = textBox1.Text + "8";
            //prev = 8;
        }

        private void number7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || done == true) 
            {
                textBox1.Clear();
                label1.Text = "";
            }
            done = false;
            textBox1.Text = textBox1.Text + "7";
            //prev = 7;
        }

        private void number6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || done == true) // za da ne se napisat brojkite vrz defaultnata nula
            {
                textBox1.Clear();
                label1.Text = "";
            }
            done = false;
            textBox1.Text = textBox1.Text + "6";
            //prev = 6;
        }

        private void number5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || done == true) // za da ne se napisat brojkite vrz defaultnata nula
            {
                textBox1.Clear();
                label1.Text = "";
            }
            done = false;
            textBox1.Text = textBox1.Text + "5";
            //prev = 5;
        }

        private void number4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || done == true) 
            {
                textBox1.Clear();
                label1.Text = "";
            }
            done = false;
            textBox1.Text = textBox1.Text + "4";
            //prev = 4;
        }

        private void number9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || done == true)
            {
                textBox1.Clear();
                label1.Text = "";
            }
            done = false;
            textBox1.Text = textBox1.Text + "9";
            //prev = 9;
        }

        private void number2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || done == true)
            {
                textBox1.Clear();
                label1.Text = "";
            }
            done = false;
            textBox1.Text = textBox1.Text + "2";
            //prev = 2;
        }

        private void number1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || done == true)
            {
                textBox1.Clear();
                label1.Text = "";
            }
            done = false;
            textBox1.Text = textBox1.Text + "1";
            //prev = 1;
        }

        private void number0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || done == true)
            {
                textBox1.Clear();
                label1.Text = "";
            }
            done = false;
            textBox1.Text = textBox1.Text + "0";
            //prev = 0;
        }

        private void periodSign_Click(object sender, EventArgs e)
        { // za da dozvole samo 1 zapirka da moze se napise kaj decimalnite
            if (textBox1.Text.Contains(",") == false)
                textBox1.Text = textBox1.Text + ",";
            prev = Double.Parse(textBox1.Text);
            done = false;
        }
        private void basicoperands(String name)
        {
            if (textBox1.Text != "")
            {
                saved = Convert.ToDouble(textBox1.Text);
            }
            switch (name)
            {
                case "+":
                    result = saved + prev;
                    done = true;
                    label1.Text = Convert.ToString(result);
                    textBox1.Clear();
                    break;
                case "-":
                    result = prev - saved;
                    done = true;
                    label1.Text = Convert.ToString(result);
                    textBox1.Clear();
                    break;
                case "*":
                    result = saved * prev;
                    done = true;
                    label1.Text = Convert.ToString(result);
                    textBox1.Clear();
                    break; 
                case "/":
                    if (saved != 0)
                    {
                        result = prev / saved;
                        done = true;
                        label1.Text = Convert.ToString(result);
                        textBox1.Clear();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Не може да се дели со 0.");
                        done = true;
                        label1.Text = Convert.ToString(result);
                        textBox1.Clear();
                        break;
                    }
                case "^":
                    result = Math.Pow(prev,saved);
                    done = true;
                    label1.Text = Convert.ToString(result);
                    textBox1.Clear();
                    break;
            }
        }
        private void otheroperands(String name)
        {
            label1.Text = label1.Text + name + "(" + textBox1.Text + ")"; // voa e za log (x), ln (x), factorial (x), trigonometriskite
        }
        private void multSign_Click(object sender, EventArgs e)
        {
            prev = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            op = "*";
            label1.Text = label1.Text + Convert.ToString(prev) + op;
        }

        private void divisionSign_Click(object sender, EventArgs e)
        {
            prev = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            op = "/";
            label1.Text = label1.Text + Convert.ToString(prev) + op;
        }

        private void minusSign_Click(object sender, EventArgs e)
        {
            prev = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            op = "-";
            label1.Text = label1.Text + Convert.ToString(prev) + op;
        }

        private void plusSign_Click(object sender, EventArgs e)
        {
            prev = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            op = "+";
            label1.Text = label1.Text + Convert.ToString(prev) + op;
        }

        private void rootFunction_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                otheroperands("root");
                Double tmp = Double.Parse(textBox1.Text);
                this.result = Math.Sqrt(tmp);
                finished(result.ToString());
            }
            else
            {
                MessageBox.Show("Мора да внесете број прво");
            }
        }
        private void finished(String rez)
        {
            textBox1.Text = rez;
            label1.Text = label1.Text + "=";
            done = true;
            prev = Double.Parse(rez);
        }

        private void xpoweryFunction_Click(object sender, EventArgs e)
        {
            prev = Double.Parse(textBox1.Text);
            textBox1.Clear();
            op = "^";
            label1.Text = label1.Text + Convert.ToString(prev) + op;
        }

        private void tenpowerxFunction_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                otheroperands(tenpowerxFunction.Name);
                Double tmp = Double.Parse(textBox1.Text);
                this.result = Math.Pow(10, tmp);
                finished(result.ToString());
            }
            else
            {
                MessageBox.Show("Мора да внесете број прво");
            }
        }

        private void logFunction_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                otheroperands(logFunction.Name);
                Double tmp = Double.Parse(textBox1.Text);
                this.result = Math.Log10(tmp); 
                finished(result.ToString()); 
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
                Double tmp = Double.Parse(textBox1.Text);
                this.result = Math.Log(tmp); 
                finished(result.ToString());
            }
            else
            {
                MessageBox.Show("Мора да внесете бројка прво");
            }
        }

        private void xsquaredFunction_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                otheroperands(xsquaredFunction.Name);
                Double tmp = Double.Parse(textBox1.Text);
                this.result = tmp * tmp;
                finished(result.ToString()); // kaj via funkcii ima finished povikano oti na obicnite kalkulatori
                                             // kaa ke stisnis odma go dava rezulatot ne mora da stisnis na ednakvoto i zatoa ima na site povikano
            }
            else
            {
                MessageBox.Show("Мора да внесете бројка прво");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public double factorial_recursion(double number)
        {
            if (number == 1 || number == 0)
                return 1;
            else
                return number * factorial_recursion(number - 1);
        }

        private void nfactorialFunction_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                otheroperands("fact");
                Double tmp = Double.Parse(textBox1.Text);
                this.result = factorial_recursion(tmp);
                finished(result.ToString());
            }
            else
            {
                MessageBox.Show("Мора да внесете бројка прво");
            }
        }

        private void piSign_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") 
                textBox1.Clear();
            done = false;
            textBox1.Text = "3,14159265358979323";
        }

        private void eSign_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") 
                textBox1.Clear();
            done = false;
            textBox1.Text = "2,71828182845904523";
        }

        private void sinFunction_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                otheroperands(sinFunction.Text);
                Double tmp = Double.Parse(textBox1.Text);
                this.result = Math.Sin(tmp);
                finished(result.ToString());
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
                Double tmp = Double.Parse(textBox1.Text);
                this.result = Math.Tan(tmp);
                finished(result.ToString());
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
                Double tmp = Double.Parse(textBox1.Text);
                this.result = Math.Cos(tmp);
                finished(result.ToString());
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
                Double tmp = Double.Parse(textBox1.Text);
                this.result = Math.Cos(tmp) / Math.Sin(tmp);        //бидејќи нема cot функција во Math библиотеката
                finished(result.ToString());
            }
            else 
            {
                MessageBox.Show("Мора да внесете бројка прво");
            }
        }

        private void equalSign_Click(object sender, EventArgs e)
        {
            if (op != "")
            {
                basicoperands(op);
            }
        }

        private void absoluteValueFunction_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                otheroperands("absoluteValue");
                Double tmp = Double.Parse(textBox1.Text);
                this.result = Math.Abs(tmp);
                finished(result.ToString());
            }
            else
            {
                MessageBox.Show("Мора да внесете број прво");
            }
        }

        private void upperValueSign_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                otheroperands("ceil");
                Double tmp = Double.Parse(textBox1.Text);
                this.result = Math.Ceiling(tmp);
                finished(result.ToString());
            }
            else
            {
                MessageBox.Show("Мора да внесете број прво");
            }
        }

        private void lowerValueSign_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                otheroperands("floor");
                Double tmp = Double.Parse(textBox1.Text);
                this.result = Math.Floor(tmp);
                finished(result.ToString());
            }
            else
            {
                MessageBox.Show("Мора да внесете број прво");
            }
        }

        private void negateSign_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("-"))
            {
                textBox1.Text = textBox1.Text.Remove(0,1);
            }
            else
            {
                textBox1.Text = "-" + textBox1.Text; 
            }
        }
    }
}
