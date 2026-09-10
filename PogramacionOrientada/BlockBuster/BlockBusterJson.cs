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

    [JsonPropertyName("calificacion")]
    public float calificacion { get; set; }

    [JsonPropertyName("pais")]
    public string pais { get; set; } = "";
}

public class BlockBusterRespuestaJson
{
    [JsonPropertyName("total")]
    public int total { get; set; }

    [JsonPropertyName("peliculas")]
    public List<BlockBusterJson> peliculas { get; set; } = new List<BlockBusterJson>();
}