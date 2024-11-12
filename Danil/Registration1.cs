using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Danil
{
    public partial class Registration1 : Form
    {
        private readonly string connectionString = "Data Source=Apteka.db;Version=3;";
        public Registration1()
        {
            InitializeComponent();
        }
        private void Registration1_Load(object sender, EventArgs e)
        {
            {

                // Ваши команды SQL здесь
            }
        }
        private void AuthoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form Главная = new Главная();
            Главная.Show();

            this.Hide();
        }
    }
}

  
