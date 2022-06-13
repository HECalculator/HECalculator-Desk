using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HECalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void doMagic_Click(object sender, EventArgs e)
        {
            // Process input and generate output exsample using custom class
            var dummy = new Inputs();
            dummy.MatDesc = textBox1.Text;
            textBox2.Text = dummy.MatDesc;
        }
    }

    // Custom class that store string and return it with prefix
    class Dummy
    {
        private string _Value;
        public string Value
        {
            get { return "Value: " + _Value; }
            set { _Value = value; }
        }
    }
}
