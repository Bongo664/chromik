using Microsoft.VisualBasic.Logging;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        int haslo;
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            DialogResult result = form2.ShowDialog();
            if (result == DialogResult.OK)
            {
                haslo = int.Parse(form2.textBox2.Text);
            }
            else if (result == DialogResult.Cancel)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Podaj kod";
            button2.Enabled = false;
        }
        int kod1;
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 podaj = new Form2();
            DialogResult result2 = podaj.ShowDialog();
            if(result2 == DialogResult.OK)
            {
                kod1 = int.Parse(podaj.textBox2.Text);
                sprawHaslo(haslo,kod1);
            }
            else if (result2 == DialogResult.Cancel)
            {
            }
        }
        void sprawHaslo(int haslo, int kod1)
        {
            if (haslo == kod1)
            {
                textBox1.Text = "Has³o poprawne";
                button2.Enabled = true;
            }
            else
            {
                textBox1.Text = "Has³o niepoprawne";
            }
        }
    }
}
