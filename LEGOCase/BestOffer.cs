using LEGOCase.model;

namespace LEGOCase;

public class BestOffer
{
    CheapestVendor vendor = new CheapestVendor();

    public void FindBestOffer(MaterialList materials, VendorList vendorList)
    {
        var resultByName = materials.Materials
            .Where(m => m.Name.Equals("Polymethyl Methacrylate (PMMA)"))
            .ToList();

        var finalResult = resultByName
            .Where(m => m.MeltingPoint >= 200 && m.MeltingPoint <= 300)
            .ToList();

        foreach (var material in finalResult)
        {
            convertTemp(material);
        }

        var updatedMaterialList = new List<Material>();
        foreach (var item in finalResult)
        {
            updatedMaterialList.Add(vendor.handleDetails(item));
        }

        var best = updatedMaterialList.OrderBy(x => x.DeliveryTimeDays).ThenBy(y => y.PricePerUnit)
            .ThenBy(x => isEcoFriendly(x.VendorId, vendorList)).First();
        Console.Out.WriteLine(
            $"Best offer for {best.Name} is with id: {best.Id}, has the melting point {best.MeltingPoint}," +
            $" price per {best.Unit} {best.PricePerUnit} {best.Currency}, delivery time {best.DeliveryTimeDays}," +
            $" and comes from vendor id {best.VendorId}");
    }

    private void convertTemp(Material material)
    {
        if (material.TempUnit.Equals("F"))
        {
            material.TempUnit = "C";
            material.MeltingPoint = (material.MeltingPoint - 32) / 1.8f;
        }
    }

    private bool isEcoFriendly(int id, VendorList vendors)
    {
        if (vendors.Vendors.Find(x => x.Id == id)!.EcoFriendly)
        {
            return true;
        }

        return false;
    }
}