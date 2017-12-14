using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace projectbaze
{
   
    public partial class Form1 : Form
    {
        Inregistrare frm;
        public Form1()
        {
            InitializeComponent();
            frm = new Inregistrare(this);
            textBox2.PasswordChar = '#';
            textBox2.MaxLength = 50;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alex\Documents\log.mdf;Integrated Security=True;Connect Timeout=30");
                var connection = new SqlConnection();
                connection.ConnectionString = @"Server=.\alex;Initial Catalog=magazin;Trusted_Connection=true;";
                connection.Open();
                Console.WriteLine(connection.ServerVersion.ToString());
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Admin where Username='" + textBox1.Text + "'and Password='" + textBox2.Text + "'", connection);
                DataTable dt = new DataTable();
                //con.Open();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Main ss = new Main();
                    ss.Show();
                  //  frm.Show();
                }
                else
                {
                    MessageBox.Show("USER sau PAROLA incorecta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inregistrare sss = new Inregistrare(this);
            sss = new Inregistrare(this);
            sss.Show();
        }
    }
}
