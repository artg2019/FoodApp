using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp.UI
{
    public partial class Catalog<T> : Form
        where T : class
    {
        public Catalog(DbSet<T> db)
        {
            InitializeComponent();
            dataGridView.DataSource = db.Local.ToBindingList();
        }

    }
}
