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

namespace TechSupport
{
    public partial class frmProductView : Form
    {
        public string code;
        public int incidentNumber;
        public frmProductView()
        {
            InitializeComponent();
        }
        private void frmProductView_Load(object sender, EventArgs e)
        {
            try
            {   
                this.productsTableAdapter.FillByProductCode(dsCustomerIncidents.Products, code);
                String name = dataGridViewTextBoxColumn2.DataGridView.Rows[0].Cells[1].Value.ToString();
                txtIncidentReport.Text = "Total incident count for " + name + " is: " + incidentNumber;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Server error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }

        }
    }
}
