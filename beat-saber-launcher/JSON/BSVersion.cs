using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace beat_saber_launcher.JSON {
  internal class BSVersion {
    [JsonProperty]
    public string Label { get; set; } = "";

    [JsonProperty]
    public bool OculusMode { get; set; } = false;

    [JsonProperty]
    public string Path { get; set; } = "";

    [JsonProperty]
    public string Commandline { get; set; } = "";

    [JsonProperty]
    public string Guid { get; set; }

    [JsonIgnore]
    public bool isValidPath {
      get {
        if(!Directory.Exists(Path))
          return false;

        if(!File.Exists($"{Path}\\Beat Saber.exe"))
          return false;
        return true;
      }
    }

    public override string ToString() {
      return Label;
    }
  }
}
