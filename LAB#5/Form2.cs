using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Создание столбцов таблицы
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Номер";
            dataGridView1.Columns[1].Name = "Имя";
            dataGridView1.Columns[2].Name = "Возраст";
            dataGridView1.Columns[3].Name = "Город";
            dataGridView1.Columns[4].Name = "Страна";

            // Заполнение таблицы данными
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                string[] row = new string[5];
                row[0] = (i + 1).ToString();
                row[1] = "Имя " + (i + 1);
                row[2] = random.Next(18, 60).ToString();
                row[3] = "Город " + random.Next(1, 6);
                row[4] = "Страна " + random.Next(1, 6);
                dataGridView1.Rows.Add(row);
            }
        }
    }
}