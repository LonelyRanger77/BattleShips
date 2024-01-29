namespace BattleShips
{
    public partial class Startscreen : Form
    {
        public Startscreen()
        {
            InitializeComponent();
        }
        
        private void LoadGame(object sender, EventArgs e)
        {
            BattleShips gameWindow = new BattleShips();
            gameWindow.Show();
        }

        private void ExitGame(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text !="")
                button1.Enabled = true;
        }
    }
}