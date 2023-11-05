using System.Text.Json.Serialization;

namespace ConsumindoApi.Models
{
    public class BancoModel
    {
        [JsonPropertyName("ispb")]
        public string? Ispb { get; set; }

        [JsonPropertyName("name")]
        public string? Nome { get; set; }

        [JsonPropertyName("code")]
        public int codigo { get; set; }

        [JsonPropertyName("fullName")]
        public string? NomeCompleto { get; set; }
    }
}
