using LEGOCase.model;

namespace LEGOCase;

public class Sorting
{
    public void SortVendorsMaterials(VendorList vendors, MaterialList materials)
    {
        if (vendors.Vendors != null)
            foreach (var vendor in vendors.Vendors)
            {
                Console.Out.WriteLine($"VENDOR: {vendor}");
                if (materials.Materials != null)
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