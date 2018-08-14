using System;
using AeroWizard;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AeroWizardDemo
{
    public partial class frmWizard : Form
    {
        public frmWizard()
        {
            InitializeComponent();
        }

        private void frmWizard_Load(object sender, EventArgs e)
        {

        }

        private void frmWizard_Shown(object sender, EventArgs e)
        {

        }

        #region Wizard Control
        private async void wcServerSettings_SelectedPageChanged(object sender, EventArgs e)
        {
            WizardControl wc = (sender as WizardControl);
            if (wc != null)
            {
                switch (wc.SelectedPage.Name)
                {
                    case "wpSqlServerSettings":
                        await PopulateSqlServers();
                        break;
                    case "wpMySqlSettings":
                        await PopulateMySqlServers();
                        break;
                }
            }
        }
        #endregion Wizard Control

        #region Sql Page
        private async Task PopulateSqlServers()
        {

        }

        private async void cmbSqlServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            await PopulateSqlDatabases();
        }

        private async Task PopulateSqlDatabases()
        {

        }

        private async void cmbSqlDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            await PopulateSqlTables();
        }

        private async Task PopulateSqlTables()
        {

        }
        #endregion Sql Page

        #region MySql Page
        private async Task PopulateMySqlServers()
        {

        }

        private void cmbMySqlServers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCustomName_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCustomName.Checked)
            {
                txtCustomName.Enabled = true;
                txtCustomName.Focus();
            }
            else
                txtCustomName.Enabled = false;
        }
        #endregion MySql Page
    }
}