using LEGOCase.model;

namespace LEGOCase;

public class CheapestVendor
{
    public void FindVendor(MaterialList materials)
    {
        var updatedMaterialList = new List<Material>();
        foreach (var material in materials.Materials)
        {
            updatedMaterialList.Add(handleDetails(material));
        }

        var groupedMaterials = updatedMaterialList
            .GroupBy(m => m.Name)
            .Select(r => r.ToList())
            .ToList();

        foreach (var materialList in groupedMaterials)
        {
            var cheapest = materialList.OrderBy(x => x.PricePerUnit).First();
            Console.Out.WriteLine(
                $"Material: {cheapest.Name}, cheapest vendor id: {cheapest.VendorId}, price per unit: {cheapest.PricePerUnit} " +
                $"delivery time: {cheapest.DeliveryTimeDays} days");
        }
    }


    public Material handleDetails(Material material)
    {
        switch (material.Currency)
        {
            case "USD":
                material.Currency = "POUND";
                convert(material, 0.82f, 0.45f);

                break;
            case "DKK":
                material.Currency = "POUND";
                convert(material, 0.12f, 0.45f);

                break;
            case "EURO":
                material.Currency = "POUND";
                convert(material, 0.86f, 0.45f);

                break;
            default:
                convert(material, 1, 0.45f);

                break;
        }

        return material;
    }

    private void convert(Material material, float price, float unit)
    {
        if (material.Unit.Equals("kg"))
        {
            material.PricePerUnit *= price;
        }
        else
        {
            material.PricePerUnit *= price * unit;
            material.Unit = "kg";
        }
    }
}