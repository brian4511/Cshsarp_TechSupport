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
    public partial class frmProductMaint : Form
    {
        public frmProductMaint()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (productsBindingSource.Count == 0) return;
            {
                if (this.Validate())
                {
                    try
                    {
                        this.productsBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.dsProducts);
                    }
                    catch (ArgumentException ex)    
                    {
                        MessageBox.Show(ex.Message, "Argument Exception");                    
                        productsBindingSource.CancelEdit();
                    }
                    catch (DBConcurrencyException)      //another user changed the customer
                    {
                        MessageBox.Show("A concurrency error occurred. " + "Some rows were not updated.", "Concurrency Exception");

                        //refill the Customers data table to get the most recent changes made by another user
                        this.productsTableAdapter.Fill(this.dsProducts.Products);
                    }
                    catch (DataException ex)           //user entered data to cause this exception
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                        //bad data exists in a column so cancel the transaction
                        productsBindingSource.CancelEdit();
                    }
                    catch (SqlException ex)
                    {
                        //problem with the database server can happen
                        MessageBox.Show("Database error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void frmProductMaint_Load(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.Fill(this.dsProducts.Products);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
            }
        }
    }
}
