using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio
{
    public partial class Form1 : Form
    {
        string[] data;
        public Form1()
        {
            InitializeComponent();
            data = new string[] { "Antonella Turso", "Alberto Costa", "Donatella Bertoletti", "Paolo Brunelli", "Fabrizio Lovison", "Paolo De Rigo", "Mattia Marziale", "Salvatore Spinella", "Chiara Perrotta", "Giorgio Tagliapietra", "Raffaella Borrelli" };
            lsbFull.DataSource = data;
        }
    }
}
