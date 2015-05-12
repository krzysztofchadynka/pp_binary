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
    public partial class Form1 : Form
    {
        DecimalBinaryForm dbform;

        public Form1()
        {
            InitializeComponent();

            this.dbform = new DecimalBinaryForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dbform.Visible = true;
        }
    }
}
