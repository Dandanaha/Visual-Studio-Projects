using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Catalogue
{
    public partial class loginForm : Form
    {
        public string username, password;
        public loginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //var sr = new System.IO.StreamReader("C:\\" + textBox1.Text + "\\login.ID");
                //username = sr.ReadLine();
                //password = sr.ReadLine();
                //sr.Close();

                if (username == textBox1.Text && password == textBox2.Text)
                {
                    MessageBox.Show("you are now successfully logged in!", "Success");
                    BookCatalogue buchcatalog = new BookCatalogue();
                    buchcatalog.Show();
                }
                else
                    MessageBox.Show("Username or Password is wrong!", "Error!");
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
               MessageBox.Show("The user does not exit!", "Error!");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            rigisterForm f2 = new rigisterForm();
            f2.Show();
        }
    }
    
}
