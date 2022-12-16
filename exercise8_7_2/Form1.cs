using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise8_7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text); // 텍스트 박스 문자열을 실수로 형변환
            double result = a + b; // 두 값을 더해 변수에 저장
            textBox3.Text = result.ToString(); // 변수를 문자열로 변환해 텍스트박스에 출력
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text); // 텍스트 박스 문자열을 실수로 형변환
            double result = a - b; // 두 값을 빼 변수에 저장
            textBox3.Text = result.ToString(); // 변수를 문자열로 변환해 텍스트박스에 출력
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text); // 텍스트 박스 문자열을 실수로 형변환
            double result = a * b; // 두 값을 곱해 변수에 저장
            textBox3.Text = result.ToString(); // 변수를 문자열로 변환해 텍스트박스에 출력
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text); // 텍스트 박스 문자열을 실수로 형변환
            double result = a / b; // 두 값을 나눠 변수에 저장
            textBox3.Text = result.ToString(); // 변수를 문자열로 변환해 텍스트박스에 출력
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text); // 텍스트 박스 문자열을 실수로 형변환
            double result = a % b; // 두 값의 나머지를 변수에 저장
            textBox3.Text = result.ToString(); // 변수를 문자열로 변환해 텍스트박스에 출력
        }
    }
} 
