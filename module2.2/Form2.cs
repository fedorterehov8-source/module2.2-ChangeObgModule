using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace module2._2
{
    public partial class Form2 : Form
    {
        public List<int> IdSales = new List<int>();
        public List<ProductControl> list = new List<ProductControl>();
        string role;
        string name;
        DB a = new DB();
        string cat;
        public Form2()
        {
            InitializeComponent();
            this.role = ConstData.role;
            this.name = ConstData.name;
            Sales();
            card();
            labels();
        }

        public void labels()
        {
            label2.Text = "Имя: " + name;
            label3.Text = "Роль: " + role;
        }
        public void Sales()
        {
            IdSales.Clear();
            string query = @"Select product_fk from orders where date_trunc('month', date_) = (Select date_trunc('month', Max(date_)) from 
orders)
EXCEPT 
Select product_fk from orders 
where date_trunc('month', date_) = (Select date_trunc('month', Max(date_)-INTERVAL '1 month')
from orders)";
            NpgsqlDataReader READER = a.ExecuteReader(query);
            while (READER.Read())
            {
                IdSales.Add(READER.GetInt32(0));

            }
        }

        public void Product()
        {
            string sql = @"SELECT  product.id,category.name, under_category.name, photo, 
product.name, creater.name, compound,price, 
COUNT(sizes.id) as total_sizes, SUM(stock.count) as total_quantity,description
FROM public.product JOIN public.category ON 
category.id = product.category_fk JOIN public.under_category 
ON under_category.id = product.under_categ_fk 
JOIN public.creater ON creater.id = product.creater_fk 
JOIN public.stock ON stock.product_fk = product.id 
JOIN public.sizes ON sizes.id = stock.size_fk 
group by  product.id,category.name, under_category.name, photo, 
product.name,creater.name,compound, price;";
            NpgsqlDataReader reader = a.ExecuteReader(sql);
            while (reader.Read())
            {
                ProductControl product = new ProductControl();
                product.IdProd = reader.GetInt32(0);
                product.NameProd = reader.GetString(4);
                product.category = reader.GetString(1);
                product.under_cat = reader.GetString(2);
                product.creater = reader.GetString(5);
                product.Compound = reader.GetString(6);
                product.SalePrice = reader.GetDecimal(7);
                product.total_size = reader.GetInt32(8);
                product.total_quanity = reader.GetInt32(9);
                product.photo = reader.GetString(3);
                product.UnderCat = reader.GetString(2);
                product.Description = reader.GetString(10);
                product.IdSales = this.IdSales;
                if (IdSales.Contains(product.IdProd))
                {
                    product.SalePrice = reader.GetDecimal(7);
                    product.price = product.SalePrice * Convert.ToDecimal(0.75);
                    product.IdSales = IdSales;
                }
                product.SetProd();
               
                list.Add(product);
            }
        }
        public void card()
        {
            Product();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.SuspendLayout();
            foreach (var pr in list)
            {
                flowLayoutPanel1.Controls.Add(pr);
            }
            flowLayoutPanel1.ResumeLayout();
        }

        public void SearchCardSort()
        {
            string search = textBox1.Text.Trim().ToLower();

            flowLayoutPanel1.SuspendLayout();
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is ProductControl card)
                {
                    bool matchesSearch = string.IsNullOrEmpty(search) || card.NameProd.ToLower().Contains(search);
                    bool matSort = string.IsNullOrEmpty(cat) || card.category.Equals(cat);
                    card.Visible = matchesSearch && matSort;
                }
            }
            flowLayoutPanel1.ResumeLayout();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                cat = "";
                textBox1.Clear();
                comboBox1.SelectedIndex = -1;
                SearchCardSort();
            }
            else
            {
                cat = comboBox2.SelectedItem?.ToString() ?? "";
                SearchCardSort();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cards = flowLayoutPanel1.Controls.Cast<ProductControl>().ToList();
            if (comboBox1.SelectedIndex == 1)
            {
                cards = cards.OrderByDescending(c => c.SalePrice).ToList();
            }
            else
            {
                cards = cards.OrderBy(c => c.SalePrice).ToList();
            }
            for (int i = 0; i < cards.Count; i++)
            {
                flowLayoutPanel1.Controls.SetChildIndex(cards[i], i);
            }
            SearchCardSort();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            IdSales.Clear();
            Sales();
            card();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchCardSort();
        }
    }
}
    
