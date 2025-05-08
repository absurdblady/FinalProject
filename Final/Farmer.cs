using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Farmer : Form, IProductHandler
    {
        private List<Tuple<string, decimal>> products = new List<Tuple<string, decimal>>();

        public Farmer()
        {
            InitializeComponent();
        }

        private void Farmer_Load(object sender, EventArgs e)
        {
            // Optional startup logic
        }

        public void AddProduct(string name, decimal price)
        {
            products.Add(new Tuple<string, decimal>(name, price));
            MessageBox.Show($"Product '{name}' added at ${price}");
        }

        public void ListProducts()
        {
            if (products.Count == 0)
            {
                MessageBox.Show("No products added yet.");
                return;
            }

            string productList = "Products:\n";
            foreach (var item in products)
            {
                productList += $"- {item.Item1}: ${item.Item2}\n";
            }

            MessageBox.Show(productList);
        }

        // All your button click logic should go below here
        private void button1_Click(object sender, EventArgs e)
        {
            // Your calculation logic
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            record.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Taxes tax = new Taxes();
            tax.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }


        private void listProductBtn_Click(object sender, EventArgs e)
        {
            ListProducts();
        }

        private void productNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void productPriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text.Trim();

            if (decimal.TryParse(priceBox.Text.Trim(), out decimal price))
            {
                AddProduct(name, price);
                nameBox.Clear();
                priceBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid price.");
            }
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            ListProducts();
        }
    }

}
