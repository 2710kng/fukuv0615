namespace fukuv0615
{
    public partial class Form1 : Form
    {
        int ans = rand.Next(0, 101);
        int count = 0;
        static Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count += 1;
            MessageBox.Show("{count}��ڂ̒���");
            int guess = 0;

            if (ans == guess);
            {
                MessageBox.Show("Bingo!!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}