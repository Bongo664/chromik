namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "text";
            this.BackColor = Color.White;
            //this.Width = 100;
            // this.Height = 100;
            Button przycisk = new Button();
            przycisk.Width = 50;
            przycisk.Height = 50;
            przycisk.Location = new Point(10, 10);
            przycisk.Text = "przycisk";
            this.Controls.Add(przycisk);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 loguj = new Form2();
            //loguj.ShowDialog();
            //loguj.Show();
            DialogResult result = loguj.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (loguj.textBox2.Text == "asd")
                {         
                    this.textBox1.Text = loguj.textBox1.Text;
                    this.textBox2.Text = loguj.textBox2.Text;
                }
                else
                {
                    this.textBox1.Text = "zle";
                    this.textBox2.Text = "zle";
                }
            }
            else if (result == DialogResult.Cancel)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
