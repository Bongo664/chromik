using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public event EventHandler<int> Rchanged;
        public event EventHandler<int> Gchanged;
        public event EventHandler<int> Bchanged;
        public Form2()
        {
            InitializeComponent();
        }

        public void trackBar1_Scroll(object sender, EventArgs e)
        {
            Rchanged?.Invoke(this, trackBar1.Value);
        }

        public void trackBar2_Scroll(object sender, EventArgs e)
        {
            Gchanged?.Invoke(this, trackBar2.Value);
        }

        public void trackBar3_Scroll(object sender, EventArgs e)
        {
            Bchanged?.Invoke(this, trackBar3.Value);
        }
    }
}