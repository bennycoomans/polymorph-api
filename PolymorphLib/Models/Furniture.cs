using Newtonsoft.Json;
using NJsonSchema.Converters;

namespace PolymorphLib.Models;

[JsonConverter(typeof(JsonInheritanceConverter), "type")]
public abstract class Furniture
{
}
