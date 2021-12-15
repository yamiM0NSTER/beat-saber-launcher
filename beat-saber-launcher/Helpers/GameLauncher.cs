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
    public static void Launch(BSVersion version) {
      if(version.isValidPath == false) {
        MessageBox.Show("Correct the path to launch the game", "Invalid path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      string commandLine = $"{(version.OculusMode ? "-vrmode oculus" : "")} {version.Commandline}";

      var process = new Process();
      process.StartInfo = new ProcessStartInfo($"{version.Path}\\Beat Saber.exe") {
        UseShellExecute = false,
        WorkingDirectory = version.Path,
        Arguments = commandLine,
      };
      process.StartInfo.Environment["SteamAppId"] = "620980";

      try {
        process.Start();
      } catch(Exception ex) {
        MessageBox.Show("Exception:", $"{ex}\n{ex.StackTrace}");
      }
    }
  }
}
