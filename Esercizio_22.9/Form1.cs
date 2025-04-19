using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_22._9
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcolaArea_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBase.Text, out double b) && double.TryParse(txtAltezza.Text, out double h))
            {
                double area = (b * h) / 2;
                lblRisultato.Text = $"Area: {area}";
            }
            else
            {
                MessageBox.Show("Inserisci valori numerici validi.");
            }
        }
    }
}
