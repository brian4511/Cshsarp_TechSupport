using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport
{
    public partial class frmTechParent : Form
    {
        public frmTechParent()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maintainProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childProductMaint = new frmProductMaint();
            childProductMaint.MdiParent = this;
            childProductMaint.Show();
            
        }

        private void maintainTechniciansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childTechMaint = new frmTechMaintenance();
            childTechMaint.MdiParent = this;
            childTechMaint.Show();
        }

        private void maintainCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childCustIncident = new frmCustomerIncidents();
            childCustIncident.MdiParent = this;
            childCustIncident.Show();
        }
    }
}
