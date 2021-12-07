using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сalculator
{
    public partial class MainForm : Form
    {
        static int GetDecimalDigitsCount(double number)
        {
            string str = number.ToString(new System.Globalization.NumberFormatInfo() { NumberDecimalSeparator = "." });
            return str.Contains(".") ? str.Remove(0, Math.Truncate(number).ToString().Length + 1).Length : 0;
        }
        public MainForm()
        {
            InitializeComponent();
        }
        string line_b, line_up;
        double num = 0, answer = 0;
        bool comma = false;
        private void radioButton1_1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1_1.Checked)
                tabControl.SelectedIndex = 0;
            else
                tabControl.SelectedIndex = 1;
        }

        private void radioButton2_1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2_1.Checked)
                tabControl.SelectedIndex = 0;
            else
                tabControl.SelectedIndex = 1;
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            radioButton1_1.Checked = true;
            label1_b.Text = "0";
            label1_up.Text = "";
            line_b = "";
            line_up = "";
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            radioButton2_2.Checked = true;
            line_b = "";
            line_up = "";
        }

        private void button1_del_MouseEnter(object sender, EventArgs e)
        {
            button1_del.BackgroundImage = Image.FromFile($"{Environment.CurrentDirectory}/Pictures/del_mdown.png");
        }

        private void button1_del_MouseLeave(object sender, EventArgs e)
        {
            button1_del.BackgroundImage = Image.FromFile($"{Environment.CurrentDirectory}/Pictures/del.png");
        }

        private void button1_1_Click(object sender, EventArgs e)
        {
            if (line_b.Length < 19)
            {
                if (line_b.Length > 6 && line_b[line_b.Length - 4] == ' ' && !comma)
                {
                    line_b += " ";
                }
                else if (line_b.Length == 3 && !comma)
                {
                    line_b += " ";
                }
                line_b += "1";
                label1_b.Text = line_b;
                if (!comma)
                    num = num * 10 + 1;
                else
                    num += 0.1 / Math.Pow(10, GetDecimalDigitsCount(num));
            }
        }

        private void button1_2_Click(object sender, EventArgs e)
        {
            if (line_b.Length < 19)
            {
                if (line_b.Length > 6 && line_b[line_b.Length - 4] == ' ' && !comma)
                {
                    line_b += " ";
                }
                else if (line_b.Length == 3 && !comma)
                {
                    line_b += " ";
                }
                line_b += "2";
                label1_b.Text = line_b;
                if (!comma)
                    num = num * 10 + 2;
                else
                    num += 0.2 / Math.Pow(10, GetDecimalDigitsCount(num));
            }
        }

        private void button1_3_Click(object sender, EventArgs e)
        {
            if (line_b.Length < 19)
            {
                if (line_b.Length > 6 && line_b[line_b.Length - 4] == ' ' && !comma)
                {
                    line_b += " ";
                }
                else if (line_b.Length == 3 && !comma)
                {
                    line_b += " ";
                }
                line_b += "3";
                label1_b.Text = line_b;
                if (!comma)
                    num = num * 10 + 3;
                else
                    num += 0.3 / Math.Pow(10, GetDecimalDigitsCount(num));
            }
        }

        private void button1_4_Click(object sender, EventArgs e)
        {
            if (line_b.Length < 19)
            {
                if (line_b.Length > 6 && line_b[line_b.Length - 4] == ' ' && !comma)
                {
                    line_b += " ";
                }
                else if (line_b.Length == 3 && !comma)
                {
                    line_b += " ";
                }
                line_b += "4";
                label1_b.Text = line_b;
                if (!comma)
                    num = num * 10 + 4;
                else
                    num += 0.4 / Math.Pow(10, GetDecimalDigitsCount(num));
            }
        }

        private void button1_5_Click(object sender, EventArgs e)
        {
            if (line_b.Length < 19)
            {
                if (line_b.Length > 6 && line_b[line_b.Length - 4] == ' ' && !comma)
                {
                    line_b += " ";
                }
                else if (line_b.Length == 3 && !comma)
                {
                    line_b += " ";
                }
                line_b += "5";
                label1_b.Text = line_b;
                if (!comma)
                    num = num * 10 + 5;
                else
                    num += 0.5 / Math.Pow(10, GetDecimalDigitsCount(num));
            }
        }

        private void button1_6_Click(object sender, EventArgs e)
        {
            if (line_b.Length < 19)
            {
                if (line_b.Length > 6 && line_b[line_b.Length - 4] == ' ' && !comma)
                {
                    line_b += " ";
                }
                else if (line_b.Length == 3 && !comma)
                {
                    line_b += " ";
                }
                line_b += "6";
                label1_b.Text = line_b;
                if (!comma)
                    num = num * 10 + 6;
                else
                    num += 0.6 / Math.Pow(10, GetDecimalDigitsCount(num));
            }
        }

        private void button1_7_Click(object sender, EventArgs e)
        {
            if (line_b.Length < 19)
            {
                if (line_b.Length > 6 && line_b[line_b.Length - 4] == ' ' && !comma)
                {
                    line_b += " ";
                }
                else if (line_b.Length == 3 && !comma)
                {
                    line_b += " ";
                }
                line_b += "7";
                label1_b.Text = line_b;
                if (!comma)
                    num = num * 10 + 7;
                else
                    num += 0.7 / Math.Pow(10, GetDecimalDigitsCount(num));
            }
        }

        private void button1_8_Click(object sender, EventArgs e)
        {
            if (line_b.Length < 19)
            {
                if (line_b.Length > 6 && line_b[line_b.Length - 4] == ' ' && !comma)
                {
                    line_b += " ";
                }
                else if (line_b.Length == 3 && !comma)
                {
                    line_b += " ";
                }
                line_b += "8";
                label1_b.Text = line_b;
                if (!comma)
                    num = num * 10 + 8;
                else
                    num += 0.8 / Math.Pow(10, GetDecimalDigitsCount(num));
            }
        }

        private void button1_9_Click(object sender, EventArgs e)
        {
            if (line_b.Length < 19)
            {
                if (line_b.Length > 6 && line_b[line_b.Length - 4] == ' ' && !comma)
                {
                    line_b += " ";
                }
                else if (line_b.Length == 3 && !comma)
                {
                    line_b += " ";
                }
                line_b += "9";
                label1_b.Text = line_b;
                if (!comma)
                    num = num * 10 + 9;
                else
                    num += 0.9 / Math.Pow(10, GetDecimalDigitsCount(num));
            }
        }

        private void button1_0_Click(object sender, EventArgs e)
        {
            if (line_b.Length < 19)
            {
                if (line_b.Length > 6 && line_b[line_b.Length - 4] == ' ' && !comma)
                {
                    line_b += " ";
                }
                else if (line_b.Length == 3 && !comma)
                {
                    line_b += " ";
                }
                if (!comma)
                {
                    num = num * 10;
                    line_b += "0";
                }
                label1_b.Text = line_b;
            }
        }

        private void button1_comma_Click(object sender, EventArgs e)
        {
            if (!comma && line_b.Length < 18)
            {
                comma = true;
                line_b += ",";
                label1_b.Text = line_b;
            }
        }

        private void button1_C_Click(object sender, EventArgs e)
        {
            num = 0;
            line_b = "";
            label1_b.Text = "0";
            line_up = "";
            label1_up.Text = "";
        }

        private void button1_CE_Click(object sender, EventArgs e)
        {
            num = 0;
            line_b = "";
            label1_b.Text = "0";
        }

        private void button1_del_Click(object sender, EventArgs e)
        {
            if (line_b.Length > 0)
            {
                line_b = line_b.Remove(line_b.Length - 1);
                if (line_b.Length > 1 && (line_b[line_b.Length - 1] == ' ' || line_b[line_b.Length - 1] == ','))
                    line_b = line_b.Remove(line_b.Length - 1);
                if (line_b != "")
                {
                    if (num.ToString()[num.ToString().Length - 1] != '.')
                        num = Double.Parse(num.ToString().Remove(num.ToString().Length - 1));
                    else
                        num = Double.Parse(num.ToString().Remove(num.ToString().Length - 2));
                    label1_b.Text = line_b;
                }
                else
                {
                    num = 0;
                    label1_b.Text = "0";
                }
                if (comma && !line_b.Contains(','))
                    comma = false;
            }
        }

        private void button1_equal_Click(object sender, EventArgs e)
        {
            line_up = "";
            label1_up.Text = "";
            label1_b.Text = answer.ToString();
            line_b = answer.ToString();
            num = answer;
            answer = 0;
        }

        private void button1_plus_Click(object sender, EventArgs e)
        {
            if (line_up != "")
                answer += num;
            else
                answer = num;
            line_up += line_b + "+";
            label1_up.Text = line_up;
            line_b = "";
            label1_b.Text = "0";
            num = 0;
        }
    }
}
