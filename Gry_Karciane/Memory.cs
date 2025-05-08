using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gry_Karciane
{
    public partial class Memory : Form
    {
        private Button[,] przyciski;
        private string[,] karty;
        private List<Button> odkryte = new List<Button>();
        private int znalezionePary = 0;
        private int totalPary;
        private int punkty = 1000;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        private System.Windows.Forms.Timer statusTimer = new System.Windows.Forms.Timer();

        private Stopwatch stoper = new Stopwatch();

        private int wiersze = 4;
        private int kolumny = 4;
        public Memory()
        {
            InitializeComponent();
            Shown += Memory_Shown;
        }
        private void Memory_Shown(object sender, EventArgs e)
        {
            // Wybór rozmiaru planszy
            var wynik = MessageBox.Show("Czy chcesz planszę 6x6? (Tak = 6x6, Nie = 4x4)", "Wybierz rozmiar", MessageBoxButtons.YesNo);
            if (wynik == DialogResult.Yes)
            {
                wiersze = 6;
                kolumny = 6;
            }
            else
            {
                wiersze = 4;
                kolumny = 4;
            }

            totalPary = (wiersze * kolumny) / 2;
            GenerujKarty(wiersze, kolumny);
            GenerujPlansze(wiersze, kolumny);

            stoper.Start();

            statusTimer.Interval = 1000;
            statusTimer.Tick += StatusTimer_Tick;
            statusTimer.Start();
            AktualizujStatus();
        }
        private void StatusTimer_Tick(object sender, EventArgs e)
        {
            punkty -= 5;
            if (punkty < 0) punkty = 0;
            AktualizujStatus();

            if (punkty <= 0)
            {
                stoper.Stop();
                statusTimer.Stop();
                MessageBox.Show("Koniec gry – straciłeś wszystkie punkty!", "Przegrana");
                this.Close();
            }
        }
        private void AktualizujStatus()
        {
            TimeSpan czas = stoper.Elapsed;
            lblPunkty.Text = $"Punkty: {punkty} | Czas: {czas:mm\\:ss}";
        }
        private void GenerujKarty(int w, int k)
        {
            string[] talia = {
                "♠A", "♥Q", "♦K", "♣J", "♠10", "♥9",
                "♦8", "♣7", "♠6", "♥5", "♦4", "♣3",
                "♠2", "♥A", "♦Q", "♣K", "♠J", "♥10"
            };

            List<string> paraKarty = talia.Take((w * k) / 2).SelectMany(x => new[] { x, x }).ToList();
            Random rnd = new Random();
            paraKarty = paraKarty.OrderBy(x => rnd.Next()).ToList();

            karty = new string[w, k];
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    karty[i, j] = paraKarty[i * k + j];
                }
            }
        }
        private void GenerujPlansze(int w, int k)
        {
            tableLayoutPanel1.RowCount = w;
            tableLayoutPanel1.ColumnCount = k;
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();

            przyciski = new Button[w, k];

            for (int i = 0; i < w; i++)
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / w));
            for (int j = 0; j < k; j++)
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / k));

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Button btn = new Button();
                    btn.Dock = DockStyle.Fill;
                    btn.Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold);
                    btn.Tag = new Point(i, j);
                    btn.Text = "";
                    btn.BackColor = Color.LightGray;
                    btn.Click += Karta_Click;
                    przyciski[i, j] = btn;
                    tableLayoutPanel1.Controls.Add(btn, j, i);
                }
            }
        }
        private void Karta_Click(object sender, EventArgs e)
        {
            if (odkryte.Count == 2) return;

            Button klikniety = sender as Button;
            Point p = (Point)klikniety.Tag;
            int x = p.X, y = p.Y;

            klikniety.Text = karty[x, y];
            klikniety.Enabled = false;
            odkryte.Add(klikniety);

            if (odkryte.Count == 2)
            {
                Button b1 = odkryte[0];
                Button b2 = odkryte[1];

                if (b1.Text == b2.Text)
                {
                    znalezionePary++;
                    punkty += 150;
                    odkryte.Clear();

                    if (znalezionePary == totalPary)
                    {
                        stoper.Stop();
                        statusTimer.Stop();
                        AktualizujStatus();

                        TimeSpan czas = stoper.Elapsed;
                        MessageBox.Show($"Gratulacje! Znalazłeś wszystkie pary!\nPunkty: {punkty}\nCzas: {czas:mm\\:ss}", "Koniec gry");
                        this.Close();
                    }
                }
                else
                {
                    punkty -= 30;
                    timer.Interval = 1000;
                    timer.Tick += Timer_Tick;
                    timer.Start();
                }
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Tick -= Timer_Tick;

            foreach (var btn in odkryte)
            {
                btn.Text = "";
                btn.Enabled = true;
            }
            odkryte.Clear();
        }
        private void Memory_Load(object sender, EventArgs e)
        {

        }
    }
}
