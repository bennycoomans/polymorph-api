using Newtonsoft.Json;
using NJsonSchema.Converters;

namespace PolymorphLib.Models;

[JsonConverter(typeof(JsonInheritanceConverter), Constants.DISCRIMINATOR)]
public abstract class Furniture
{
}
