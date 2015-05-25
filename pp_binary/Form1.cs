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
        BinaryDecimalForm dbform;

        public Form1()
        {
            InitializeComponent();

            
        }

        private void dcbOpenButton_Click(object sender, EventArgs e)
        {
            
        }

        private void bcdOpenButton_Click(object sender, EventArgs e)
        {
            this.dbform = new BinaryDecimalForm();
            this.dbform.Visible = true;
        }
    }
}
