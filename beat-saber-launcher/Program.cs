using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using beat_saber_launcher.Forms;
using beat_saber_launcher.Helpers;

namespace beat_saber_launcher {
  internal static class Program {
    /// <summary>
    /// Main entry point of application.
    /// </summary>
    [STAThread]
    static void Main() {
      SettingsManager.Initialize();

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      SettingsManager.MainForm = new MainForm();
      Application.Run(SettingsManager.MainForm);
    }
  }
}
