using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectbaze
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            comboBox1.Items.Add("Laptopuri");
            comboBox1.Items.Add("Telefoane");
            comboBox1.Items.Add("Periferice");
            comboBox1.Items.Add("Tablete");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
