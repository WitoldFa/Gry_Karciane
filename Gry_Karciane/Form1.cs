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
                  "� Gra karciana dla 2, 3 lub 4 graczy.\n" +
                  "� Karty s� rozdzielane po r�wno mi�dzy graczy. Kart jest 52, nie uwzgl�dniamy Joker�w\n" +
                  "� W ka�dej turze gracze wyk�adaj� po jednej karcie.\n" +
                  "� Gracz z najwy�sz� kart� wygrywa tur� i zbiera wszystkie karty.\n" +
                  "� W przypadku remisu (WOJNY) � gracze wyk�adaj� kolejne karty.\n" +
                  "� Gra trwa do ustalonego limitu tur.\n\n" +
                  "WYGRANA:\n" +
                  "� Wygrywa gracz z najwi�ksz� ilo�ci� zabranych kart.\n\n" +
                  "Kliknij OK, aby rozpocz��.";

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
