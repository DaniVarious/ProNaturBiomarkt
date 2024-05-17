using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pronatur_Biomarkt_GmbH
{
    public partial class ProductsScreen : Form
    {
        public ProductsScreen()
        {
            InitializeComponent();
        }

        private void buttonProductSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxProductName.Text);
        }

        private void buttonProductEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonProductClear_Click(object sender, EventArgs e)
        {

        }

        private void buttonProductDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
