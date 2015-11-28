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
    public partial class BookCatalogue : Form
    {
        public BookCatalogue()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // 2. Form für Bibliothek
        Bibliothek f2 = new Bibliothek();
        private void biblio_Click(object sender, EventArgs e)
        {
            f2.Show();
        }
    }
}
