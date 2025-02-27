using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prgit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void generate()
        {
            Random a = new Random();
            number = a.Next(1, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox1.Text) == number)
                {
                    MessageBox.Show("Вы угадали! Новое число загадано");
                    generate();
                }
                else
                if (Convert.ToInt32(textBox1.Text) < number)
                {
                    MessageBox.Show("Число меньше загаданного!");
                }
                else
                if (Convert.ToInt32(textBox1.Text) > number)
                {
                    MessageBox.Show("Число больше загаданного!");
                }
            }
            catch { MessageBox.Show("Введитте число!"); }
        }
    }
}
