using System.Text.Json.Serialization;

namespace FileManagerAPI.Models
{
    public class FileInformationsModel
    {
        [JsonPropertyName("FilePath")]
        public string FilePath { get; set; } = "";

        [JsonPropertyName("DestinationPath")]
        public string DestinationPath { get; set; } = "";
    }
}
