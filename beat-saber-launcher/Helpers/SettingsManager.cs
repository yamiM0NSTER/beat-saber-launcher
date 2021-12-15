using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using beat_saber_launcher.Forms;
using beat_saber_launcher.JSON;
using Newtonsoft.Json;

namespace beat_saber_launcher.Helpers {
  internal class SettingsManager {
    static Settings _settings;
    static string _path = $"{AppDomain.CurrentDomain.BaseDirectory}Settings.json";

    public static void Initialize() {
      if(!File.Exists(_path)) {
        _settings = new Settings();
        return;
      }

      using(StreamReader file = File.OpenText($"{AppDomain.CurrentDomain.BaseDirectory}Settings.json")) {
        JsonSerializer serializer = new JsonSerializer();
        _settings = (Settings)serializer.Deserialize(file, typeof(Settings));
      }
    }

    public static string SelectedVersion {
      get => _settings.SelectedVersion;
      set => _settings.SelectedVersion = value;
    }

    public static List<BSVersion> BSVersions {
      get => _settings.BSVersions;
    }

    public static MainForm MainForm { get; set; }

    public static void Save() {
      using(StreamWriter file = File.CreateText(_path)) {
        JsonSerializer serializer = new JsonSerializer();
        serializer.Serialize(file, _settings);
      }
    }

    public static void AddBSVersion(BSVersion version) {
      _settings.BSVersions.Add(version);
      MainForm.AddBSVersion(version);
    }

    public static void RemoveBSVersion(BSVersion version) {
      _settings.BSVersions.Remove(version);
      MainForm.RemoveBSVersion(version);
    }
  }
}
