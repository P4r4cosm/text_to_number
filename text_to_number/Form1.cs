using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                            flag = "сотен";
                            result += (Array.IndexOf(hundreds, str[i].ToLower()) + 1) * 100;
                            continue;
                        }
                        else
                        {
                            MessageBox.Show($"{str[i]} не может быть после {str[i-1]} \n(сотни не могут идти после {flag})");
                            return;
                        }
                       
                    }
                    if (tens.Contains(str[i].ToLower()))
                    {
                        if (flag == "" || flag == "сотен")
                        {
                            flag = "десятков";
                            result += (Array.IndexOf(tens, str[i].ToLower()) + 2) * 10;
                            continue;
                        }
                        else
                        {
                            MessageBox.Show($"{str[i]} не может быть после: {str[i-1]} \n(десятки не могут идти после {flag})");
                            return;
                        }
                    }
                    if (ten_nineteen.Contains(str[i].ToLower()))
                    {
                        if (flag==""||flag== "сотен")
                        {
                            flag = "10-19";
                            result += Array.IndexOf(ten_nineteen, str[i].ToLower())+10;
                            continue ;
                        }
                        else
                        {
                            MessageBox.Show($"{str[i]} не может быть после: {str[i-1]}\n(10-19 не может быть после {flag})");
                            return;
                        }
                    }
                    if (units.Contains(str[i].ToLower()))
                    {
                        if (flag == "" || flag == "сотен" || flag=="десятков")
                        {
                            flag = "единиц";
                            result += Array.IndexOf(units, str[i].ToLower());
                            continue;
                        }
                        else
                        {
                            MessageBox.Show($"{str[i]} не может быть после: {str[i-1]} \n(единицы не могут быть после {flag})");
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
                    if (r > str.Length || l > str.Length || r<=l || r<=1 || l<1)
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
