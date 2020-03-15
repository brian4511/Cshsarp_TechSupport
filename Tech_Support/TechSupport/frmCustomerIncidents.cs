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
    public partial class frmCustomerIncidents : Form
    {
        public frmCustomerIncidents()
        {
            InitializeComponent();
        }

        private void fillByCustomerIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                int customerID = Convert.ToInt32(txtGetCustomerID.Text);

                this.customersTableAdapter.FillByCustomerID(dsCustomerIncidents.Customers, customerID);
                if (customersBindingSource.Count > 0)
                {
                    this.incidentsTableAdapter.FillByCustomerID(dsCustomerIncidents.Incidents, customerID);
                }
                else
                {
                    MessageBox.Show("No customer with the ID. " + "Please Try Again.", "Customer Not Found");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Customer ID must be an integer.", "Entry Error");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
            }
        }

        private void incidentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int i = e.RowIndex;

                DataGridViewRow row = incidentsDataGridView.Rows[i];

                DataGridViewCell cell = row.Cells[2];

                string code = (string)cell.Value;

                frmProductView frmProducts = new frmProductView();
                frmProducts.code = code;
                frmProducts.incidentNumber = (int)this.incidentsTableAdapter.TotalIncidentsByProduct(code);
                frmProducts.ShowDialog();
            }
        }
    }
}
