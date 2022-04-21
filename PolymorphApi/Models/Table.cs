using PolymorphLib.Models;

namespace PolymorphApi.Models;

public class Table : Furniture
{
	public bool IsWood { get; set; }
	public override FurnitureType FurnitureType => FurnitureType.Table;
}
