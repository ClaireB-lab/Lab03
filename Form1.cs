using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var list = new List<Product>
            {
                new Book("B1", "The Alchemist", 34.99m, "Paulo Coelho"),
                new Software("S1", "Visual Studio", 110.99m, "Microsoft")
            };
            foreach(var product in list)
            {
                lstProducts.Items.Add(product.GetDisplayText(", "));
            }
        }
    }
}
