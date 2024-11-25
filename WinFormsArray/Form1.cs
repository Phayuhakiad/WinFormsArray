using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] student = new string[5];
            student[0] = "test1";
            student[1] = "test2";
            student[2] = "test3";
            student[3] = "test4";
            student[4] = "test5";
            string test = "";
            int n = student.Length;
            for (int i = 0; i < n; i++)
            {
                test += student[i] + Environment.NewLine;
            }
            MessageBox.Show(test);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Fruits = { "ส้ม", "แอปเปิ้ล", "มะม่วง", "องุ่น", "ทุเรียน" };
            string myFruit = "";
            foreach (string str in Fruits)
            {
                myFruit += str+",";
            }
            MessageBox.Show(myFruit,"ผลไม้");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;
            string result = "";
            foreach (string str in data)
            {
                if (str != "") 
                {
                    result += str + Environment.NewLine;
                }
            }
            label1.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String[] data = textBox1.Lines;
            string result = "";
            int Sum = 0;
            foreach (var str in data)
            {
                int x = 0;
                if (int.TryParse(str,out x))
                {
                    result += x.ToString() + Environment.NewLine;
                    Sum += x;
                }
            }
            result += $"ผลรวม={Sum}";
            label1.Text = result;
            MessageBox.Show(Sum.ToString(), "ผลรวม");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[,] student = new string[3, 2];
            student[0, 0] = "test1";
            student[0, 1] = "testd1";
            student[1, 0] = "test2";
            student[1, 1] = "testd2";
            student[2, 0] = "test3";
            student[2, 1] = "testd3";
            string ResultData = "";
            int m = student.GetLength(0);
            int n = student.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ResultData += student[i, j] + "-";
                }
                ResultData += Environment.NewLine;
            }
            MessageBox.Show(ResultData,"แสดงข้อมูลใน Array 2 มิติ");
        }
    }
}