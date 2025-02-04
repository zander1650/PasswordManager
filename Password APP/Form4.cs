using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_APP
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
 

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string filepath = "C:\\Users\\zande\\OneDrive\\Desktop\\Password.txt";
            File.AppendAllText(filepath, "Site/Domain: " + text + "\n");

            string text2 = textBox2.Text;
            File.AppendAllText(filepath, "Username/Email/ETC : " + text2 + "\n");

            string text3 = textBox3.Text;
            File.AppendAllText(filepath, "Password : " + text3 + "\n");
            MessageBox.Show("Added");
            Close();
        }
    }
}
