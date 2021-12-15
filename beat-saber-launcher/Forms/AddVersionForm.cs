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
  public partial class AddVersionForm : Form {
    public AddVersionForm() {
      InitializeComponent();
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

    private void addButton_Click(object sender, EventArgs e) {
      if(ValidateFields() == false)
        return;

      BSVersion version = new BSVersion() {
        Label = labelTextBox.Text,
        Path = pathTextBox.Text,
        OculusMode = oculusModeCheckBox.Checked,
        Commandline = commandlineTextBox.Text,
        Guid = Guid.NewGuid().ToString(),
      };

      SettingsManager.AddBSVersion(version);
      SettingsManager.Save();
      this.Close();
    }
  }
}
