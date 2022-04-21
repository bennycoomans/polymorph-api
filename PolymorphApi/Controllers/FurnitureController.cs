using Microsoft.AspNetCore.Mvc;
using PolymorphApi.Models;
using PolymorphLib.Models;

namespace PolymorphApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FurnitureController : ControllerBase
{
	[HttpGet(Name = "GetFurniture")]
	public IEnumerable<Furniture> Get()
	{
		return Enumerable.Range(1, 5).Select(index => new Chair
			{
				HasArmRests = Random.Shared.Next(0, 2) == 0
			})
			.Union<Furniture>(Enumerable.Range(1, 5).Select(index => new Table
			{
				IsWood = Random.Shared.Next(0, 2) == 0
			})).Union<Furniture>(Enumerable.Range(1, 5).Select(index => new WoodenChair
			{
				WoodType = Random.Shared.Next(0, 2) == 0 ? "Oak" : "Cherry"
			}))
			.ToArray();
	}
}
