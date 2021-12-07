using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Сalculator
{
    public partial class MainForm : Form
    {
        static int GetDecimalDigitsanswer(double number)
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
        int bracket_count = 0;
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
                    num += 0.1 / Math.Pow(10, GetDecimalDigitsanswer(num));
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
                    num += 0.2 / Math.Pow(10, GetDecimalDigitsanswer(num));
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
                    num += 0.3 / Math.Pow(10, GetDecimalDigitsanswer(num));
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
                    num += 0.4 / Math.Pow(10, GetDecimalDigitsanswer(num));
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
                    num += 0.5 / Math.Pow(10, GetDecimalDigitsanswer(num));
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
                    num += 0.6 / Math.Pow(10, GetDecimalDigitsanswer(num));
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
                    num += 0.7 / Math.Pow(10, GetDecimalDigitsanswer(num));
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
                    num += 0.8 / Math.Pow(10, GetDecimalDigitsanswer(num));
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
                    num += 0.9 / Math.Pow(10, GetDecimalDigitsanswer(num));
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
                if (label1_b.Text == "0")
                    line_b = "0";
                comma = true;
                line_b += ",";
                label1_b.Text = line_b;
            }
        }

        private void button1_bracket1_Click(object sender, EventArgs e)
        {
            if (line_up != "" && line_up[line_up.Length - 1] != ')')
            {
                line_up += "(";
                label1_up.Text = line_up;
                bracket_count++;
            }
            else if(line_up == "")
            {
                line_up = "(";
                label1_up.Text = line_up;
                bracket_count++;
            }
        }

        private void button1_bracket2_Click(object sender, EventArgs e)
        {
            if (bracket_count > 0)
            {
                if (line_b == "")
                    line_b = "0";
                else if (line_b.Length > 1 && line_b[line_b.Length - 1] == ',')
                    line_b = line_b.Remove(line_b.Length - 1);
                line_up += line_b;
                line_up += ")";
                label1_up.Text = line_up;
                line_b = "";
                label1_b.Text = "0";
                num = 0;
                comma = false;
                bracket_count--;
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
            bool z = false;
            if (line_b.Length > 0)
            {
                if (line_b[line_b.Length - 1] == ',')
                    z = true;
                line_b = line_b.Remove(line_b.Length - 1);
                if (line_b.Length > 1 && (line_b[line_b.Length - 1] == ' ' || line_b[line_b.Length - 1] == ','))
                    line_b = line_b.Remove(line_b.Length - 1);
                if (line_b != "")
                {
                    if (!z)
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
            try
            {
                if (line_b == "")
                    line_b = "0";
                answer = 0;
                string line = '+' + label1_up.Text + line_b, line_new = "";
                int id = 0;

                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '+')
                    {
                        id = i + 1;
                        do
                        {
                            line_new += line[i + 1];
                            i++;
                        } while (i + 1 < line.Length && line[i + 1] != '+' && line[i + 1] != '-' && line[i + 1] != '*' && line[i + 1] != '/' && line[i + 1] != '%');
                        answer = 0;
                        answer += Double.Parse(line_new);
                        line_new = "";
                    }
                    else if (line[i] == '-')
                    {
                        id = i + 1;
                        do
                        {
                            line_new += line[i + 1];
                            i++;
                        } while (i + 1 < line.Length && line[i + 1] != '+' && line[i + 1] != '-' && line[i + 1] != '*' && line[i + 1] != '/' && line[i + 1] != '%');
                        answer = 0;
                        answer += Double.Parse(line_new);
                        line_new = "";
                    }
                    else if (line[i] == '*')
                    {
                        do
                        {
                            line_new += line[i + 1];
                            i++;
                        } while (i + 1 < line.Length && line[i + 1] != '+' && line[i + 1] != '-' && line[i + 1] != '*' && line[i + 1] != '/' && line[i + 1] != '%');
                        line = line.Remove(id, line_new.Length + answer.ToString().Length + 1);
                        answer *= Double.Parse(line_new);
                        line = line.Insert(id, answer.ToString());
                        i = -1;
                        line_new = "";
                        id = 0;
                        answer = 0;
                    }
                    else if (line[i] == '/')
                    {
                        do
                        {
                            line_new += line[i + 1];
                            i++;
                        } while (i + 1 < line.Length && line[i + 1] != '+' && line[i + 1] != '-' && line[i + 1] != '*' && line[i + 1] != '/' && line[i + 1] != '%');
                        line = line.Remove(id, line_new.Length + answer.ToString().Length + 1);
                        if (Int32.Parse(line_new) == 0)
                            throw new ArgumentNullException(paramName: nameof(line_new), message: "0!");
                        answer /= Double.Parse(line_new);
                        line = line.Insert(id, answer.ToString());
                        i = -1;
                        line_new = "";
                        id = 0;
                        answer = 0;
                    }
                    else if (line[i] == '%')
                    {
                        do
                        {
                            line_new += line[i + 1];
                            i++;
                        } while (i + 1 < line.Length && line[i + 1] != '+' && line[i + 1] != '-' && line[i + 1] != '*' && line[i + 1] != '/' && line[i + 1] != '%');
                        line = line.Remove(id, line_new.Length + answer.ToString().Length + 1);
                        if (Int32.Parse(line_new) == 0)
                            throw new ArgumentNullException(paramName: nameof(line_new), message: "0!");
                        answer %= Int32.Parse(line_new);
                        line = line.Insert(id, answer.ToString());
                        i = -1;
                        line_new = "";
                        id = 0;
                        answer = 0;
                    }
                }

                answer = 0;
                line_new = "";

                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '+')
                    {
                        do
                        {
                            line_new += line[i + 1];
                            i++;
                        } while (i + 1 < line.Length && line[i + 1] != '+' && line[i + 1] != '-' && line[i + 1] != '*' && line[i + 1] != '/' && line[i + 1] != '%');
                        answer += Double.Parse(line_new);
                        line_new = "";
                    }
                    else if (line[i] == '-')
                    {
                        do
                        {
                            line_new += line[i + 1];
                            i++;
                        } while (i + 1 < line.Length && line[i + 1] != '+' && line[i + 1] != '-' && line[i + 1] != '*' && line[i + 1] != '/' && line[i + 1] != '%');
                        answer -= Double.Parse(line_new);
                        line_new = "";
                    }
                }
                label1_b.Text = line_b = answer.ToString();
                if (line_b == "0")
                    line_b = "";
                num = answer;
                bracket_count = 0;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains('0'))
                    label1_b.Text = "Поділ на 0!";
                else
                    label1_b.Text = "Число перевищило всі межі!";
                num = 0;
                line_b = "";
            }
            line_up = "";
            label1_up.Text = "";
            if (line_b.Contains(','))
                comma = true;
        }

        private void button1_plus_Click(object sender, EventArgs e)
        {
            if (line_b == "")
                line_b = "0";
            else if (line_b.Length > 1 && line_b[line_b.Length - 1] == ',')
                line_b = line_b.Remove(line_b.Length - 1);
            line_up += line_b + "+";
            label1_up.Text = line_up;
            line_b = "";
            label1_b.Text = "0";
            num = 0;
            comma = false;
        }

        private void button1_minus_Click(object sender, EventArgs e)
        {
            if (line_b == "")
                line_b = "0";
            else if (line_b.Length > 1 && line_b[line_b.Length - 1] == ',')
                line_b = line_b.Remove(line_b.Length - 1);
            line_up += line_b + "-";
            label1_up.Text = line_up;
            line_b = "";
            label1_b.Text = "0";
            num = 0;
            comma = false;
        }

        private void button1_multiply_Click(object sender, EventArgs e)
        {
            if (line_b == "")
                line_b = "0";
            else if (line_b.Length > 1 && line_b[line_b.Length - 1] == ',')
                line_b = line_b.Remove(line_b.Length - 1);
            line_up += line_b + "*";
            label1_up.Text = line_up;
            line_b = "";
            label1_b.Text = "0";
            num = 0;
            comma = false;
        }

        private void button1_plusminus_Click(object sender, EventArgs e)
        {
            if (line_b.Length > 0 && line_b[0] != '-')
            {
                line_b = "-" + line_b;
                label1_b.Text = line_b;
                num = num - num * 2;
            }
            else if (line_b.Length > 1)
            {
                line_b = line_b.Remove(0, 1);
                label1_b.Text = line_b;
            }
        }

        private void button1_divide_Click(object sender, EventArgs e)
        {
            if (line_b == "")
                line_b = "0";
            else if (line_b.Length > 1 && line_b[line_b.Length - 1] == ',')
                line_b = line_b.Remove(line_b.Length - 1);
            line_up += line_b + "/";
            label1_up.Text = line_up;
            line_b = "";
            label1_b.Text = "0";
            num = 0;
            comma = false;
        }

        private void button1_mod_Click(object sender, EventArgs e)
        {
            if (line_up.Length > 0 && line_up[line_up.Length - 1] != ')' && line_b == "")
            {
                if (line_b == "")
                    line_b = "0";
                else if (line_b.Length > 1 && line_b[line_b.Length - 1] == ',')
                    line_b = line_b.Remove(line_b.Length - 1);
                line_up += line_b + "%";
                label1_up.Text = line_up;
                line_b = "";
                label1_b.Text = "0";
                num = 0;
                comma = false;
            }
            else if (line_up.Length > 0 && line_up[line_up.Length - 1] == ')')
            {
                line_up += line_b + "%";
                label1_up.Text = line_up;
                line_b = "";
                label1_b.Text = "0";
                num = 0;
                comma = false;
            }
        }
    }
}
