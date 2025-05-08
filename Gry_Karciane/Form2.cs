using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Gry_Karciane.Class1;
using static System.Windows.Forms.DataFormats;

namespace Gry_Karciane
{
    public partial class Form2 : Form
    {
        //Rest
        private Form1 parentForm;
        private object liczbaGraczy;
        private bool wTrakcieWojny = false;
        private Button zagrajTureButton;

        //Integers
        private int liczbaTur = 0;
        private int aktualnyGraczIndex = 0;
        private int aktualnaTura = 0;

        //List/Dictionary
        private List<Gracz> gracze = new List<Gracz>();
        private List<Gracz> graczeWojna = new List<Gracz>();
        private List<Karta> kartyNaStole = new List<Karta>();
        private Dictionary<Gracz, int> kartyWTurze = new Dictionary<Gracz, int>();

        public Form2(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }
        private void Form2_Load(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }



        private void GenerujPlansze(int liczbaGraczy, int liczbaTur)
        {
            MessageBox.Show($"Rozpoczynamy grę!\nGraczy: {liczbaGraczy}\nTury: {liczbaTur}",
                "Start", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gracze.Clear();
            panel1.Controls.Clear();
            aktualnyGraczIndex = 0;
            aktualnaTura = 0;
            this.liczbaTur = liczbaTur;
            kartyWTurze.Clear();
            for (int i = 0; i < liczbaGraczy; i++)
            {
                if (liczbaGraczy == 2)
                {
                    Gracz g = new Gracz
                    {
                        Nazwa = $"User{i + 1}",
                        LiczbaKart = 26,
                        ZdobyteKarty = 0,
                        AktualnaKarta = "-"
                    };
                    gracze.Add(g);
                }
                else if (liczbaGraczy == 3)
                {
                    Gracz g = new Gracz
                    {
                        Nazwa = $"User{i + 1}",
                        LiczbaKart = 17,
                        ZdobyteKarty = 0,
                        AktualnaKarta = "-"
                    };
                    gracze.Add(g);
                }
                else if (liczbaGraczy == 4)
                {
                    Gracz g = new Gracz
                    {
                        Nazwa = $"User{i + 1}",
                        LiczbaKart = 13,
                        ZdobyteKarty = 0,
                        AktualnaKarta = "-"
                    };
                    gracze.Add(g);
                }

            }
            zagrajTureButton = new Button();
            zagrajTureButton.Text = "Tura";
            zagrajTureButton.Size = new Size(50, 30);
            zagrajTureButton.Click += ZagrajTureButton_Click;
            panel1.Controls.Add(zagrajTureButton);

            OdswiezPlansze();
        }

        private void OdswiezPlansze()
        {
            panel1.Controls.Clear();

            for (int i = 0; i < gracze.Count; i++)
            {
                Gracz g = gracze[i];
                Label lbl = new Label();
                lbl.Text = $"{g.Nazwa} | Karty: {g.LiczbaKart} | Zdobyte: {g.ZdobyteKarty} | Wyrzucił: {g.AktualnaKarta}";
                lbl.Location = new Point(10, 40 * i);
                lbl.Size = new Size(300, 30);
                panel1.Controls.Add(lbl);
                if (i == aktualnyGraczIndex)
                {
                    zagrajTureButton.Location = new Point(320, 40);
                    panel1.Controls.Add(zagrajTureButton);
                }
            }
            RozdajKarty(gracze);
            if (liczbaTur > gracze[0].KartyNaRece.Count)
            {
                liczbaTur = gracze[0].KartyNaRece.Count;
            }
        }

        private void RozstrzygnijWojne()
        {
            var maxWartosc = kartyWTurze.Max(kv => kv.Value);

            var zwyciezcy = kartyWTurze
                .Where(kv => kv.Value == maxWartosc)
                .Select(kv => kv.Key)
                .ToList();

            if (zwyciezcy.Count == 1)
            {
                Gracz zwyciezca = zwyciezcy.First();
                int zdobyteKarty = kartyNaStole.Count;
                zwyciezca.ZdobyteKarty += zdobyteKarty;

                MessageBox.Show($"{zwyciezca.Nazwa} wygrał wojnę i zdobył {zdobyteKarty} kart!");
                foreach (var gracz in gracze)
                {
                    gracz.AktualnaKarta = "-";
                }
                kartyWTurze.Clear();
                graczeWojna.Clear();
                kartyNaStole.Clear();
                wTrakcieWojny = false;

                aktualnaTura++;

                if (aktualnaTura >= liczbaTur)
                {
                    RozstrzygnijGre();
                }
            }
            else
            {
                graczeWojna = zwyciezcy;
                MessageBox.Show("Remis w wojnie! Walka trwa dalej!");

                aktualnyGraczIndex = 0;
            }

            OdswiezPlansze();
        }

        private void RozstrzygnijTure()
        {
            var maxWartosc = kartyWTurze.Max(kv => kv.Value);

            var zwyciezcy = kartyWTurze
                .Where(kv => kv.Value == maxWartosc)
                .Select(kv => kv.Key)
                .ToList();

            if (zwyciezcy.Count == 1)
            {
                Gracz zwyciezca = zwyciezcy.First();
                zwyciezca.ZdobyteKarty += kartyNaStole.Count;
                MessageBox.Show($"{zwyciezca.Nazwa} wygrał tę turę i zdobył {kartyNaStole.Count} kart!");
                foreach (var gracz in gracze)
                {
                    gracz.AktualnaKarta = "-";
                }

                kartyWTurze.Clear();
                kartyNaStole.Clear();
                aktualnaTura++;

                if (aktualnaTura >= liczbaTur)
                {
                    RozstrzygnijGre();
                }
            }
            else
            {
                graczeWojna = zwyciezcy;
                wTrakcieWojny = true;
                MessageBox.Show("Remis! Rozpoczyna się wojna!");

                aktualnyGraczIndex = 0;
            }

            OdswiezPlansze();
        }
        private void RozstrzygnijGre()
        {
            var zwyciezca = gracze.OrderByDescending(g => g.ZdobyteKarty).First();

            MessageBox.Show($"{zwyciezca.Nazwa} wygrał grę z {zwyciezca.ZdobyteKarty} zdobytymi kartami!");

            parentForm.Show();
            this.Close();
        }



        private List<Karta> StworzTalie()
        {
            List<Karta> talia = new List<Karta>();
            string[] kolory = { "♥", "♠", "♣", "♦" };
            string[] wartosci = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "W", "D", "K", "A" };
            int[] wartosciNum = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            foreach (var kolor in kolory)
            {
                for (int i = 0; i < wartosci.Length; i++)
                {
                    talia.Add(new Karta
                    {
                        Kolor = kolor,
                        Wartosc = wartosci[i],
                        WartoscNumeryczna = wartosciNum[i]
                    });
                }
            }
            return talia;
        }
        private void RozdajKarty(List<Gracz> gracze)
        {
            var talia = StworzTalie();
            Random rng = new Random();
            talia = talia.OrderBy(x => rng.Next()).ToList();

            int liczbaKartNaGracza = talia.Count / gracze.Count;

            foreach (var gracz in gracze)
            {
                gracz.KartyNaRece = new List<Karta>();
            }

            int index = 0;
            foreach (var karta in talia)
            {
                gracze[index % gracze.Count].KartyNaRece.Add(karta);
                index++;
            }
        }




