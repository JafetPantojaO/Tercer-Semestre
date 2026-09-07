using System.Collections.Generic;
using System.Text.Json.Serialization;

public class BlockBusterJson
{
    [JsonPropertyName("titulo")]
    public string nombre { get; set; } = "";

    [JsonPropertyName("titulo_original")]
    public string original { get; set; } = "";

    [JsonPropertyName("reparto_principal")]
    public List<string> reparto { get; set; } = new List<string>();

    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonPropertyName("duracion")]
    public int duracion { get; set; }

    [JsonPropertyName("Calificacion")]
    public float calificacion { get; set; }

    [JsonPropertyName("Pais")]
    public string pais { get; set; }



}