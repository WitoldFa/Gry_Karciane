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
    public partial class Form3 : Form
    {
        public int WybranaLiczbaGraczy { get; private set; }
        public int WybranaLiczbaTur { get; private set; }
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e) { }
        private void LiczbaGraczy_TextChanged(object sender, EventArgs e) { }
        private void LiczbaTur_TextChanged(object sender, EventArgs e) { }    
        private void OK_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(LiczbaGraczy.Text, out int gracze) &&
           int.TryParse(LiczbaTur.Text, out int tury))
            {
                if (gracze >= 2 && gracze <= 4 && tury >= 10 && tury <= 15)
                {
                    WybranaLiczbaGraczy = gracze;
                    WybranaLiczbaTur = tury;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Podaj liczbę graczy (2–4) i liczbę tur (10-15).",
                        "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Wprowadź poprawne liczby!",
                    "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ANULUJ_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
