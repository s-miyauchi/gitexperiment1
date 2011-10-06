using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gitexperiment1
{
    public partial class Form1 : Form
    {
        private int x;

        public Form1()
        {
            InitializeComponent();

            x = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x++;
            this.label1.Text = x.ToString();
        }
    }
}
