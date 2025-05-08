using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gry_Karciane
{
    public partial class BlackJackUstawienia : Form
    {
        public BlackJackUstawienia()
        {
            InitializeComponent();
        }

        public int pieniadze { get; set; }
        public int zaklad { get; set; }

        private void zatwierdzanie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Proszę wprowadzić wszystkie dane.");
                return;
            }
            if (!decimal.TryParse(textBox1.Text, out decimal p) || !decimal.TryParse(textBox2.Text, out decimal z))
            {
                MessageBox.Show("Proszę wprowadzić poprawne liczby.");
                return;
            }
            if (p < z)
            {
                MessageBox.Show("Zakład nie może być wyższy niż ilość pieniędzy!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            pieniadze = (int)p;
            zaklad = (int)z;

            this.Close();
        }

        private void anulowanie_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
