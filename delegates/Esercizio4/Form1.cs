using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio4
{
    public partial class Form1 : Form
    {
        public delegate void Del(int a, int b);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            Del func = new Del(Media);
            if (Int32.TryParse(txtOne.Text, out int numA) && Int32.TryParse(txtTwo.Text, out int numB))
            {
                func(numA, numB);
            }
            
        }

        private void Media(int numA, int numB)
        {
            int media = (numA + numB) / 2;
            MessageBox.Show($"Media: {media}");
        }

        private void Max(int numA, int numB)
        {
            int max = numA > numB ? numA : numB;
            MessageBox.Show($"Max: {max}");
        }

        private void Ipotenusa(int numA, int numB)
        {
            double i = Math.Sqrt(Math.Pow(numA, 2) + Math.Pow(numB, 2));
            MessageBox.Show($"Ipotenusa: {i}");
        }

        private void btnEverything_Click(object sender, EventArgs e)
        {
            Del funcs = new Del(Media);
            funcs += Max;
            funcs += Ipotenusa;

            if (Int32.TryParse(txtOne.Text, out int numA) && Int32.TryParse(txtTwo.Text, out int numB))
            {
                funcs(numA, numB);
            }
        }
    }
}
