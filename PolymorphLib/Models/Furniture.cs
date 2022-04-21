using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PolymorphLib.Models;

public enum FurnitureType
{
	Chair,
	Table,
	WoodenChair
}

public abstract class Furniture
{
	[JsonConverter(typeof(StringEnumConverter))]
	public FurnitureType Type => FurnitureType;

	[JsonIgnore]
	public abstract FurnitureType FurnitureType { get; }
}