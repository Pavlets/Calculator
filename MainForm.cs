using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Сalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        string line_b, line_up;
        double answer = 0;
        bool comma = false;
        int bracket_count = 0;
        void AddSign(string sign)
        {
            if (line_up.Length == 0)
            {
                if (line_b == "")
                    line_b = "0";
                else if (line_b.Length > 1 && line_b[line_b.Length - 1] == ',')
                    line_b = line_b.Remove(line_b.Length - 1);
                line_b = line_b.Replace(" ", "");
                line_up += line_b + sign;
                label1_up.Text = line_up;
                line_b = "";
                label1_b.Text = "0";
                comma = false;
            }
            else if (line_up.Length > 0 && line_up[line_up.Length - 1] != ')')
            {
                if (line_b == "")
                    line_b = "0";
                else if (line_b.Length > 1 && line_b[line_b.Length - 1] == ',')
                    line_b = line_b.Remove(line_b.Length - 1);
                line_b = line_b.Replace(" ", "");
                line_up += line_b + sign;
                label1_up.Text = line_up;
                line_b = "";
                label1_b.Text = "0";
                comma = false;
            }
            else if (line_up.Length > 0 && line_up[line_up.Length - 1] == ')' && line_b != "")
            {
                if (line_b.Length > 1 && line_b[line_b.Length - 1] == ',')
                    line_b = line_b.Remove(line_b.Length - 1);
                line_b = line_b.Replace(" ", "");
                line_up += "*" + line_b + sign;
                label1_up.Text = line_up;
                line_b = "";
                label1_b.Text = "0";
                comma = false;
            }
            else
            {
                line_up += sign;
                label1_up.Text = line_up;
            }

        }

        void AddNumber(string num)
        {
            if (line_b.Length < 19)
            {
                if (((line_b.Length > 6 && line_b[line_b.Length - 4] == ' ') || line_b.Length == 3) && !comma)
                {
                    line_b += " ";
                }
                line_b += num;
                label1_b.Text = line_b;
            }
        }

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
            AddNumber("1");
        }

        private void button1_2_Click(object sender, EventArgs e)
        {
            AddNumber("2");
        }

        private void button1_3_Click(object sender, EventArgs e)
        {
            AddNumber("3");
        }

        private void button1_4_Click(object sender, EventArgs e)
        {
            AddNumber("4");
        }

        private void button1_5_Click(object sender, EventArgs e)
        {
            AddNumber("5");
        }

        private void button1_6_Click(object sender, EventArgs e)
        {
            AddNumber("6");
        }

        private void button1_7_Click(object sender, EventArgs e)
        {
            AddNumber("7");
        }

        private void button1_8_Click(object sender, EventArgs e)
        {
            AddNumber("8");
        }

        private void button1_9_Click(object sender, EventArgs e)
        {
            AddNumber("9");
        }

        private void button1_0_Click(object sender, EventArgs e)
        {
            if (line_b != "")
                AddNumber("0");
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

        private void button1_plusminus_Click(object sender, EventArgs e)
        {
            if (line_b.Length > 0 && line_b[0] != '-')
            {
                line_b = "-" + line_b;
                label1_b.Text = line_b;
            }
            else if (line_b.Length > 1)
            {
                line_b = line_b.Remove(0, 1);
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
            else if (line_up == "")
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
                comma = false;
                bracket_count--;
            }
        }

        private void button1_C_Click(object sender, EventArgs e)
        {
            line_b = "";
            label1_b.Text = "0";
            line_up = "";
            label1_up.Text = "";
        }

        private void button1_CE_Click(object sender, EventArgs e)
        {
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
                    label1_b.Text = line_b;
                }
                else
                {
                    label1_b.Text = "0";
                }
                if (comma && !line_b.Contains(','))
                    comma = false;
                if (line_b == "-")
                {
                    line_b = "";
                    label1_b.Text = "0";
                }
                if (line_b == "0")
                    line_b = "";
            }
        }

        private void button1_equal_Click(object sender, EventArgs e)
        {
            try
            {
                string line, line_new = "";
                line_b = line_b.Replace(" ", "");
                if (line_b == "")
                    line_b = "0";
                if (line_up.Length > 0 && line_up[line_up.Length - 1] == ')' && line_b != "0")
                    line_b = "*" + line_b;
                answer = 0;
                if (line_b != "0")
                    line = '+' + label1_up.Text + line_b;
                else
                    line = '+' + label1_up.Text;
                int id = 0, id1 = 0, id2 = 0;



                line = line.Replace("(", "(+");


                for (int ii = 0; ii < line.Length; ii++)
                {
                    if (line[ii] == '(')
                    {
                        id1 = ii;
                        for (int j = line.Length - 1; j > id1; j--)
                            if (line[j] == ')')
                                id2 = j;
                        for (int i = id1; i <= id2; i++)
                        {
                            if (line[i] == '+')
                            {
                                id = i + 1;
                                do
                                {
                                    line_new += line[i + 1];
                                    i++;
                                } while (i + 1 < line.Length && line[i + 1] != '+' && line[i + 1] != '-' && line[i + 1] != '*' && line[i + 1] != '/' && line[i + 1] != '%' && line[i + 1] != ')');
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
                                } while (i + 1 < line.Length && line[i + 1] != '+' && line[i + 1] != '-' && line[i + 1] != '*' && line[i + 1] != '/' && line[i + 1] != '%' && line[i + 1] != ')');
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
                                } while (i + 1 < line.Length && line[i + 1] != '+' && line[i + 1] != '-' && line[i + 1] != '*' && line[i + 1] != '/' && line[i + 1] != '%' && line[i + 1] != ')');
                                line = line.Remove(id, line_new.Length + answer.ToString().Length + 1);
                                answer *= Double.Parse(line_new);
                                line = line.Insert(id, answer.ToString());
                                for (int jj = line.Length - 1; jj > -1; jj--)
                                    if (line[jj] == ')')
                                        id2 = jj;
                                i = id1 - 1;
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
                                } while (i + 1 < line.Length && line[i + 1] != '+' && line[i + 1] != '-' && line[i + 1] != '*' && line[i + 1] != '/' && line[i + 1] != '%' && line[i + 1] != ')');
                                line = line.Remove(id, line_new.Length + answer.ToString().Length + 1);
                                if (Int32.Parse(line_new) == 0)
                                    throw new ArgumentNullException(paramName: nameof(line_new), message: "0!");
                                answer /= Double.Parse(line_new);
                                line = line.Insert(id, answer.ToString());
                                for (int jj = line.Length - 1; jj > -1; jj--)
                                    if (line[jj] == ')')
                                        id2 = jj;
                                i = id1 - 1;
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
                                } while (i + 1 < line.Length && line[i + 1] != '+' && line[i + 1] != '-' && line[i + 1] != '*' && line[i + 1] != '/' && line[i + 1] != '%' && line[i + 1] != ')');
                                line = line.Remove(id, line_new.Length + answer.ToString().Length + 1);
                                if (Int32.Parse(line_new) == 0)
                                    throw new ArgumentNullException(paramName: nameof(line_new), message: "0!");
                                answer %= Int32.Parse(line_new);
                                line = line.Insert(id, answer.ToString());
                                for (int jj = line.Length - 1; jj > -1; jj--)
                                    if (line[jj] == ')')
                                        id2 = jj;
                                i = id1 - 1;
                                line_new = "";
                                id = 0;
                                answer = 0;
                            }
                        }

                        answer = 0;
                        line_new = "";
                        for (int jj = line.Length - 1; jj > -1; jj--)
                            if (line[jj] == ')')
                                id2 = jj;

                        for (int i = id1; i <= id2; i++)
                        {
                            if (line[i] == '+')
                            {
                                do
                                {
                                    line_new += line[i + 1];
                                    i++;
                                } while (i + 1 < line.Length && line[i + 1] != '+' && line[i + 1] != '-' && line[i + 1] != '*' && line[i + 1] != '/' && line[i + 1] != '%' && line[i + 1] != ')');
                                answer += Double.Parse(line_new);
                                line_new = "";
                            }
                            else if (line[i] == '-')
                            {
                                do
                                {
                                    line_new += line[i + 1];
                                    i++;
                                } while (i + 1 < line.Length && line[i + 1] != '+' && line[i + 1] != '-' && line[i + 1] != '*' && line[i + 1] != '/' && line[i + 1] != '%' && line[i + 1] != ')');
                                answer -= Double.Parse(line_new);
                                line_new = "";
                            }
                        }
                        line = line.Remove(id1, id2 - id1 + 1);
                        line = line.Insert(id1, answer.ToString());
                        answer = 0;
                        ii = 0;
                    }
                }

                line_new = "";
                id = 0;


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
                bracket_count = 0;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains('0'))
                    label1_b.Text = "Поділ на 0!";
                else
                    label1_b.Text = "Число перевищило всі межі!";
                line_b = "";
            }
            line_up = "";
            label1_up.Text = "";
            if (line_b.Contains(','))
                comma = true;
        }

        private void button1_plus_Click(object sender, EventArgs e)
        {
            AddSign("+");
        }

        private void button1_minus_Click(object sender, EventArgs e)
        {
            AddSign("-");
        }

        private void button1_multiply_Click(object sender, EventArgs e)
        {
            AddSign("*");
        }

        private void button1_divide_Click(object sender, EventArgs e)
        {
            AddSign("/");
        }

        private void button1_donate_Click(object sender, EventArgs e)
        {
            label1_b.Text = "1234 5678 9123 1234";
        }

        private void button1_surprise_Click(object sender, EventArgs e)
        {
            label1_b.Text = "SURPRISE!!!٩(◕‿◕)۶";
        }

        private void button1_root_Click(object sender, EventArgs e)
        {
            try
            {
                if (label1_b.Text == "0")
                    line_b = "0";
                if (double.Parse(line_b) < 0)
                    throw new Exception();
                line_b = Math.Sqrt(double.Parse(line_b)).ToString();
                label1_b.Text = line_b;
            }
            catch (Exception ex)
            {
                label1_b.Text = "Корінь негативного числа!";
            }
        }

        private void label1_b_TextChanged(object sender, EventArgs e)
        {
            if (label1_b.Text.Contains(','))
                comma = true;
            else
                comma = false;
            if (line_b.Contains('E'))
                label1_b.Text = "Число перевищило всі межі!";
        }

        private void button1_square_Click(object sender, EventArgs e)
        {
            line_b = (double.Parse(line_b) * double.Parse(line_b)).ToString();
            label1_b.Text = line_b;
        }

        private void button1_pi_Click(object sender, EventArgs e)
        {
            line_b = Math.PI.ToString();
            label1_b.Text = line_b;
        }

        private void button1_sin_Click(object sender, EventArgs e)
        {
            line_b = Math.Sin(double.Parse(line_b)).ToString();
            label1_b.Text = line_b;
        }

        private void button1_cos_Click(object sender, EventArgs e)
        {
            line_b = Math.Cos(double.Parse(line_b)).ToString();
            label1_b.Text = line_b;
        }

        private void button1_tan_Click(object sender, EventArgs e)
        {
            line_b = Math.Tan(double.Parse(line_b)).ToString();
            label1_b.Text = line_b;
        }

        private void button1_log_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(line_b) < 0)
                    throw new Exception();
                line_b = Math.Log(double.Parse(line_b)).ToString();
                label1_b.Text = line_b;
            }
            catch (Exception ex)
            {
                label1_b.Text = "Логарифм негативного числа!";
            }
        }

        private void button1_n_Click(object sender, EventArgs e)
        {
            if (!comma && line_b != "" && line_b[0] != '-') 
            {
                int a = Int32.Parse(line_b);
                int aa = 1;
                for (int i = 2; i <= a; i++)
                    aa *= i;
                line_b = aa.ToString();
                label1_b.Text = line_b;
                if (line_b == "0")
                {
                    label1_b.Text = "Число перевищило всі межі!";
                    line_b = "";
                }
            }
        }

        private void button1_mod_Click(object sender, EventArgs e)
        {
            AddSign("%");
        }
    }
}
