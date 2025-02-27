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

    }
}
