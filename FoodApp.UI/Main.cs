using FoodApp.BL;
using FoodApp.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp.UI
{
    public partial class Main : Form
    {
        FoodContext db;
        public Main()
        {
            InitializeComponent();
            db = new FoodContext();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(db.Products);
            catalogProduct.Show();
        }
    }
}
