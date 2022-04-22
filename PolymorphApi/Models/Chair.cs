using PolymorphLib.Models;

namespace PolymorphApi.Models;

public class Chair : Furniture
{
	public bool HasArmRests { get; set; }
	public Details MandatoryDetails { get; set; } = new();
	public Details? OptionalDetails { get; set; }
}

public class Details
{
	public string Information { get; set; } = string.Empty;
}
