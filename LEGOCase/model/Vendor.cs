using System.Text.Json.Serialization;
using System.Text.Json;

namespace LEGOCase.model;

public class Vendor
{
    [JsonPropertyName("ID")]
    public int Id { get; set; }
    [JsonPropertyName("Name")] 
    public string Name { get; set; }
    [JsonPropertyName("PostalCode")]
    public string PostalCode { get; set; }
    [JsonPropertyName("Address")]
    public string Address { get; set; }
    [JsonPropertyName("ContactPerson")]
    public string ContactPerson { get; set; }
    [JsonPropertyName("ECOFriendly")]
    public bool EcoFriendly { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}