using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoryWork2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (int.TryParse(textBox2.Text, out int n) == false)
            {
                MessageBox.Show("Введена не число в n", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string s1 = textBox3.Text;
            Program.Copies(s, ref s1, n);
            textBox3.Text = s1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox4.Text;
            label4.Text = Program.Words(s).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s1 = textBox5.Text;
            string s2 = textBox6.Text;
            Program.Concat(ref s1, s2);
            textBox5.Text = s1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = textBox8.Text;
            if (s == "")
            {
                MessageBox.Show("Пустая строка в s", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox7.Text.Length != 1)
            {
                MessageBox.Show("Не введен один символ в t", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            char t = textBox7.Text.First();
               
            label8.Text = Program.Parse(ref s, t);
            label7.Text = s;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = textBox9.Text;
            label9.Text = Program.Word(s);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string s = textBox10.Text;
            if (s == "")
            {
                MessageBox.Show("Пустая строка в s", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(textBox11.Text, out int n) == false)
            {
                MessageBox.Show("Введена не число в n", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(textBox12.Text, out int l) == false)
            {
                MessageBox.Show("Введена не число в l", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.Delete(ref s, n, l);
            textBox10.Text = s;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s = textBox13.Text;
            string s1 = textBox14.Text;

            if (int.TryParse(textBox15.Text, out int n) == false)
            {
                MessageBox.Show("Введена не число в n", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.Insert(ref s, s1, n);
            textBox13.Text = s;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string s = textBox16.Text;
            Program.Reverse(ref s);
            textBox16.Text = s;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string s = textBox17.Text;
            string s1 = textBox18.Text;
            label19.Text = Program.Position(s, s1).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string s = textBox19.Text;
            string s1 = textBox20.Text;
            label22.Text = Program.ReversePosition(s, s1).ToString();
        }
    }
}
