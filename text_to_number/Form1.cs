using System;
using System.Linq;
using System.Windows.Forms;

namespace text_to_number
{
    public partial class Form1 : Form
    {
        string[] units = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
        string[] ten_nineteen = {"десять",
            "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать",
           "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать"};
        string[] tens = {"двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят",
          "восемьдесят", "девяносто" };
        string[] hundreds = {"сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот",
              "восемьсот", "девятьсот" };
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] str = number.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (str.Length == 0)
            {
                MessageBox.Show("Вы ничего не ввели!!!");
            }
            else
            {
                int result = 0;
                string flag = "";
                for (int i = 0; i < str.Length; i++)
                {
                    if (hundreds.Contains(str[i].ToLower()))
                    {
                        if (flag=="")
                        {
                            flag = "числа формата сотен";
                            result += (Array.IndexOf(hundreds, str[i].ToLower()) + 1) * 100;
                            continue;
                        }
                        else
                        {
                            MessageBox.Show($"{str[i]} не может быть после {str[i-1]} \n(число формата сотен не может идти после {flag})");
                            return;
                        }
                       
                    }
                    if (tens.Contains(str[i].ToLower()))
                    {
                        if (flag == "" || flag == "числа формата сотен")
                        {
                            flag = "числа десятичного формата";
                            result += (Array.IndexOf(tens, str[i].ToLower()) + 2) * 10;
                            continue;
                        }
                        else
                        {
                            MessageBox.Show($"{str[i]} не может быть после: {str[i-1]} \n(число десятичного формата не может идти после {flag})");
                            return;
                        }
                    }
                    if (ten_nineteen.Contains(str[i].ToLower()))
                    {
                        if (flag==""||flag== "числа формата сотен")
                        {
                            flag = "числа формата 10-19";
                            result += Array.IndexOf(ten_nineteen, str[i].ToLower())+10;
                            continue ;
                        }
                        else
                        {
                            MessageBox.Show($"{str[i]} не может быть после: {str[i-1]}\n(число формата 10-19 не может быть после {flag})");
                            return;
                        }
                    }
                    if (units.Contains(str[i].ToLower()))
                    {
                        if (flag == "" || flag == "числа формата сотен" || flag== "числа десятичного формата")
                        {
                            flag = "числа единичного форма";
                            result += Array.IndexOf(units, str[i].ToLower());
                            continue;
                        }
                        else
                        {
                            MessageBox.Show($"{str[i]} не может быть после: {str[i-1]} \n(число единичного формата не может быть после {flag})");
                            return;
                        }
                    }
                    MessageBox.Show($"{str[i]} не входит в единицы, сотни, десятки");
                    return;
                }

                

                answer1.Text = result.ToString();
            }
        }
        //задача 1

        private void Ответ_Click(object sender, EventArgs e)
        {
            if (Text.Text == string.Empty || left.Text == string.Empty || right.Text == string.Empty)
            {
                MessageBox.Show("Вы ввели не все значения");
            }
            else
            {


                if (!(int.TryParse(left.Text, out int l) && int.TryParse(right.Text, out int r)))
                {
                    MessageBox.Show("Вы ввели не число");
                }
                else
                {

                    string[] str = Text.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (r > str.Length || l > str.Length || r<l || r<1 || l<1)
                    {
                        MessageBox.Show("Вы ввели некорректные значения");
                    }
                    else
                    {
                        r--;
                        l--;
                        string answer = "";

                        for (int i = 0; i < l; i++)
                        {
                            answer += str[i] + " ";
                        }
                        for (int i = r + 1; i < str.Length; i++)
                        {
                            answer += str[i] + " ";
                        }
                        for (int i = l; i <= r; i++)
                        {
                            answer += str[i] + " ";
                        }
                        answer2.Text = answer;
                    }
                }
                
            }
           
            
        }
    }
}
