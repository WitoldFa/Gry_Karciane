namespace Gry_Karciane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//Blackjack
        }

        private void Wojna_Click(object sender, EventArgs e)
        {
            string zasady = "ZASADY GRY: WOJNA\n\n" +
                  "– Gra karciana dla 2, 3 lub 4 graczy.\n" +
                  "– Karty są rozdzielane po równo między graczy. Kart jest 52, nie uwzględniamy Jokerów\n" +
                  "– W każdej turze gracze wykładają po jednej karcie.\n" +
                  "– Gracz z najwyższą kartą wygrywa turę i zbiera wszystkie karty.\n" +
                  "– W przypadku remisu (WOJNY) – gracze wykładają kolejne karty.\n" +
                  "– Gra trwa do ustalonego limitu tur.\n\n" +
                  "WYGRANA:\n" +
                  "– Wygrywa gracz z największą ilością zabranych kart.\n\n" +
                  "Kliknij OK, aby rozpocząć.";

            MessageBox.Show(zasady, "Zasady gry: Wojna", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            WojnaGra form2 = new WojnaGra(this);
            form2.Show();
        }

        private void Memory_Click(object sender, EventArgs e)
        {
            Memory mem = new Memory();
            mem.Show();
            this.Hide();
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
