using System.Windows.Forms.Design;

namespace Password_APP
{
    public partial class KeypassZF : Form
    {
        public KeypassZF()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            string Pass = File.ReadAllText("C:\\Users\\zande\\OneDrive\\Desktop\\Master.txt");
            string entered = textBox2.Text;

            if (entered != Pass)
            {
                MessageBox.Show("Incorrect Password");
            }
            else if (entered == Pass)
            {

                Form3 form3 = new Form3();
                form3.Show();
                
                
            }

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string filepath = "C:\\Users\\zande\\OneDrive\\Desktop\\Master.txt";
            string check = File.ReadAllText(filepath);
            if (check == "")
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Password has already been set");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
