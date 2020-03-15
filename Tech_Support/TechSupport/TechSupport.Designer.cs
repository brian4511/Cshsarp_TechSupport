namespace TechSupport
{
    partial class frmTechParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTechnicianIncidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainRegistrationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainTechniciansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationIncidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayCustomersByProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayIncidentsByProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayOpenIncidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createIncidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateIncidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayOpenIncidentsByTechnicianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMailingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayIncidentsByProductAndTechnicianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayIncidentsByCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.registrationIncidentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportTechnicianIncidentsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportTechnicianIncidentsToolStripMenuItem
            // 
            this.exportTechnicianIncidentsToolStripMenuItem.Name = "exportTechnicianIncidentsToolStripMenuItem";
            this.exportTechnicianIncidentsToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.exportTechnicianIncidentsToolStripMenuItem.Text = "Export Technician Incidents";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintainProductsToolStripMenuItem,
            this.maintainCustomersToolStripMenuItem,
            this.maintainRegistrationsToolStripMenuItem,
            this.maintainTechniciansToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // maintainProductsToolStripMenuItem
            // 
            this.maintainProductsToolStripMenuItem.Name = "maintainProductsToolStripMenuItem";
            this.maintainProductsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.maintainProductsToolStripMenuItem.Text = "Maintain Products";
            this.maintainProductsToolStripMenuItem.Click += new System.EventHandler(this.maintainProductsToolStripMenuItem_Click);
            // 
            // maintainCustomersToolStripMenuItem
            // 
            this.maintainCustomersToolStripMenuItem.Name = "maintainCustomersToolStripMenuItem";
            this.maintainCustomersToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.maintainCustomersToolStripMenuItem.Text = "Maintain Customers";
            this.maintainCustomersToolStripMenuItem.Click += new System.EventHandler(this.maintainCustomersToolStripMenuItem_Click);
            // 
            // maintainRegistrationsToolStripMenuItem
            // 
            this.maintainRegistrationsToolStripMenuItem.Name = "maintainRegistrationsToolStripMenuItem";
            this.maintainRegistrationsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.maintainRegistrationsToolStripMenuItem.Text = "Maintain Registrations";
            // 
            // maintainTechniciansToolStripMenuItem
            // 
            this.maintainTechniciansToolStripMenuItem.Name = "maintainTechniciansToolStripMenuItem";
            this.maintainTechniciansToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.maintainTechniciansToolStripMenuItem.Text = "Maintain Technicians";
            this.maintainTechniciansToolStripMenuItem.Click += new System.EventHandler(this.maintainTechniciansToolStripMenuItem_Click);
            // 
            // registrationIncidentsToolStripMenuItem
            // 
            this.registrationIncidentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayCustomersByProductToolStripMenuItem,
            this.displayIncidentsByProductToolStripMenuItem,
            this.displayOpenIncidentsToolStripMenuItem,
            this.createIncidentToolStripMenuItem,
            this.updateIncidentToolStripMenuItem,
            this.displayOpenIncidentsByTechnicianToolStripMenuItem,
            this.createMailingListToolStripMenuItem,
            this.displayIncidentsByProductAndTechnicianToolStripMenuItem,
            this.displayIncidentsByCustomerToolStripMenuItem});
            this.registrationIncidentsToolStripMenuItem.Name = "registrationIncidentsToolStripMenuItem";
            this.registrationIncidentsToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.registrationIncidentsToolStripMenuItem.Text = "Registration Incidents";
            // 
            // displayCustomersByProductToolStripMenuItem
            // 
            this.displayCustomersByProductToolStripMenuItem.Name = "displayCustomersByProductToolStripMenuItem";
            this.displayCustomersByProductToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.displayCustomersByProductToolStripMenuItem.Text = "Display Customers by Product";
            // 
            // displayIncidentsByProductToolStripMenuItem
            // 
            this.displayIncidentsByProductToolStripMenuItem.Name = "displayIncidentsByProductToolStripMenuItem";
            this.displayIncidentsByProductToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.displayIncidentsByProductToolStripMenuItem.Text = "Display Incidents by Product";
            // 
            // displayOpenIncidentsToolStripMenuItem
            // 
            this.displayOpenIncidentsToolStripMenuItem.Name = "displayOpenIncidentsToolStripMenuItem";
            this.displayOpenIncidentsToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.displayOpenIncidentsToolStripMenuItem.Text = "Display Open Incidents";
            // 
            // createIncidentToolStripMenuItem
            // 
            this.createIncidentToolStripMenuItem.Name = "createIncidentToolStripMenuItem";
            this.createIncidentToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.createIncidentToolStripMenuItem.Text = "Create Incident";
            // 
            // updateIncidentToolStripMenuItem
            // 
            this.updateIncidentToolStripMenuItem.Name = "updateIncidentToolStripMenuItem";
            this.updateIncidentToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.updateIncidentToolStripMenuItem.Text = "Update Incident";
            // 
            // displayOpenIncidentsByTechnicianToolStripMenuItem
            // 
            this.displayOpenIncidentsByTechnicianToolStripMenuItem.Name = "displayOpenIncidentsByTechnicianToolStripMenuItem";
            this.displayOpenIncidentsByTechnicianToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.displayOpenIncidentsByTechnicianToolStripMenuItem.Text = "Display Open Incidents by Technician";
            // 
            // createMailingListToolStripMenuItem
            // 
            this.createMailingListToolStripMenuItem.Name = "createMailingListToolStripMenuItem";
            this.createMailingListToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.createMailingListToolStripMenuItem.Text = "Create Mailing List";
            // 
            // displayIncidentsByProductAndTechnicianToolStripMenuItem
            // 
            this.displayIncidentsByProductAndTechnicianToolStripMenuItem.Name = "displayIncidentsByProductAndTechnicianToolStripMenuItem";
            this.displayIncidentsByProductAndTechnicianToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.displayIncidentsByProductAndTechnicianToolStripMenuItem.Text = "Display Incidents by Product and Technician";
            // 
            // displayIncidentsByCustomerToolStripMenuItem
            // 
            this.displayIncidentsByCustomerToolStripMenuItem.Name = "displayIncidentsByCustomerToolStripMenuItem";
            this.displayIncidentsByCustomerToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.displayIncidentsByCustomerToolStripMenuItem.Text = "Display Incidents by Customer";
            // 
            // frmTechParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTechParent";
            this.Text = "Technical Support";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationIncidentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportTechnicianIncidentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainRegistrationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainTechniciansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayCustomersByProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayIncidentsByProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayOpenIncidentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createIncidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateIncidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayOpenIncidentsByTechnicianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMailingListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayIncidentsByProductAndTechnicianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayIncidentsByCustomerToolStripMenuItem;
    }
}

