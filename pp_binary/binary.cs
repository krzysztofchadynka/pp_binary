using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Binary___pp
{
    class binary
    {
        string value;

        public binary(string value)
        {
            this.value = value;
        }

        private char[] swapArrayValues(char[] tab)
        {
            char[] new_tab = new char[tab.Length];
            int index = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                new_tab[index] = tab[tab.Length - 1 - i];
                index++;
            }

            return new_tab;
        }

        private double getBinaryValue(char[] tab) 
        {
            double val = 0;

            for (int i = 0; i < tab.Length; i++)
                if (tab[i] == '1')
                    val += Math.Pow(2, i);

            return val;
        }

        private int checkZnak(char number)
        {
            if (number == '1')
                return 1;

            return 0;
        }

        private double getU1Value(string value)
        {
            char[] tab = value.ToCharArray();
            double val = 0;

            for (int i = 0; i < tab.Length; i++)
                if (tab[i] == '1')
                    val += Math.Pow(2, -i-1);

            return val;
        }

        private double getMantysa(string value)
        {
            string[] tabs = value.Split(',');

            return 1.0 + getU1Value(tabs[1]);
        }

        public double fromDecimal() 
        {
            char[] tab = this.value.ToCharArray();
            char[] cecha_tab = new char[8];
            char[] mantysa_tab = new char[tab.Length - 8 + 3];

            for (int i = 1; i < 9; i++)
                cecha_tab[i - 1] = tab[i];

            mantysa_tab[0] = '0';
            mantysa_tab[1] = '1';
            mantysa_tab[2] = ',';

            for (int i = 9; i < tab.Length; i++)
                mantysa_tab[i - 6] = tab[i];

            int znak = checkZnak(tab[0]);
            double cecha = getBinaryValue(swapArrayValues(cecha_tab)) - 127;
            double mantysa = getMantysa(new string(mantysa_tab));  

            return Math.Pow(-1, znak) * mantysa * Math.Pow(2, cecha);
        }

        public double toDecimal() 
        {
            return 0;
        }

        // TODO: przeciazyc operatory +, -, *, /
        //public operator + (binary val1, binary val2)
        //{
        //    return val1;
        //}
    }
}
