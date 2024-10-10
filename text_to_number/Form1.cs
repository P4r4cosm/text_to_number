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
            else if (str.Length > 3)
            {
                MessageBox.Show($"Трёхзначное число не может состоять из {str.Length} слов");
            }
            else
            {
                string[] units = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять","десять",
            "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать",
           "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
                string[] tens = {"двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят",
          "восемьдесят", "девяносто" };
                string[] hundreds = {"сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот",
              "восемьсот", "девятьсот" };
                int result = 0;
                int lastPart = 3; // 3 - сотни, 2 - десятки, 1 - единицы

                for (int i = 0; i < str.Length; i++)
                {
                    int currentPart = 0;

                    if (Array.IndexOf(hundreds, str[i].ToLower()) > -1)
                    {
                        currentPart = 3; // Сотни
                        if (currentPart <= lastPart)
                        {
                            result += (Array.IndexOf(hundreds, str[i].ToLower()) + 1) * 100;
                            lastPart = currentPart;
                            continue;
                        }
                        else
                        {
                            MessageBox.Show("Неверный порядок: сотни должны быть первыми");
                            answer1.Text = i.ToString();
                            return;
                        }
                    }

                    if (Array.IndexOf(tens, str[i].ToLower()) > -1)
                    {
                        currentPart = 2; // Десятки
                        if (currentPart <= lastPart)
                        {
                            result += (Array.IndexOf(tens, str[i].ToLower()) + 2) * 10;
                            lastPart = currentPart;
                            continue;
                        }
                        else
                        {
                            MessageBox.Show("Неверный порядок: десятки должны идти перед единицами, но после сотен");
                            return;
                        }
                    }

                    if (Array.IndexOf(units, str[i].ToLower()) > -1)
                    {
                        currentPart = 1; // Единицы
                        if (currentPart <= lastPart)
                        {
                            result += Array.IndexOf(units, str[i].ToLower());
                            lastPart = currentPart;
                            continue;
                        }
                        else
                        {
                            MessageBox.Show("Неверный порядок: единицы должны быть последними");
                            return;
                        }
                    }

                    MessageBox.Show($"Введённое вами слово {str[i]} не является числительным");
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
