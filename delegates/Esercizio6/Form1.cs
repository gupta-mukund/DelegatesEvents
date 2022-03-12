using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio6
{
    public partial class Form1 : Form
    {
        Cliente c;
        public Form1()
        {
            InitializeComponent();
        }
        private void C_Errore(object sender, EventArgs e)
        {
            MessageBox.Show(((ErrorMessage)e).Message);
        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            c = new Cliente(txtNome.Text, txtCognome.Text, txtIndirizzo.Text);
            c.Errore += C_Errore;
            txtSaldo.Text = c.Saldo.ToString();
        }
        private void btnVersamento_Click(object sender, EventArgs e)
        {
            if (c != null)
            {
                if (Int32.TryParse(txtImporto.Text, out int n))
                {
                    c.Versamento(n);
                    txtSaldo.Text = c.Saldo.ToString();
                }
            }
        }
        private void btnPrelevamento_Click(object sender, EventArgs e)
        {
            if (c != null)
            {
                if (Int32.TryParse(txtImporto.Text, out int n))
                {
                    c.Prelevamento(n);
                    txtSaldo.Text = c.Saldo.ToString();
                }
            }
        }     
    }
    public class ErrorMessage : EventArgs
    {
        public string Message { get; set; }
    }
}
