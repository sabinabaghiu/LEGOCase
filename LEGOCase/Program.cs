using LEGOCase.model;
using Newtonsoft.Json;

namespace LEGOCase;

internal class Program
{
    public static void Main(string[] args)
    {
        var sorting = new Sorting();
        var vendor = new CheapestVendor();
        var offer = new BestOffer();

        var json = File.ReadAllText("material_vendor_data.json");
        var materials = JsonConvert.DeserializeObject<MaterialList>(json);
        var vendors = JsonConvert.DeserializeObject<VendorList>(json);
        
        if (vendors == null || materials == null) return;
        Console.Out.WriteLine("-----FIRST POINT");
        sorting.SortVendorsMaterials(vendors, materials);
        Console.Out.WriteLine("-----SECOND POINT");
        vendor.FindVendor(materials);
        Console.Out.WriteLine("-----THIRD POINT");
        offer.FindBestOffer(materials, vendors);
    }
}