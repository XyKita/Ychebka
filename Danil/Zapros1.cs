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
    public partial class Zapros1 : Form
    {
        private SQLiteConnection Apteka;
        private DataTable dataTable;
        public Zapros1()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {

            string connectionString = "Data Source=Apteka.db;Version=3;";
            Apteka = new SQLiteConnection(connectionString);
        }
        private void Zapros1_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=Apteka.db;Version=3;"))
            {
                connection.Open();
                string selectSql = @"select * from Zapros1";
                using (SQLiteCommand command = new SQLiteCommand(selectSql, connection))
                {
                    dataTable = new DataTable();
                    dataTable.Load(command.ExecuteReader());
                    dataGridView1.DataSource = dataTable;
                    DataRow dataRow = dataTable.Rows[0];


                }
            }

        }
        private void AdjustColumnWidths()
        {
            // Установите ширину для каждого столбца по индексу
            dataGridView1.Columns[0].Width = 20; // Ширина первого столбца
            dataGridView1.Columns[1].Width = 150; // Ширина второго столбца
            dataGridView1.Columns[2].Width = 200; // Ширина третьего столбца
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 100;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Главная Form2 = new Главная();
            Form2.ShowDialog();
            this.Close();
        }
    }
}
