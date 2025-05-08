namespace Gry_Karciane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//Wojna
        }

        private void Wojna_Click(object sender, EventArgs e)
        {
            string zasady = "ZASADY GRY: WOJNA\n\n" +
                  "– Gra karciana dla 2, 3 lub 4 graczy.\n" +
                  "– Karty s¹ rozdzielane po równo miêdzy graczy. Kart jest 52, nie uwzglêdniamy Jokerów\n" +
                  "– W ka¿dej turze gracze wyk³adaj¹ po jednej karcie.\n" +
                  "– Gracz z najwy¿sz¹ kart¹ wygrywa turê i zbiera wszystkie karty.\n" +
                  "– W przypadku remisu (WOJNY) – gracze wyk³adaj¹ kolejne karty.\n" +
                  "– Gra trwa do ustalonego limitu tur.\n\n" +
                  "WYGRANA:\n" +
                  "– Wygrywa gracz z najwiêksz¹ iloœci¹ zabranych kart.\n\n" +
                  "Kliknij OK, aby rozpocz¹æ.";

            MessageBox.Show(zasady, "Zasady gry: Wojna", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            WojnaGra form2 = new WojnaGra(this);
            form2.Show();
        }

        private void Memory_Click(object sender, EventArgs e)
        {

        }

        private void Blackjack_Click(object sender, EventArgs e)
        {

        }

        private void Historia_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
