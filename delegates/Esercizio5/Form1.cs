using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio5
{
    public partial class Form1 : Form
    {
        public event EventHandler Errore;
        public Form1()
        {
            InitializeComponent();
            this.Errore += Form1_Errore;
        }
        private void Form1_Errore(object sender, EventArgs e)
        {
            MessageBox.Show("Errore");
        }
        private void btnEsegui_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txtEta.Text, out int n))
            {
                Errore?.Invoke(this, null);
            }
        }
    }
}
