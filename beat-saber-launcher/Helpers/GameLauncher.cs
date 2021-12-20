using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using beat_saber_launcher.JSON;

namespace beat_saber_launcher.Helpers {
  internal class GameLauncher {

    public static bool GameRunning { get; set; } = false;
    public static void Launch(BSVersion version) {
      if(version.isValidPath == false) {
        MessageBox.Show("Correct the path to launch the game", "Invalid path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      string commandLine = $"{(version.OculusMode ? "-vrmode oculus" : "")} {version.Commandline}";
      var process = new Process();
      var StartInfo = new ProcessStartInfo($"{version.Path}\\Beat Saber.exe");

      StartInfo.UseShellExecute = false;
      StartInfo.WorkingDirectory = version.Path;
      StartInfo.Arguments = commandLine.Trim();
      StartInfo.Environment["SteamAppId"] = "620980";

      process.EnableRaisingEvents = true;
      process.StartInfo = StartInfo;
      process.Exited += new EventHandler((object sender, EventArgs e) => {
        GameRunning = false;
        SettingsManager.MainForm.UpdateControlsState();
      });

      try {
        process.Start();
        GameRunning = true;
        SettingsManager.MainForm.UpdateControlsState();
      } catch(Exception ex) {
        MessageBox.Show($"{ex}\n{ex.StackTrace}","Exception:");
      }
    }
  }
}
