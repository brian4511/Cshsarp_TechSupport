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
    public partial class frmTechMaintenance : Form
    {
        public frmTechMaintenance()
        {
            InitializeComponent();
        }

        private void techniciansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (techniciansBindingSource.Count == 0) return;
                
                if (this.Validate())
                {
                    try
                    {
                        this.techniciansBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.dsTechnicians);
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message, "Argument Exception");
                        techniciansBindingSource.CancelEdit();
                    }
                    catch (DBConcurrencyException ex)
                    {
                        MessageBox.Show(ex.Message, "A concurreny error occured.");
                        this.techniciansTableAdapter.Fill(this.dsTechnicians.Technicians);
                    }
                    catch (DataException ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                        techniciansBindingSource.CancelEdit();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
                    }
                }
        }

        private void frmTechMaintenance_Load(object sender, EventArgs e)
        {
            try
            {
                this.techniciansTableAdapter.Fill(this.dsTechnicians.Technicians);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
            }
        }
    }
}
