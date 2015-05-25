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
        BinaryDecimalForm bdform;
        DecimalBinaryForm dbform;

        public Form1()
        {
            InitializeComponent();
            this.bdform = new BinaryDecimalForm();
        }

        private void dcbOpenButton_Click(object sender, EventArgs e)
        {
            dbform = new DecimalBinaryForm();
            dbform.Show();
        }

        private void bcdOpenButton_Click(object sender, EventArgs e)
        {
            this.bdform = new BinaryDecimalForm();
            this.bdform.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
