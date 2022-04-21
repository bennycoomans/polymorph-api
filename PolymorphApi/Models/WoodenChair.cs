using PolymorphLib.Models;

namespace PolymorphApi.Models;

public class WoodenChair : Chair
{
	public string WoodType { get; set; } = string.Empty;
	public override FurnitureType FurnitureType => FurnitureType.WoodenChair;
}
