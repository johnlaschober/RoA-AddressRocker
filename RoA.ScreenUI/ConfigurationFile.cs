using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.ScreenUI
{
    public class ConfigurationFile
    {
        public string StateSavePath { get; set; }

        public void Save(string savePath)
        {
            string json = JsonConvert.SerializeObject(this);
            File.WriteAllText(savePath, json);
        }
    }
}
