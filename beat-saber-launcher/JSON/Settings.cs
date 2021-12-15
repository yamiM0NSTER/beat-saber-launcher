using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beat_saber_launcher.JSON {
  internal class Settings {
    [JsonProperty]
    public string SelectedVersion { get; set; } = "";

    [JsonProperty]
    public List<BSVersion> BSVersions { get; set; } = new List<BSVersion>();

  }
}
