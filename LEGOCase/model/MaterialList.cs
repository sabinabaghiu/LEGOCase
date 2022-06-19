using System.Text.Json.Serialization;

namespace LEGOCase.model;

public class MaterialList
{
    [JsonPropertyName("Materials")]
    public List<Material> Materials { get; set; }
}