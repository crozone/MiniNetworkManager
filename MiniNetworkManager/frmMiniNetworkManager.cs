using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static MiniNetworkManager.RegistryMethods;

namespace MiniNetworkManager
{
    public partial class frmMiniNetworkManager : Form
    {
        public frmMiniNetworkManager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSaveResult.Text = "";
            cmbNetworkCategory.Items.Clear();
            cmbNetworkCategory.Items.AddRange(((NetworkCategoryKind[])Enum.GetValues(typeof(NetworkCategoryKind))).Cast<object>().ToArray());

            RefreshNetworks();
        }

        private void RefreshNetworks()
        {
            lstNetworks.Items.Clear();

            try
            {
                NetworkDetails[] networks = GetNetworks().ToArray();
                lstNetworks.Items.AddRange(networks);
            }
            catch (Exception ex)
            {
                lstNetworks.Items.Clear();
                lstNetworks.Items.Add("Error");
                lstNetworks.Items.Add(ex.Message);
            }
        }

        

        private void lstNetworks_SelectedValueChanged(object sender, EventArgs e)
        {
            // Load info for a network
            //

            NetworkDetails selectedNetwork = lstNetworks.SelectedItem as NetworkDetails;

            ShowNetwork(selectedNetwork);
        }

        private void ShowNetwork(NetworkDetails networkDetails)
        {
            txtNetworkId.Text = networkDetails?.Id ?? "";
            txtNetworkProfileName.Text = networkDetails?.ProfileName ?? "";
            txtNetworkDescription.Text = networkDetails?.Description ?? "";
            cmbNetworkCategory.SelectedItem = networkDetails?.Category ?? NetworkCategoryKind.Private;
            nudNetworkNameType.Value = networkDetails?.NameType ?? 0;

            lblSaveResult.Text = "";
        }

        private NetworkDetails GetNetworkFromUi()
        {
            if (Guid.TryParse(txtNetworkId.Text, out Guid idAsGuid))
            {
                NetworkDetails networkDetails = new NetworkDetails()
                {
                    Id = $"{{{idAsGuid.ToString().ToUpper()}}}",
                    ProfileName = txtNetworkProfileName.Text,
                    Description = txtNetworkDescription.Text,
                    Category = (cmbNetworkCategory.SelectedItem as NetworkCategoryKind?) ?? NetworkCategoryKind.Private,
                    NameType = (int)nudNetworkNameType.Value
                };

                if (string.IsNullOrWhiteSpace(networkDetails.Id))
                {
                    return null;
                }

                return networkDetails;
            }
            else
            {
                return null;
            }
        }

        private void btnRefreshNetworks_Click(object sender, EventArgs e)
        {
            RefreshNetworks();
        }

        private void btnNetworkSave_Click(object sender, EventArgs e)
        {
            NetworkDetails details = GetNetworkFromUi();

            bool saved = false;
            string error = null;

            if (details != null)
            {
                try
                {
                    SaveNetworkDetails(details);
                    saved = true;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                }
            }
            else
            {
                return;
            }

            RefreshNetworks();

            NetworkDetails newDetails = lstNetworks.Items.OfType<NetworkDetails>().FirstOrDefault(n => n.Id == details.Id);
            lstNetworks.SelectedItem = newDetails;

            if (saved)
            {
                lblSaveResult.Text = "Saved.";
            }
            else if (error != null)
            {
                lblSaveResult.Text = error;
            }
        }

        private void btnNetworkDelete_Click(object sender, EventArgs e)
        {
            NetworkDetails details = GetNetworkFromUi();

            bool deleted = false;
            string error = null;

            if (details != null)
            {
                try
                {
                    DeleteNetwork(details);
                    deleted = true;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                }
            }
            else
            {
                return;
            }

            RefreshNetworks();
            lstNetworks.SelectedItem = null;

            if (deleted)
            {
                lblSaveResult.Text = "Deleted.";
            }
            else if (error != null)
            {
                lblSaveResult.Text = error;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout aboutForm = new frmAbout();
            aboutForm.ShowDialog(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
