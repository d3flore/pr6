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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCurrent.Text = "0";
            txtLast.Text = "0";
            txtPrice.Text = "0";
            txtPurchase.Text = "0";
        }

        private double getPurchase(int pCurrent, int pLast, double price)
        {
            double purchase = (pCurrent - pLast) * price;
            return purchase;
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

        private void button4_Click(object sender, EventArgs e)
            {
                if (txtCurrent.Text != "" && txtLast.Text != "" && txtPrice.Text != "") // если поля заполнены
                {
                    int pCurrent = Convert.ToInt32(txtCurrent.Text);
                    int pLast = Convert.ToInt32(txtLast.Text);
                    double pPrice = Convert.ToInt32(txtPrice.Text);
                    if (pCurrent >= pLast) // проверка, что текущее значение >= предыдущего
                    {
                        double purchase = getPurchase(pCurrent, pLast, pPrice);
                        txtPurchase.Text = purchase.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Текущее значение должно быть больше предыдущего", "Внимание:");
                    }
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text != "" && txtFirstName.Text != "" && txtAdress.Text != "" && int.Parse(txtPurchase.Text) != 0)
            {
                MessageBox.Show($"Платеж {txtPurchase.Text} принят! \n Плательщик {txtLastName.Text} {txtFirstName.Text} ");
            }
            else
            {
                if (txtLastName.Text == "")
                {
                    MessageBox.Show("Заполните фамилию!", "Внимание:");
                }
                if (txtFirstName.Text == "")
                {
                    MessageBox.Show("Заполните имя!", "Внимание:");
                }
                if (txtAdress.Text == "")
                {
                    MessageBox.Show("Заполните адрес!", "Внимание:");
                }
                if (int.Parse(txtPurchase.Text) == 0)
                {
                    MessageBox.Show("Вычислите оплату!", "Внимание:");
                }
            }
        }

        private void txtCurrent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.KeyChar = '\0';
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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
            txtPrice.Text = "0";
            txtPurchase.Text = "0";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
