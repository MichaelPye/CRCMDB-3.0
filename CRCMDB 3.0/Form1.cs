using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRCMDB_3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Opens Up Movie Management Form
        private void ManageMoviesButton_Click(object sender, EventArgs e)
        {
                MovieForm MovForm = new MovieForm();
                MovForm.Show();
        }

        private void ManageActorsButton_Click(object sender, EventArgs e)
        {
            ActorForm ActForm = new ActorForm();
            ActForm.Show();
        }

        private void ManageGenresButton_Click(object sender, EventArgs e)
        {
            GenreList genreList = new GenreList();
            genreList.Show();
        }
    }
}
