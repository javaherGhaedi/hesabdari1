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
    public partial class products : Form
    {
        public products()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phone = textBox1.Text;
            string colour = textBox2.Text;
            string memory = textBox3.Text;
            string line = phone + "," + colour + "," + memory + "\n";
            File.AppendAllText("sample.csv", line);
        }
    }
}
