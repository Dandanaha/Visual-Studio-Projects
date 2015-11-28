using System;
using System.IO;
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
    public partial class rigisterForm : Form
    {
            public rigisterForm()
            {
                InitializeComponent();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                rigisterForm f2 = new rigisterForm();
                f2.Hide();

            }

            private void button1_Click(object sender, EventArgs e)
            {
                    try { 
                            var sw = new System.IO.StreamWriter("C:\\" + textBox1.Text + "\\login.ID");
                            sw.Write(textBox1.Text + "\n" + textBox2.Text);
                            sw.Close();
                    }
                    catch (System.IO.DirectoryNotFoundException ex)
                    {
                        System.IO.Directory.CreateDirectory("C:\\" + textBox1.Text);
                        var sw = new System.IO.StreamWriter("C:\\" + textBox1.Text + "\\login.ID");
                            sw.Write(textBox1.Text + "\n" + textBox2.Text);
                            sw.Close();
                    }
                }
    
    }
}
