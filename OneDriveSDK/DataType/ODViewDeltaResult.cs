using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace OneDrive
{
    public class ODViewDeltaResult : ODItemCollection
    {
        [JsonProperty("@delta.token")]
        public string NextToken { get; set; }

        [JsonProperty("@odata.deltaLink")]
        public string DeltaLink { get; set; }

        public ResyncLogic ResyncBehavior { get; set; }
    }

    public enum ResyncLogic
    {
        NoResyncRequired = 0,
        ResyncChangesApplyDifferences,
        ResyncChangesUploadDifferences
    }
}
