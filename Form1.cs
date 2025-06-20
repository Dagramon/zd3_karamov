using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace zd3_karamov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 7;

            dataGridView1.Columns[0].HeaderText = "Название";
            dataGridView1.Columns[1].HeaderText = "Описание";
            dataGridView1.Columns[2].HeaderText = "Белки";
            dataGridView1.Columns[3].HeaderText = "Углеводы";
            dataGridView1.Columns[4].HeaderText = "Количество";
            dataGridView1.Columns[5].HeaderText = "Молочная";
            dataGridView1.Columns[6].HeaderText = "Калорийность";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Обычная")
            {
                numericUpDownCalorie.Enabled = false;
            }
            else if (comboBox1.Text == "Молочная")
            {
                numericUpDownCalorie.Enabled = true;
            }
        }
        private void UpdateDataGrids()
        {
            dataGridView1.Rows.Clear();

            foreach (object food in Food.foodList)
            {
                if (food.GetType().Name == "Food")
                {
                    Food a = food as Food;
                    dataGridView1.Rows.Add(a.name, a.description, a.belok, a.uglevod, a.amount, false);
                }
                else
                {
                    DairyFood a = food as DairyFood;
                    dataGridView1.Rows.Add(a.name, a.description, a.belok, a.uglevod, a.Amount, true, a.P);
                }
            }
            if (dataGridView1.RowCount > 0)
            {
                numericUpDown1.Maximum = dataGridView1.RowCount - 1;
            }
            else
            {
                numericUpDown1.Maximum = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = true;
                if (dataGridView1.RowCount > 1)
                {
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == textBoxName.Text)
                        {
                            check = false;
                        }
                    }
                }
                if (check)
                {
                    if (comboBox1.Text == "Обычная")
                    {
                        if (textBoxName.Text != string.Empty && textBoxDesc.Text != string.Empty && textBoxAmount.Text != string.Empty)
                        {
                            Food.AddFood(textBoxName.Text, textBoxDesc.Text, Convert.ToDouble(numericUpDownBelok.Value), Convert.ToDouble(numericUpDownUglevod.Value), Convert.ToInt32(textBoxAmount.Text));
                        }
                        else if (textBoxAmount.Text == string.Empty && textBoxName.Text != string.Empty && textBoxDesc.Text != string.Empty)
                        {
                            Food.AddFood(textBoxName.Text, textBoxDesc.Text, Convert.ToDouble(numericUpDownBelok.Value), Convert.ToDouble(numericUpDownUglevod.Value));
                        }
                        else if (textBoxDesc.Text == string.Empty && textBoxName.Text != string.Empty && textBoxAmount.Text != string.Empty)
                        {
                            Food.AddFood(textBoxName.Text, Convert.ToDouble(numericUpDownBelok.Value), Convert.ToDouble(numericUpDownUglevod.Value), Convert.ToInt32(textBoxAmount.Text));
                        }
                    }
                    else if (comboBox1.Text == "Молочная")
                    {
                        if (textBoxName.Text != string.Empty && textBoxDesc.Text != string.Empty && textBoxAmount.Text != string.Empty)
                        {
                            DairyFood.AddFood(textBoxName.Text, textBoxDesc.Text, Convert.ToDouble(numericUpDownBelok.Value), Convert.ToDouble(numericUpDownUglevod.Value), Convert.ToInt32(textBoxAmount.Text), Convert.ToDouble(numericUpDownCalorie.Value));
                        }
                        else if (textBoxAmount.Text == string.Empty && textBoxName.Text != string.Empty && textBoxDesc.Text != string.Empty)
                        {
                            DairyFood.AddFood(textBoxName.Text, textBoxDesc.Text, Convert.ToDouble(numericUpDownBelok.Value), Convert.ToDouble(numericUpDownUglevod.Value), Convert.ToDouble(numericUpDownCalorie.Value));
                        }
                        else if (textBoxDesc.Text == string.Empty && textBoxName.Text != string.Empty && textBoxAmount.Text != string.Empty)
                        {
                            DairyFood.AddFood(textBoxName.Text, Convert.ToDouble(numericUpDownBelok.Value), Convert.ToDouble(numericUpDownUglevod.Value), Convert.ToInt32(textBoxAmount.Text), Convert.ToDouble(numericUpDownCalorie.Value));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Еда уже существует");
                }
                UpdateDataGrids();
            }
            catch
            {
                MessageBox.Show("Неверный ввод");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    if (dataGridView1.CurrentRow.Index != -1)
                    {
                        if (Convert.ToBoolean(dataGridView1.CurrentRow.Cells[5].Value) == false)
                        {
                            Food.RemoveFood(dataGridView1.CurrentRow.Index);
                        }
                        else
                        {
                            DairyFood.RemoveFood(dataGridView1.CurrentRow.Index);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удалось удалить");
            }
            UpdateDataGrids();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (Food.foodList.Contains(Food.FindByName(textBox1.Text)))
                {
                    Food.RemoveFood(Food.FindByName(textBox1.Text));
                }
                else if (DairyFood.foodList.Contains(DairyFood.FindByName(textBox1.Text)))
                {
                    DairyFood.RemoveFood(DairyFood.FindByName(textBox1.Text));
                }
            }
            UpdateDataGrids();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Food.RemoveFood(Convert.ToInt32(numericUpDown1.Value));
            UpdateDataGrids();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    if (Convert.ToBoolean(dataGridView1.CurrentRow.Cells[5].Value) == false)
                    {
                        Food food = Food.foodList[dataGridView1.CurrentRow.Index] as Food;
                        MessageBox.Show($"Качество: {food.Quality()}");
                    }
                    else
                    {
                        DairyFood food = Food.foodList[dataGridView1.CurrentRow.Index] as DairyFood;
                        MessageBox.Show($"Качество: {food.Quality()}");
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                if (Convert.ToBoolean(dataGridView1.CurrentRow.Cells[5].Value) == false)
                {
                    Food food = Food.foodList[dataGridView1.CurrentRow.Index] as Food;
                    MessageBox.Show($"{food.Info()}");
                }
                else
                {
                    DairyFood food = Food.foodList[dataGridView1.CurrentRow.Index] as DairyFood;
                    MessageBox.Show($"{food.Info()}");
                }
            }
        }
    }
}
