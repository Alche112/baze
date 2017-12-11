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
    public partial class Inregistrare : Form
    {
        Form1 frm;
        public Inregistrare(Form1 fr)
        {
            InitializeComponent();
            frm = fr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }
    }
}
