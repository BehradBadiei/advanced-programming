using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Sname= textBox2.Text;
            string NID=textBox3.Text;
            string PN=textBox4.Text;
            string line= Name +","+ Sname +","+ NID +","+ PN +"\n";
            File.AppendAllText("Customers.csv",line);  
        }

        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            
        }
    }
}
