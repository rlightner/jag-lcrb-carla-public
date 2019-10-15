namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;

    public enum SecurityStatusPicklist
    {
        PASS = 845280000,
        FAIL = 845280001,
        WITHDRAWN = 845280003
    }

    public partial class MicrosoftDynamicsCRMadoxioWorker
    {

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ContactId@odata.bind")]
        public string ContactIdAccountODataBind { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateofbirth")]
        [JsonConverter(typeof(SimpleDateTimeConverter))]
        public System.DateTimeOffset? AdoxioDateofbirth { get; set; }
    }
}
