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
    public partial class BinaryDecimalForm : Form
    {
        public BinaryDecimalForm()
        {
            InitializeComponent();
        }

        private void dtob_convertButton_Click(object sender, EventArgs e)
        {
            dtob_convertPanel.Visible = true;
        }

        private void dtob_calculatorButton_Click(object sender, EventArgs e) 
        {
            dtob_calcPanel.Visible = true;
            dtob_convertPanel.Visible = false;
        }

        private void btod_convert_valuesButton_Click(object sender, EventArgs e)
        {
            binary number = new binary(btod_binaryText.Text);
            btod_decimalText.Text = number.fromDecimal().ToString();
        }
    }
}
