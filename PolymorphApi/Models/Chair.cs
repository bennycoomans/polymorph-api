using PolymorphLib.Models;

namespace PolymorphApi.Models;

public class Chair : Furniture
{
	public bool HasArmRests { get; set; }
	public override FurnitureType FurnitureType => FurnitureType.Chair;
}
