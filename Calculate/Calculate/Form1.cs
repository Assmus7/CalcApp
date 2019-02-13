using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int currentValue;
        public int lastValue;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            
        }
   
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        public int button10_Click(object sender, EventArgs e) // слагаемое 2
        {
            Int32.TryParse(textBox1.Text, out int result);

            return result = lastValue;
        }

        public int Plus_Click(object sender, EventArgs e) // слагаемое 1
        {
            
            Int32.TryParse(textBox1.Text, out int result);

            textBox1.Text = "";
            return result = currentValue;
        }

        public void Addition(int _currentValue, int _lastValue) // Метод сложения 
        { 
            int _sum = _currentValue + _lastValue;
            string sum = _sum.ToString();

            textBox1.Text = sum;
        }

        
    }
}
