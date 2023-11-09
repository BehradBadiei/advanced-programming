using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Pname = textBox1.Text;
            string Bp = textBox2.Text;
            string Sp = textBox3.Text;
            string Is = textBox4.Text;
            string line= Pname+","+Bp+","+Sp+","+Is+"\n";
            File.AppendAllText("Products.csv", line);
        }

        private void Product_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
