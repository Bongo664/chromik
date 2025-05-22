using System.Net;
using System.Net.Mail;
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
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            textBox1.Text = fileDialog.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "TXT files |*.txt";
            fileDialog.ShowDialog();
            textBox1.Text = fileDialog.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("technikprogramista.pzs@gmail.com");
            MailAddress to = new MailAddress(textBox2.Text);

            MailMessage email = new MailMessage(from, to);
            email.Subject = textBox3.Text;
            email.Body = richTextBox1.Text;

            Attachment attachment = new Attachment(textBox1.Text);
            email.Attachments.Add(attachment);

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("technikprogramista.pzs@gmail.com", "cbhpxxheqwbzugod");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            smtp.Send(email);
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
