namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Rchanged += Form2_Rchanged;
            form2.Gchanged += Form2_Gchanged;
            form2.Bchanged += Form2_Bchanged;
            form2.Show();
        }

        private int red, green, blue;

        private void Form2_Rchanged(object? sender, int e)
        {
            red = e;
            kolor(red, green, blue);
        }

        private void Form2_Gchanged(object? sender, int e)
        {
            green = e;
            kolor(red, green, blue);
        }

        private void Form2_Bchanged(object? sender, int e)
        {
            blue = e;
            kolor(red, green, blue);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void kolor(int red, int green, int blue)
        {
            pictureBox1.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}