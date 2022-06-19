using System.Text.Json.Serialization;
using System.Text.Json;

namespace LEGOCase.model;

public class Material
{
    [JsonPropertyName("ID")] 
    public int Id { get; set; }
    [JsonPropertyName("Name")]
    public string Name { get; set; }
    [JsonPropertyName("VendorID")] 
    public int VendorId { get; set; }
    [JsonPropertyName("Color")] 
    public string Color { get; set; }
    [JsonPropertyName("PricePerUnit")] 
    public float PricePerUnit { get; set; }
    [JsonPropertyName("Currency")] 
    public string Currency { get; set; }
    [JsonPropertyName("Unit")] 
    public string Unit { get; set; }
    [JsonPropertyName("MeltingPoint")] 
    public float MeltingPoint { get; set; }
    [JsonPropertyName("TempUnit")] 
    public string TempUnit { get; set; }
    [JsonPropertyName("DeliveryTimeDays")] 
    public int DeliveryTimeDays { get; set; }
    
    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}