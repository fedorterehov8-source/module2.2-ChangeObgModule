using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace module2._2
{
    public partial class ProductControl : UserControl
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
        public List<int> IdSales = new List<int>();
        ViewProduct product = new ViewProduct();
        public List<string> Sizes = new List<string>();
        public DB q = new DB();
        public ProductControl()
        {
            InitializeComponent();
            label7.Visible = false;
        }
        public void SetProd()
        {
            label1.Text = $@"{creater} | {NameProd}";
            label2.Text = $@"Категория: {category}";
            label3.Text = total_size > 5 ? "Товаров на складе много" : "Товаров на складе мало";
            label4.Text = $@"Состав: {Compound}";
            pictureBox1.ImageLocation = Path.Combine(Application.StartupPath, @"../../../Images", photo);
            if (price != 0)
            {
                lblPrice.Font = new Font("Calibri", 9, FontStyle.Strikeout);
                lblPrice.ForeColor = Color.Red;
                label6.Text = Decimal.Round(price, 2).ToString() + " руб.";
                lblPrice.Text = Decimal.Round(SalePrice, 2).ToString() + " руб.";
                label7.Visible = true;
                label7.Text = "Скидка 25%";
            }
            else
            {
                label6.Visible = false;
                lblPrice.Text = Decimal.Round(SalePrice, 2).ToString() + " руб.";
            }
            if (total_quanity <= 3)
            {
                this.BackColor = ColorTranslator.FromHtml("#ff8080");
            }
        }

        public void SizeId()
        {
            string sql = $@"Select sizes.name from stock
JOIN sizes ON stock.size_fk = sizes.id
JOIN product ON stock.product_fk = product.id WHERE product.id = '{IdProd}';";
            NpgsqlDataReader reader = q.ExecuteReader(sql);
            while (reader.Read()) {
                Sizes.Add(reader.GetString(0));

             }
        }

        public void ControlSped()
        {
            
                product.IdProd = IdProd;
                product.NameProd = NameProd;
                product.category = category;
                product.under_cat = under_cat;
                product.creater = creater;
                product.Compound = Compound;
                product.SalePrice = SalePrice;
                product.total_size = total_size;
                product.total_quanity = total_quanity;
                product.photo = photo;
                product.UnderCat = UnderCat;
                product.Description = Description;
                product.Sizes = Sizes;
                product.IdSales = IdSales;
                if (IdSales.Contains(product.IdProd))
                {
                    product.SalePrice = SalePrice;
                    product.price = product.SalePrice * Convert.ToDecimal(0.75);
                }
        
                
            }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SizeId();
            ControlSped();
            ViewProduct a = new ViewProduct(product);
            a.ShowDialog();
           
        }
    }
}
