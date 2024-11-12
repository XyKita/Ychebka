using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Danil
{
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Nalik Nalik = new Nalik();
            Nalik.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            preparati preparati = new preparati();
            preparati.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Zapros1 Zapros1 = new Zapros1();
            Zapros1.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Zapros2 Zapros2 = new Zapros2();
            Zapros2.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Zapros3 Zapros3 = new Zapros3();
            Zapros3.ShowDialog();
            this.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Zapros4 Zapros4 = new Zapros4();
            Zapros4.ShowDialog();
            this.Close();
        }
    }
}
