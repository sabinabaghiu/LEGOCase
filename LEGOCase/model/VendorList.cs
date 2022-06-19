using System.Text.Json.Serialization;

namespace LEGOCase.model;

public class VendorList
{
    [JsonPropertyName("Vendors")] 
    public List<Vendor>? Vendors { get; set; }
}