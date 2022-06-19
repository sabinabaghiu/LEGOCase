using LEGOCase.model;

namespace LEGOCase;

public class Sorting
{
    public void SortVendorsMaterials(VendorList vendors, MaterialList materials)
    {
        foreach (var vendor in vendors.Vendors)
        {
            Console.Out.WriteLine($"VENDOR: {vendor}");
            foreach (var material in materials.Materials)
            {
                if (vendor.Id == material.VendorId)
                {
                    Console.Out.WriteLine($"    MATERIAL: {material}");
                }
            }
        }
    }
}