using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using beat_saber_launcher.Helpers;
using beat_saber_launcher.JSON;

namespace beat_saber_launcher.Forms {
  internal partial class EditVersionForm : Form {
    BSVersion _BSVersion;
    public EditVersionForm(BSVersion version) {
      _BSVersion = version;
      InitializeComponent();
      UpdateControlsState();
    }

    private void UpdateControlsState() {
      labelTextBox.Text = _BSVersion.Label;
      pathTextBox.Text = _BSVersion.Path;
      oculusModeCheckBox.Checked = _BSVersion.OculusMode;
      commandlineTextBox.Text = _BSVersion.Commandline;
    }

    private void selectPathButton_Click(object sender, EventArgs e) {
      var dialog = new OpenFileDialog();
      dialog.Filter = "Game Executable|Beat Saber.exe";
      dialog.Title = "Select Beat Saber location:"; 
      dialog.ValidateNames = true;
      dialog.CheckPathExists = true;
      dialog.CheckFileExists = true;
      dialog.AutoUpgradeEnabled = true;
      var result = dialog.ShowDialog();
      if(result == DialogResult.OK) {
        pathTextBox.Text = Path.GetDirectoryName(dialog.FileName);
      }
    }

    private void cancelButton_Click(object sender, EventArgs e) {
      this.Close();
    }

    private bool ValidateFields() {
      if(labelTextBox.Text == "") {
        MessageBox.Show( "Label can't be empty!", "Label is empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
      }

      string path = pathTextBox.Text;
      if(path.Length == 0) {
        MessageBox.Show("Path can't be empty!", "Path is empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
      }

      if(!Directory.Exists(path)) {
        MessageBox.Show("Directory doesn't exist!", "Directory doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
      }

      if(Directory.EnumerateFiles(path, "Beat Saber.exe").Count() == 0) {
        MessageBox.Show("Directory doesn't contain Beat Saber!", "Bad Directory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
      }

      return true;
    }

    private void deleteButton_Click(object sender, EventArgs e) {
      var form = new DeleteVersionConfirmationForm(_BSVersion);
      form.StartPosition = FormStartPosition.CenterParent;
      form.FormClosing += (object formSender, FormClosingEventArgs formE) => {
        if(form.Deleted)
          this.Close();
      };
      form.ShowDialog();
    }

    private void saveButton_Click(object sender, EventArgs e) {
      if(!ValidateFields())
        return;

      _BSVersion.Label = labelTextBox.Text;
      _BSVersion.Path = pathTextBox.Text;
      _BSVersion.OculusMode = oculusModeCheckBox.Checked;
      _BSVersion.Commandline = commandlineTextBox.Text;

      SettingsManager.Save();
      SettingsManager.MainForm.UpdateControlsState();
      this.Close();
    }
  }
}
