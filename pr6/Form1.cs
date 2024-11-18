using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtCurrent.Text = "0";
            txtLast.Text = "0";
            txtPurchase.Text = "0";
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text != "" && txtFirstName.Text != "" && txtLastName.Text != "" && int.Parse(txtPurchase.Text) != 0)
            {
                MessageBox.Show($"Оплата прошла успешна ! \n Товар {txtLastName.Text} {txtFirstName.Text} {txtAdress.Text}. К оплате {txtPurchase.Text} руб. ");
            }
            else
            {
                if (txtLastName.Text == "")
                {
                    MessageBox.Show("Заполните производителя!");
                }
                if (txtFirstName.Text == "")
                { 
                MessageBox.Show("Заполните марку ");
                }
                if (txtLastName.Text == "")
                {
                    MessageBox.Show("Заполните модель!");
                }
            }
            if (int.Parse(txtPurchase.Text) == 0)

                MessageBox.Show("Вычеслите оплату !");

        }

        private void txtCurrent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.KeyChar = '\0';
            }
        }

        private void txtLast_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.KeyChar = '\0';
            }
        }

        private void txtCurrent_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text != "")
            {
                txtLastName.Clear();
            }
            if (txtFirstName.Text != "")
            {
                txtFirstName.Clear();
            }
            if (txtAdress.Text != "")
            {
                txtAdress.Clear();
            }

            txtCurrent.Text = "0";
            txtLast.Text = "0";
            txtPurchase.Text = "0";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLast_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCurrent.Text) && !string.IsNullOrWhiteSpace(txtLast.Text) && comboBox1.SelectedItem != null)
            {

                // Преобразование значений из текстовых полей
                int pCurrent = Convert.ToInt32(txtCurrent.Text);
                int pLast = Convert.ToInt32(txtLast.Text);
                string bonus_card = comboBox1.SelectedItem.ToString();

                if (pCurrent > 0 && pLast > 0)
                {
                    // Расчет скидки
                    double discountPercent = 0;
                    if (bonus_card == "нет")
                    {
                        discountPercent = 0;
                    }
                    else if (bonus_card == "обычная")
                    {
                        discountPercent = 1;
                    }
                    else if (bonus_card == "золотая")
                    {
                        discountPercent = 5;
                    }
                    else if (bonus_card == "платиновая")
                    {
                        discountPercent = 10;
                    }


                    double totalCost = pCurrent * pLast;
                    double discount = (totalCost * discountPercent) / 100; 
                    double finalCost = totalCost - discount;


                    txtPurchase.Text = finalCost.ToString();
                }
                else
                {
                    MessageBox.Show("Текущая и последняя стоимость должны быть больше нуля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
