﻿using System;
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
    public partial class Clist : Form
    {
        public Clist()
        {
            InitializeComponent();
        }

        private void Clist_Load(object sender, EventArgs e)
        {
           string[] lines= File.ReadAllLines("customers.csv"); 
            for (int i=0;i<lines.Length;i++)
            {
                listBox1.Items.Add(lines[i]);
            }
        }

        private void Clist_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
