using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace accounting1
{
    public partial class productslist : Form
    {
        public productslist()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("sample.csv");
            for(int i=0;i<lines.Length;i++)
            {
                listBox1.Items.Add(lines[i]);
            }
        }
    }
}
