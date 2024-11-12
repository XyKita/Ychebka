using Microsoft.Win32;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Danil
{
    public partial class Regist : Form
    {
        private readonly string connectionString = "Data Source=Apteka.db;Version=3;";
        public Regist()
        {
            InitializeComponent();
        }
        private void Regist_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Логин = usernametextBox1.Text.Trim();
            string Пароль = passwordtextBox2.Text.Trim();
            // Проверяем, что поля логина и пароля не пустые
            if (Логин == "" || Пароль == "")
            {
                _ = MessageBox.Show("Заполните все поля, пожалуйста!");
                return;
            }
            // Проверка наличия пользователя с таким же email в базе данных
            string checkQuery = $"SELECT COUNT(*) FROM Пользователи WHERE Логин='{Логин}'";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, conn))
                {
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        _ = MessageBox.Show("Такой пользователь уже зарегестрирован. Пожалуйста, введите другой логин.");
                        return;
                    }
                }
                string insertQuery = "INSERT INTO Пользователи (Логин, Пароль, Почта) VALUES (@Логин, @Пароль, @Почта)";
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, conn))
                {
                    command.Parameters.AddWithValue("@Логин", Логин);
                    command.Parameters.AddWithValue("@Пароль", Пароль);
              


                   

                }
            }
            Form Registration1 = new Registration1();
            Registration1.Show();
            Registration1.FormClosed += new FormClosedEventHandler(Regist_Closed);
            this.Hide();

            // Выводим сообщение об успешной регистрации пользователя
            _ = MessageBox.Show("Вы успешно зарегистрировались");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Registration1 Registration1 = new Registration1();
            Registration1.Show();
            Registration1.FormClosed += new FormClosedEventHandler(Regist_Closed);
            this.Hide();

        }

    }
}
