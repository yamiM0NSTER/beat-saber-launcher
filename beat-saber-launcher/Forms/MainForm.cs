using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using beat_saber_launcher.Helpers;
using beat_saber_launcher.JSON;

namespace beat_saber_launcher.Forms {
  internal partial class MainForm : Form {
    public MainForm() {
      InitializeComponent();
      selectedVersionComboBox.Items.AddRange(SettingsManager.BSVersions.ToArray());
      var selectedItem = SettingsManager.BSVersions.Find(version => version.Guid == SettingsManager.SelectedVersion);
      if(selectedItem != null) {
        selectedVersionComboBox.SelectedItem = selectedItem;
      }

      UpdateControlsState();
    }

    public void UpdateControlsState() {
      selectedVersionComboBox.Enabled = selectedVersionComboBox.Items.Count > 1 && GameLauncher.GameRunning == false;
      if(selectedVersionComboBox.Items.Count == 1) {
        selectedVersionComboBox.SelectedItem = selectedVersionComboBox.Items[0];
      } else if (selectedVersionComboBox.Items.Count == 0) {
        selectedVersionComboBox.SelectedItem = null;
      }
      launchButton.Enabled = propertiesButton.Enabled = selectedVersionComboBox.SelectedItem != null && GameLauncher.GameRunning == false;
      addButton.Enabled = GameLauncher.GameRunning == false;

      BSVersion sVersion = selectedVersionComboBox.SelectedItem as BSVersion;
      if(sVersion != null) {
        pathTextBox.Text = sVersion.Path;
        commandlineTextBox.Text = sVersion.Commandline;
        oculusModeCheckBox.Checked = sVersion.OculusMode;
      } else {
        pathTextBox.Text = "";
        commandlineTextBox.Text = "";
        oculusModeCheckBox.Checked = false;
      }
    }

    private void launchButton_Click(object sender, EventArgs e) {
      GameLauncher.Launch(selectedVersionComboBox.SelectedItem as BSVersion);
    }

    private void addButton_Click(object sender, EventArgs e) {
      var form = new AddVersionForm();
      form.StartPosition = FormStartPosition.CenterParent;
      form.ShowDialog();
    }

    public void AddBSVersion(BSVersion version) {
      selectedVersionComboBox.Items.Add(version);
      UpdateControlsState();
    }

    public void RemoveBSVersion(BSVersion version) {
      selectedVersionComboBox.Items.Remove(version);
      UpdateControlsState();
    }

    private void propertiesButton_Click(object sender, EventArgs e) {
      var form = new EditVersionForm(selectedVersionComboBox.SelectedItem as BSVersion);
      form.StartPosition = FormStartPosition.CenterParent;
      form.ShowDialog();
    }

    private void selectedVersionComboBox_SelectedValueChanged(object sender, EventArgs e) {
      var selectedVersion = selectedVersionComboBox.SelectedItem as BSVersion;
      SettingsManager.SelectedVersion = selectedVersion != null ? selectedVersion.Guid : "";
      SettingsManager.Save();
      UpdateControlsState();
    }


  }
}
