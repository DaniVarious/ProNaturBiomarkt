using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pronatur_Biomarkt_GmbH
{
    public partial class ProductsScreen : Form
    {

        private SqlConnection conn = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = ProNaturBiomarkt; Integrated Security = True; Encrypt=False");
        
        
        public ProductsScreen()
        {
            InitializeComponent();
            ShowPRoducts();
        }

        private void ShowPRoducts()
        {
            //START
            conn.Open();

            string sql = "SELECT * from Products";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            var dataset = new DataSet();

            adapter.Fill(dataset);


            dataGridViewProducts.DataSource = dataset.Tables[0];

            dataGridViewProducts.Columns[0].Visible = false;


            conn.Close();
        }

        private void buttonProductSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxProductName.Text);
            ShowPRoducts();
        }

        private void buttonProductEdit_Click(object sender, EventArgs e)
        {
            ShowPRoducts();
        }

        private void buttonProductClear_Click(object sender, EventArgs e)
        {
            textBoxProductName.Text = "";
            textBoxProductMarke.Text = "";
            comboBoxProductCathegory.Text = "";
            comboBoxProductCathegory.SelectedItem = null;
            textBoxProductsPrice.Text = "";
        }

        private void buttonProductDelete_Click(object sender, EventArgs e)
        {
            ShowPRoducts();
        }

        private void ProductsScreen_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
