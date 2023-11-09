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
    public partial class Plist : Form
    {
        public Plist()
        {
            InitializeComponent();
        }

        private void Plist_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("Products.csv");
            for (int i = 0; i < lines.Length; i++)
            {
                listBox1.Items.Add(lines[i]);
            }
        }

        private void Plist_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
