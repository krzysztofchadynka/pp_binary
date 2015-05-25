using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Binary___pp
{
    public partial class DecimalBinaryForm : Form
    {
        public DecimalBinaryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = Convert.ToString(Int32.Parse(textBox1.Text), 2);
            }
            catch
            {

            }
        }

    }
}
