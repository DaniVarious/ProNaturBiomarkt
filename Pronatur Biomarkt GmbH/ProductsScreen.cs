using Microsoft.SqlServer.Server;
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
        private int SelectionID = 0;
        
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

            if (SelectionID>0)
            {
                dataGridViewProducts.Rows[SelectionID].Selected = true;
            }
            
        }

        private void buttonProductSave_Click(object sender, EventArgs e)
        {

            string nameValue = textBoxProductName.Text;
            string markeValue = textBoxProductMarke.Text;
            string kathegorieValue = comboBoxProductCathegory.Text;
            string PreisValue = textBoxProductsPrice.Text.Replace(",",".");


            conn.Open();

            string sql = "INSERT INTO Products (Name, Marke, Kathegorie, Preis)" +
                " SELECT '" + nameValue + "', '" + markeValue + "', '" + kathegorieValue + "', " + PreisValue;
            SqlCommand com = new SqlCommand(sql, conn);
            com.ExecuteNonQuery();

            conn.Close();

            ShowPRoducts();
        }

        private void buttonProductEdit_Click(object sender, EventArgs e)
        {
            string nameValue = textBoxProductName.Text;
            string markeValue = textBoxProductMarke.Text;
            string kathegorieValue = comboBoxProductCathegory.Text;
            string PreisValue = textBoxProductsPrice.Text.Replace(",", ".");
            string id = dataGridViewProducts.CurrentRow.Cells["ID"].Value.ToString();

            conn.Open();

            string sql = "Update Products Set Name = '" + nameValue + "', Marke = '" + markeValue + "', Kathegorie = '" + kathegorieValue + "', Preis = " + PreisValue + " WHERE ID = " + id;
            SqlCommand com = new SqlCommand(sql, conn);
            com.ExecuteNonQuery();

            conn.Close();


            ShowPRoducts();
        }

        private void buttonProductClear_Click(object sender, EventArgs e)
        {
            textBoxProductName.Text = "";
            textBoxProductMarke.Text = "";
            comboBoxProductCathegory.Text = "";
            comboBoxProductCathegory.SelectedItem = null;
            textBoxProductsPrice.Text = "";

            SelectionID = 0;
        }

        private void buttonProductDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen sie wirklich löschen? Dieser Vorgang kan nicht wieder rückgängig gemacht werden!","Löschen?", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) ==DialogResult.OK) {            
                conn.Open();

                string sql = "Delete Products  WHERE ID = " + SelectionID;
                SqlCommand com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();

                conn.Close();

                SelectionID = 0;
                ShowPRoducts();
            }
        }

        private void ProductsScreen_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            string nameValue = dataGridViewProducts.CurrentRow.Cells["Name"].Value.ToString();
            string markeValue = dataGridViewProducts.CurrentRow.Cells["Marke"].Value.ToString();
            string kathegorieValue = dataGridViewProducts.CurrentRow.Cells["Kathegorie"].Value.ToString();
            string PreisValue = dataGridViewProducts.CurrentRow.Cells["Preis"].Value.ToString();

            textBoxProductName.Text = nameValue; 
            textBoxProductMarke.Text = markeValue;
            comboBoxProductCathegory.Text = kathegorieValue;
            comboBoxProductCathegory.SelectedItem = kathegorieValue;
            textBoxProductsPrice.Text = PreisValue;

            SelectionID = int.Parse(dataGridViewProducts.CurrentRow.Cells["ID"].Value.ToString());

        }
    }
}
