using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace module2._2
{
    public partial class ViewProduct : Form
    {
        public int IdProd;
        public string NameProd;
        public string category;
        public string under_cat;
        public string photo;
        public string creater;
        public string UnderCat;
        public decimal price;
        public int total_size;
        public int total_quanity;
        public decimal SalePrice;
        public string Description;
        public string Compound;
        public ViewProduct product;
        public List<string> Sizes = new List<string>();
        public int CountProduct;
        public DB q = new DB();
        public List<int> IdSales = new List<int>();
        public int ValueNumUp;
        public string size;
        
        public ViewProduct(ViewProduct product)
        {
            InitializeComponent();
            this.product = product;
            SetViewProduct();
            numericUpDown1.TextChanged += numericUpDown1_TextChanged;
            
        }
        public ViewProduct()
        {
            InitializeComponent();
           // numericUpDown1.TextChanged += numericUpDown1_TextChanged;
        }

        public void SetViewProduct()
        {

            label1.Text = $@"{product.creater} | {product.NameProd}";
            label2.Text = $@"Категория: {product.category}";
            label3.Text = total_size > 5 ? "Товаров на складе много" : "Товаров на складе мало";
            label4.Text = $@"Состав: {product.Compound}";
            label8.Text = $@"Подкатегория: {product.UnderCat}";
            label5.Text = $@"Описание: {product.Description}";
            comboBox1.DataSource = product.Sizes;
            pictureBox1.ImageLocation = Path.Combine(Application.StartupPath, @"../../../Images", product.photo);
            if (product.price != 0)
            {
                lblPrice.Font = new Font("Calibri", 9, FontStyle.Strikeout);
                lblPrice.ForeColor = Color.Red;
                label6.Text = Decimal.Round(product.price, 2).ToString() + " руб.";
                lblPrice.Text = Decimal.Round(product.SalePrice, 2).ToString() + " руб.";
                label7.Visible = true;
                label7.Text = "Скидка 25%";
            }
            else
            {
                label6.Visible = false;
                label7.Visible = false;
                lblPrice.Text = Decimal.Round(product.SalePrice, 2).ToString() + " руб.";
            }
            label12.Visible = false;

        }

        public void ValidValueForNumUp()
        {
            bool Fl1 = true;
            bool Fl2 = true;
            timer1.Enabled = false;
            if (string.IsNullOrWhiteSpace(numericUpDown1.Text))
            {
                label12.ForeColor = Color.Red;
                label12.Text = $"Неккоректное значение!";
                label12.Visible = true;
                Fl1 = false;
                ValueNumUp = (int)numericUpDown1.Minimum;
                return;
            }
           
            
            int ChoseVal = Convert.ToInt32(numericUpDown1.Text);
         
            if (ChoseVal > numericUpDown1.Maximum)
            {
                label12.ForeColor = Color.Red;
                label12.Text = $"На складе всего {CountProduct}!";
                label12.Visible = true;
                Fl2 = false;
                ValueNumUp = (int)numericUpDown1.Maximum;
                return;
            }
            bool Flag = Fl1 && Fl2;
            if (Flag)
            {
                timer1.Enabled = true;
                timer1.Stop();
                timer1.Interval = 3000;
                timer1.Start();

            }
            ValueNumUp = ChoseVal;
        }

        public void CountAvailableSize()
        {
            size = comboBox1.Text;
            string sql = $@"select stock.count from stock
JOIN sizes ON stock.size_fk = sizes.id
WHERE sizes.name = '{size}';";
            NpgsqlDataReader reader = q.ExecuteReader(sql);
            while (reader.Read())
            {
                CountProduct = reader.GetInt32(0);
            }
            numericUpDown1.Maximum = CountProduct;
            if (CountProduct > 0)
            {
                label10.Text = $"Товаров: {CountProduct}";
            }
            else
            {
                label10.ForeColor = Color.Red;
                label10.Text = $"Товара нет";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 a = new Form2();
            a.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CountAvailableSize();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckCount();
        }

        public void CheckCount()
        {
            if (CountProduct > 0)
            {
                MessageBox.Show("Товар успешно добавлен в корзину", "Успех", MessageBoxButtons.OK);
                button2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Товара с данными характеристиками не обнаружено", "Ошибка", MessageBoxButtons.OK);
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
            ValidValueForNumUp();
        }
        private void numericUpDown1_TextChanged(object sender, EventArgs e)
        {

            ValidValueForNumUp();
        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            ValidValueForNumUp();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label12.Visible == true)
            {
                label12.Visible = false;
                timer1.Stop();
            }
        }
    }
}
