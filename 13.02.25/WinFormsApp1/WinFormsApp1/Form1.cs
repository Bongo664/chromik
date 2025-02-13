namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(45, 50, 2);
            Form2 form2 = new Form2();
            form2.ChangedValue += Form2_ChangedValue;
            form2.ShowDialog();
        }

        private void Form2_ChangedValue(object? sender, int e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                textBox1.Text = e.ToString();
            });
            MethodInvoker methodInvokerDelegate = delegate ()
            {
                textBox1.Text = e.ToString();
            };
            if (this.InvokeRequired)
                this.Invoke(methodInvokerDelegate);
            else
                methodInvokerDelegate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }
    }
}
