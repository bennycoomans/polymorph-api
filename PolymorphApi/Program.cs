using PolymorphApi.Models;
using PolymorphLib;
using PolymorphLib.Models;
using PolymorphLib.SchemaFilters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddSwaggerGen(c =>
{
	c.SchemaFilter<RequireNonNullablePropertiesSchemaFilter>();
	c.SupportNonNullableReferenceTypes(); // Sets Nullable flags appropriately.

	c.UseOneOfForPolymorphism();
	c.UseAllOfToExtendReferenceSchemas(); // Allows $ref enums to be nullable
	c.UseAllOfForInheritance();

	c.SelectDiscriminatorNameUsing(_ => Constants.DISCRIMINATOR);
	
	c.SelectSubTypesUsing(baseType =>
	{
		if (baseType == typeof(Furniture))
		{
			return new List<Type> { typeof(Bed), typeof(Chair), typeof(Table), typeof(WoodenChair) };
		}
		else if (baseType == typeof(Chair))
		{
			return new List<Type> { typeof(WoodenChair) };
		}

		return new List<Type>();
	});
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{ 
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
