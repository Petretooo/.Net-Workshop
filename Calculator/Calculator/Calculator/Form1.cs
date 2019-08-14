using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        List<String> numbersAndCommands = new List<String>();
        List<String> numbersCommands = new List<String>();

        double Memory = 0;
        double temp = 0;

        string expression = "";

        string equationCommand;
        string equationLastCommand = "";
        string equationDigit;
        double result;
        double finalResult;

        int counter = 0;
        bool flag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addLastNumberToTheSecondList()
        {
            flag = false;
            numbersCommands.Add(finalResult.ToString());
        }
        private bool Flag()
        {
            flag = false;
            return flag;
        }
        private bool flagNumber()
        {
            if (flag)
            {
                flag = false;
                temp = 0;
                numbersAndCommands.Clear();
                numbersCommands.Clear();
                textBox1.Text = "";
                counter = 0;
                equationDigit = "";
                equationCommand = "";
                equationLastCommand = "";
                expression = "";
            }
            counter = 0;
            return flag;
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            flagNumber();
            textBox1.Text += "7";
            temp = double.Parse("7");
            numbersAndCommands.Add("7");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            flagNumber();
            textBox1.Text += "8";
            temp = double.Parse("8");
            numbersAndCommands.Add("8");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            flagNumber();
            textBox1.Text += "9";
            temp = double.Parse("9");
            numbersAndCommands.Add("9");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            flagNumber();
            textBox1.Text += "4";
            temp = double.Parse("4");
            numbersAndCommands.Add("4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            flagNumber();
            textBox1.Text += "5";
            temp = double.Parse("5");
            numbersAndCommands.Add("5");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            flagNumber();
            textBox1.Text += "6";
            temp = double.Parse("6");
            numbersAndCommands.Add("6");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            flagNumber();
            textBox1.Text += "1";
            temp = double.Parse("1");
            numbersAndCommands.Add("1");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            flagNumber();
            textBox1.Text += "2";
            temp = double.Parse("2");
            numbersAndCommands.Add("2");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            flagNumber();
            textBox1.Text += "3";
            temp = double.Parse("3");
            numbersAndCommands.Add("3");
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            flagNumber();
            textBox1.Text += ".";
            numbersAndCommands.Add(".");
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            flagNumber();
            textBox1.Text += "0";
            temp = double.Parse("0");
            numbersAndCommands.Add("0");
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Flag();
            textBox1.Text += "+";
            numbersAndCommands.Add("+");
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Flag();
            textBox1.Text += "-";
            numbersAndCommands.Add("-");
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            Flag();
            textBox1.Text += "*";
            numbersAndCommands.Add("*");
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Flag();
            textBox1.Text += "/";
            numbersAndCommands.Add("/");
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            Flag();
            textBox1.Text += "%";
            numbersAndCommands.Add("%");
        }


        private void fillingTheSecondList()
        {
            for (int i = 0; i < numbersAndCommands.Count; i++)
            {

                
                string el = "";
                while (numbersAndCommands[i] == "0" ||
                    numbersAndCommands[i] == "1" ||
                    numbersAndCommands[i] == "2" ||
                    numbersAndCommands[i] == "3" ||
                    numbersAndCommands[i] == "4" || numbersAndCommands[i] == "5" || numbersAndCommands[i] == "6" ||
                    numbersAndCommands[i] == "7" || numbersAndCommands[i] == "8" || numbersAndCommands[i] == "9" || numbersAndCommands[i] == ".")
                {
                    el += numbersAndCommands[i];
                    i++;
                    if (i >= numbersAndCommands.Count)
                    {
                        break;
                    }
                }

                if (el != "")
                {
                    numbersCommands.Add(el);
                }


                if (i >= numbersAndCommands.Count)
                {
                    break;
                }

                if (numbersAndCommands[i] == "+" ||
                    numbersAndCommands[i] == "-" ||
                    numbersAndCommands[i] == "%" ||
                    numbersAndCommands[i] == "*" ||
                    numbersAndCommands[i] == "/")
                {
                    el = numbersAndCommands[i];
                    numbersCommands.Add(el);
                }
                el = "";
            }
        }

        
        private void calculation()
        {

       


            try
            {
                if (numbersAndCommands.Count != 0 && (numbersAndCommands[0] == "+" ||
                    numbersAndCommands[0] == "-" ||
                    numbersAndCommands[0] == "%" ||
                    numbersAndCommands[0] == "*" ||
                    numbersAndCommands[0] == "/"))
                {

                    if (numbersCommands.Count == 0 )
                    {
                        if (textBox1.Text.Contains(finalResult.ToString()))
                        {
                            addLastNumberToTheSecondList();
                        }
                        else
                        {
                            finalResult = 0;
                            addLastNumberToTheSecondList();
                        }
                    }
                    
                    
                }

                textBox1.Text = "";
                double temp1 = result;

                if (counter != 0)
                {

                    if (equationCommand.Equals("+"))
                    {

                        if (equationLastCommand.Equals("%"))
                        {
                            result *= (1 + double.Parse(equationDigit) / 100);
                            listBox1.Items.Add(temp1 + equationCommand + equationDigit + equationLastCommand + " = " + (result));
                            textBox1.Text = "" + (result).ToString();
                        }
                        else
                        {
                            result += double.Parse(equationDigit);
                            listBox1.Items.Add(temp1 + equationCommand + equationDigit + " = " + (result));
                            textBox1.Text = "" + (result).ToString();
                        }

                    }
                    else if (equationCommand.Equals("-"))
                    {
                        if (equationLastCommand.Equals("%"))
                        {
                            result *= (1 - double.Parse(equationDigit) / 100);
                            listBox1.Items.Add(temp1 + equationCommand + equationDigit + equationLastCommand + " = " + (result));
                            textBox1.Text = "" + (result).ToString();
                        }
                        else
                        {
                            result -= double.Parse(equationDigit);
                            listBox1.Items.Add(temp1 + equationCommand + equationDigit + " = " + (result));
                            textBox1.Text = "" + (result).ToString();
                        }

                    }
                    else if (equationCommand.Equals("*"))
                    {

                        if (equationLastCommand.Equals("%"))
                        {

                            double percent = (double)(result / 100 * double.Parse(equationDigit) / 100) * 100;
                            result *= percent;

                            listBox1.Items.Add(temp1 + equationCommand + equationDigit + equationLastCommand + " = " + (result));
                            textBox1.Text = "" + (result).ToString();

                        }
                        else
                        {
                            result *= double.Parse(equationDigit);
                            listBox1.Items.Add(temp1 + equationCommand + equationDigit + " = " + (result));
                            textBox1.Text = "" + (result).ToString();
                        }
                    }
                    else if (equationCommand.Equals("/"))
                    {
                        if (equationLastCommand.Equals("%"))
                        {

                            double percent = (double)(result / 100 * double.Parse(equationDigit) / 100) * 100;
                            result /= percent;

                            listBox1.Items.Add(temp1 + equationCommand + equationDigit + equationLastCommand + " = " + (result));
                            textBox1.Text = "" + (result).ToString();

                        }
                        else
                        {
                            result /= double.Parse(equationDigit);
                            listBox1.Items.Add(temp1 + equationCommand + equationDigit + " = " + (result));
                            textBox1.Text = "" + (result).ToString();
                        }
                    }
                    else if (equationCommand.Equals("%"))
                    {
                        result = (double)(result / 100 * double.Parse(equationDigit) / 100) * 100;
                        listBox1.Items.Add(temp1 + equationCommand + equationDigit + " = " + (result));
                        textBox1.Text = "" + (result).ToString();
                    }

                    temp = result;
                    finalResult = result;


                }
                else
                {
                    fillingTheSecondList();
                    double number = double.Parse(numbersCommands[0]);


                    equationCommand = numbersCommands[numbersCommands.Count - 3];
                    equationDigit = numbersCommands[numbersCommands.Count - 2];

                    foreach (var v in numbersCommands)
                    {
                        expression += v;
                    }

                    for (int i = 0; i < numbersCommands.Count; i++)
                    {
                        string n = numbersCommands[i];

                        if (numbersCommands[i].Equals("+"))
                        {
                            if (i + 2 < numbersCommands.Count && numbersCommands[i + 2].Equals("%"))
                            {
                                equationCommand = numbersCommands[numbersCommands.Count - 3];
                                equationDigit = numbersCommands[numbersCommands.Count - 2];
                                equationLastCommand = "%";

                                number = (number * (1 + double.Parse(numbersCommands[i + 1]) / 100));

                                numbersCommands.Remove(numbersCommands[i + 2]);
                            }
                            else
                            {
                                number += double.Parse(numbersCommands[i + 1]);
                                equationCommand = numbersCommands[numbersCommands.Count - 2];
                                equationDigit = numbersCommands[numbersCommands.Count - 1];
                            }

                        }
                        else if (numbersCommands[i].Equals("-"))
                        {
                            if (i + 2 < numbersCommands.Count && numbersCommands[i + 2].Equals("%"))
                            {
                                equationCommand = numbersCommands[numbersCommands.Count - 3];
                                equationDigit = numbersCommands[numbersCommands.Count - 2];
                                equationLastCommand = "%";

                                number = (number * (1 - double.Parse(numbersCommands[i + 1]) / 100));

                                numbersCommands.Remove(numbersCommands[i + 2]);
                            }
                            else
                            {
                                number -= double.Parse(numbersCommands[i + 1]);
                                equationCommand = numbersCommands[numbersCommands.Count - 2];
                                equationDigit = numbersCommands[numbersCommands.Count - 1];
                            }

                        }
                        else if (numbersCommands[i].Equals("*"))
                        {
                            if (i + 2 < numbersCommands.Count && numbersCommands[i + 2].Equals("%"))
                            {
                                equationCommand = numbersCommands[numbersCommands.Count - 3];
                                equationDigit = numbersCommands[numbersCommands.Count - 2];
                                equationLastCommand = "%";

                                double percent = (double)(number / 100 * double.Parse(numbersCommands[i + 1]) / 100) * 100;
                                number *= percent;

                                numbersCommands.Remove(numbersCommands[i + 2]);
                            }

                            else
                            {
                                number *= double.Parse(numbersCommands[i + 1]);
                                equationCommand = numbersCommands[numbersCommands.Count - 2];
                                equationDigit = numbersCommands[numbersCommands.Count - 1];
                            }

                        }
                        else if (numbersCommands[i].Equals("/"))
                        {
                            if (i + 2 < numbersCommands.Count && numbersCommands[i + 2].Equals("%"))
                            {
                                equationCommand = numbersCommands[numbersCommands.Count - 3];
                                equationDigit = numbersCommands[numbersCommands.Count - 2];
                                equationLastCommand = "%";

                                double percent = (double)(number / 100 * double.Parse(numbersCommands[i + 1]) / 100) * 100;
                                number /= percent;

                                numbersCommands.Remove(numbersCommands[i + 2]);
                            }
                            else
                            {
                                number /= double.Parse(numbersCommands[i + 1]);
                                equationCommand = numbersCommands[numbersCommands.Count - 2];
                                equationDigit = numbersCommands[numbersCommands.Count - 1];
                            }

                        }
                        else if (numbersCommands[i].Equals("%"))
                        {
                            equationCommand = numbersCommands[numbersCommands.Count - 2];
                            equationDigit = numbersCommands[numbersCommands.Count - 1];
                            number = (double)(number / 100 * double.Parse(numbersCommands[i + 1]) / 100) * 100;
                        }
                    }

                    counter++;
                    result = number;
                    finalResult = number;

                    temp = number;
                    listBox1.Items.Add(expression + " = " + (number));
                    expression = "";
                    numbersAndCommands.Clear();
                    numbersCommands.Clear();
                    textBox1.Text = "" + (number).ToString();
                }
            }
            catch
            {

            }
            finally
            {
                flag = false;
                numbersAndCommands.Clear();
                numbersCommands.Clear();
                expression = "";
            }
        }



        private void Button12_Click(object sender, EventArgs e)
        {
            calculation();
            flag = true;
        }

        private void clear()
        {
            temp = 0;
            numbersAndCommands.Clear();
            numbersCommands.Clear();
            textBox1.Text = "";
            counter = 0;
            result = 0;
            equationDigit = "";
            equationCommand = "";
            equationLastCommand = "";
            expression = "";
        }
        private void Button22_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            numbersAndCommands.Clear();
            numbersCommands.Clear();
            expression = "";
            counter = 0;
            flag = false;
            numbersCommands.Add(Memory.ToString());
            textBox1.Text = Memory.ToString();
            listBox1.Items.Add("Memory Recall: " + (Memory));
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            fillingTheSecondList();

            if(numbersCommands.Count == 1)
            {
                temp = double.Parse(numbersCommands[0]);
            }
            Memory += temp;
            listBox1.Items.Add("Memory Plus: " + (temp));
            numbersCommands.Clear();
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            fillingTheSecondList();

            if (numbersCommands.Count == 1)
            {
                temp = double.Parse(numbersCommands[0]);
            }
            Memory -= temp;
            listBox1.Items.Add("Memory Minus: " + (temp));
            numbersCommands.Clear();
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            Memory = 0;
            temp = 0;
            listBox1.Items.Add("Memory Clear: " + (Memory));
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
