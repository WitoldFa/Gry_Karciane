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
    public partial class BlackJack : Form
    {
        public int pieniadze;
        public int zaklad;
        public BlackJack()
        {
            InitializeComponent();
            talia = new Talia();
            kartyGracza = new List<Karty>();
            kartyKrupiera = new List<Karty>();
            stanGry = StanGry.OczekiwanieNaStart;
        }
        private Talia talia;
        private List<Karty> kartyGracza;
        private List<Karty> kartyKrupiera;
        private int punktyGracza;
        private int punktyKrupiera;

        private enum StanGry
        {
            OczekiwanieNaStart,
            TuraGracza,
            TuraKrupiera,
            Zakonczona
        }

        private StanGry stanGry;

        private void start_Click(object sender, EventArgs e)
        {
            if (pieniadze == 0 || zaklad == 0)
            {
                MessageBox.Show("Nie wybrano wartości!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            // Rozpocznij grę
            stanGry = StanGry.TuraGracza;
            RozdajKarty();
            MessageBox.Show("Rozpoczęto grę! Twoje karty zostały rozdane.", "Start gry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RozdajKarty()
        {
            kartyGracza.Clear();
            kartyKrupiera.Clear();

            kartyGracza.Add(talia.RozdajKarte());
            kartyGracza.Add(talia.RozdajKarte());
            kartyKrupiera.Add(talia.RozdajKarte());
            kartyKrupiera.Add(talia.RozdajKarte());

            ObliczPunkty();
            AktualizujWidok();
        }

        private void ObliczPunkty()
        {
            punktyGracza = kartyGracza.Sum(k => k.PobierzWartosc());
            punktyKrupiera = kartyKrupiera.Sum(k => k.PobierzWartosc());

            // Obsługa asa (może być 1 lub 11)
            if (punktyGracza > 21 && kartyGracza.Any(k => k.Wartosc == "A"))
                punktyGracza -= 10;
            if (punktyKrupiera > 21 && kartyKrupiera.Any(k => k.Wartosc == "A"))
                punktyKrupiera -= 10;
        }

        private void AktualizujWidok()
        {
            // Wyświetl karty gracza
            graczKartyLabel.Text = string.Join(", ", kartyGracza);
            graczPunktyLabel.Text = $"Punkty: {punktyGracza}";

            // Wyświetl karty krupiera
            krupierKartyLabel.Text = string.Join(", ", kartyKrupiera);
            krupierPunktyLabel.Text = $"Punkty: {punktyKrupiera}";
        }

        

        private void RestartGry()
        {
            talia = new Talia();
            RozdajKarty();
        }


        private void ustawienia_przycisk_Click(object sender, EventArgs e)
        {
            BlackJackUstawienia ustawienia = new BlackJackUstawienia();
            ustawienia.ShowDialog();
            pieniadze = ustawienia.pieniadze;
            zaklad = ustawienia.zaklad;
        }

        private void Hit_Click(object sender, EventArgs e)
        {
            kartyGracza.Add(talia.RozdajKarte());
            ObliczPunkty();
            AktualizujWidok();

            if (punktyGracza > 21)
            {
                MessageBox.Show("Przegrałeś! Przekroczyłeś 21 punktów.", "Koniec gry");
                RestartGry();
            }
        }

        private void Stand_Click(object sender, EventArgs e)
        {
            while (punktyKrupiera < 17)
            {
                kartyKrupiera.Add(talia.RozdajKarte());
                ObliczPunkty();
            }

            AktualizujWidok();

            if (punktyKrupiera > 21 || punktyGracza > punktyKrupiera)
            {
                MessageBox.Show("Wygrałeś!", "Koniec gry");
            }
            else if (punktyGracza == punktyKrupiera)
            {
                MessageBox.Show("Remis!", "Koniec gry");
            }
            else
            {
                MessageBox.Show("Przegrałeś!", "Koniec gry");
            }

            RestartGry();
        }
    }
}
