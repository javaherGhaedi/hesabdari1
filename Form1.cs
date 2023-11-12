using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accounting1
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customers cs = new customers();
            cs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customerslist sc = new customerslist();
            sc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            products cs = new products();
            cs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            productslist sc = new productslist();
            sc.Show();
        }
    }
}
