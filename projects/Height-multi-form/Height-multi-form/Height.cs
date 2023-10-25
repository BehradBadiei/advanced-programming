using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Height_multi_form
{
    public partial class Height : Form
    {
        public Height()
        {
            InitializeComponent();
            
        }
        public Form1 f1;
        
        private void Height_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

            
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label2.Text = "";
            f1.label3.Text = this.label2.Text;
        }
    }
}
