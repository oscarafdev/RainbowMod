using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fougerite.Models
{
    public class RainbowConfig
    {
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }

        [JsonProperty(PropertyName = "tellversion")]
        public bool TellVersion { get; set; }

        [JsonProperty(PropertyName = "deployabledecay")]
        public bool DeployableDecay { get; set; }

        [JsonProperty(PropertyName = "structuredecay")]
        public bool StructureDecay { get; set; }

        [JsonProperty]
        public bool? RemovePlayersFromCache { get; set; }

        [JsonProperty]
        public bool BanOnInvalidPacket { get; set; }

        [JsonProperty]
        public bool EnableDefaultRustDecay { get; set; }

        [JsonProperty]
        public bool AutoBanCraft { get; set; }

        [JsonProperty]
        public int FloodConnections { get; set; }

        [JsonProperty]
        public int SaveTime { get; set; }

        [JsonProperty]
        public int SaveCopies { get; set; }

        [JsonProperty]
        public bool StopServerOnSaveFail { get; set; }

        [JsonProperty]
        public int CrucialSavePoint { get; set; }

        [JsonProperty]
        public string SaveNotification { get; set; }

        [JsonProperty]
        public bool RustChat { get; set; }

        [JsonProperty]
        public bool RPCChat { get; set; }

        [JsonProperty]
        public string ClientFunction { get; set; }
    }
}
