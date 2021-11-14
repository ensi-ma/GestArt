using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestArt
{
    public partial class Form1 : Form
    {
        List<Article> arts = new List<Article>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Ajouter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez saisir un nombre","Attention",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtPu.Text = "";
            }
            

        }

        private void Ajouter()
        {
            Article art = new Article(
                txtLib.Text,
                double.Parse(txtPu.Text))
                ;

            arts.Add(art);
            grd.DataSource = null;
            grd.DataSource = arts;
        }
    }
}
