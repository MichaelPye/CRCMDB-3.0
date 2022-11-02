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
    public partial class GenreList : Form
    {
        public GenreList()
        {
            InitializeComponent();
        }

        private void genreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.genreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cRCMDB2DataSet);

        }

        private void GenreList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRCMDB2DataSet.Genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this.cRCMDB2DataSet.Genre);

        }
    }
}
