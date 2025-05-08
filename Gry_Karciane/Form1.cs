namespace Gry_Karciane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//Memory
        }

        private void Wojna_Click(object sender, EventArgs e)
        {

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
