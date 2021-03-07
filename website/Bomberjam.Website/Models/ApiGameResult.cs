using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Bomberjam.Website.Models
{
    public sealed class ApiGameResult
    {
        [Required]
        [JsonPropertyName("serializedHistory")]
        public string SerializedHistory { get; set; }

        [JsonPropertyName("standardOutput")]
        public string StandardOutput { get; set; }

        [JsonPropertyName("standardError")]
        public string StandardError { get; set; }

        [JsonPropertyName("playerBotIds")]
        public IDictionary<string, string> PlayerBotIds { get; set; }

        [JsonPropertyName("origin")]
        public GameOrigin Origin { get; set; }
    }
}