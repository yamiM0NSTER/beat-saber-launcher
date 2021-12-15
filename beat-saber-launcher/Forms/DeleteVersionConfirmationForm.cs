using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using beat_saber_launcher.JSON;
using beat_saber_launcher.Helpers;

namespace beat_saber_launcher.Forms {
  internal partial class DeleteVersionConfirmationForm : Form {
    BSVersion _BSVersion;
    bool _Deleted = false;

    public bool Deleted { get => _Deleted; }

    public DeleteVersionConfirmationForm(BSVersion version) {
      _BSVersion = version;
      InitializeComponent();
      textLabel.Text = $"Are you sure you want to delete\nVersion: {_BSVersion.Label}?";
    }

    private void yesButton_Click(object sender, EventArgs e) {
      SettingsManager.RemoveBSVersion(_BSVersion);
      SettingsManager.Save();
      _Deleted = true;
      this.Close();
    }

    private void noButton_Click(object sender, EventArgs e) {
      this.Close();
    }
  }
}
