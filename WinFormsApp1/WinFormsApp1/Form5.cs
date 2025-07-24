using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        List<Product> products = new List<Product>
        {
            new Product {Id = 1, Name = "Product 1", Price = 100},
            new Product {Id = 2, Name = "Product 2", Price = 200},
            new Product {Id = 3, Name = "Product 3", Price = 300}
        };

        public Form5()
        {
            InitializeComponent();
            dataGridView1.DataSource = products;
        }
    }
}