        private async void ZagrajTureButton_Click(object sender, EventArgs e)
        {
            if (gracze.Count == 0)
                return;
            Gracz aktualnyGracz;
            if (wTrakcieWojny)
            {
                aktualnyGracz = graczeWojna[aktualnyGraczIndex];
            }
            else
            {
                aktualnyGracz = gracze[aktualnyGraczIndex];
            }
            if (aktualnyGracz.KartyNaRece.Count == 0)
            {
                MessageBox.Show($"{aktualnyGracz.Nazwa} nie ma więcej kart i nie może zagrać w tej turze.");
                aktualnyGraczIndex++;
                if (aktualnyGraczIndex >= gracze.Count)
                {
                    aktualnyGraczIndex = 0;
                    await Task.Delay(1000);
                    RozstrzygnijTure();
                }
                OdswiezPlansze();
                return;
            }
            var karta = aktualnyGracz.KartyNaRece[0];
            aktualnyGracz.KartyNaRece.RemoveAt(0);
            aktualnyGracz.AktualnaKarta = karta.ToString();
            kartyWTurze[aktualnyGracz] = karta.WartoscNumeryczna;
            aktualnyGracz.LiczbaKart--;
            kartyNaStole.Add(karta);
            OdswiezPlansze();

            aktualnyGraczIndex++;

            if (wTrakcieWojny && aktualnyGraczIndex >= graczeWojna.Count)
            {
                aktualnyGraczIndex = 0;
                await Task.Delay(1000);
                RozstrzygnijWojne();
            }
            else if (!wTrakcieWojny && aktualnyGraczIndex >= gracze.Count)
            {
                aktualnyGraczIndex = 0;
                await Task.Delay(1000);
                RozstrzygnijTure();
            }
            SprawdzCzyKoniecGry();
        }
        //Pomocnicza do ZagrajTureButton_Click
        private void SprawdzCzyKoniecGry()
        {
            var graczeZKartami = gracze.Where(g => g.KartyNaRece.Count > 0).ToList();
            if (graczeZKartami.Count == 0)
            {
                RozstrzygnijGre();
            }
            else if (graczeZKartami.Count == 1)
            {
                Gracz zwyciezca = graczeZKartami.First();
                MessageBox.Show($"{zwyciezca.Nazwa} wygrał, jako jedyny posiadający karty!");
                this.Close();
            }
        }

        private void Ustawienia_Click_1(object sender, EventArgs e)
        {
            Form3 ustawienia = new Form3();
            if (ustawienia.ShowDialog() == DialogResult.OK)
            {
                int liczbaGraczy = ustawienia.WybranaLiczbaGraczy;
                int liczbaTur = ustawienia.WybranaLiczbaTur;

                GenerujPlansze(liczbaGraczy, liczbaTur);
            }
        }

        private void Anuluj_Click_1(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }
    }
}
