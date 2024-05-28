using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace LAB_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {

                var column1 = new DataGridViewColumn();
                column1.HeaderText = "Название";
                column1.Width = 110;
                column1.ReadOnly = true;
                column1.Name = "name";
                column1.Frozen = true;
                column1.CellTemplate = new DataGridViewTextBoxCell();
                var column2 = new DataGridViewColumn();
                column2.HeaderText = "Цена";
                column2.Name = "price";
                column2.CellTemplate = new DataGridViewTextBoxCell();
                var column3 = new DataGridViewColumn();
                column3.HeaderText = "Остаток";
                column3.Name = "count";
                column3.CellTemplate = new DataGridViewTextBoxCell();
                dataGridView1.Columns.Add(column1);
                dataGridView1.Columns.Add(column2);
                dataGridView1.Columns.Add(column3);
                dataGridView1.AllowUserToAddRows = false;
                int count = 3;
                for (int i = 1; i < 5; ++i)
                {
                    dataGridView1.Rows.Add("Пример 1, Товар " + i, i * 350, count);
                    count += 3;
                }

                for (int i = 1; i < 5; ++i)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1["name", dataGridView1.Rows.Count - 1].Value = "Пример 2, Товар " + i;
                    dataGridView1["price", dataGridView1.Rows.Count - 1].Value = i * 350;
                    dataGridView1["count", dataGridView1.Rows.Count - 1].Value = count;
                    count += 3;
                }
                for (int i = 1; i < dataGridView1.Rows.Count; ++i)
                {
                    for (int j = 1; j < dataGridView1.Columns.Count; ++j)
                    {
                        object o = dataGridView1[j, i].Value;
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n;
            while (!int.TryParse(textBox1.Text, out n) || n < 1) // проверка данных
            {
                MessageBox.Show("Ошибка в данных!");
                textBox1.Focus();
                return;
            }

            dataGridView1.ColumnCount = dataGridView1.RowCount = n;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Заменить следующую строку на нужную математическую формулу
                    dataGridView1[i, j].Value = (i + 1) * (j + 1);
                }
                
            }
        }
    }
}
//Принцип заполнения таблицы данными по математической формуле может быть добавлен внутри вложенных циклов. В данном примере, вместо значения "1" для элементов главной диагонали, добавлена математическая формула "(i+1) * (j+1)", которая умножает номер текущей строки на номер текущего столбца.