using PolymorphApi.Models;
using PolymorphLib.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddOpenApiDocument();
builder.Services.AddSwaggerGen(c =>
{
	c.UseOneOfForPolymorphism();

	c.SelectSubTypesUsing(baseType =>
	{
		if (baseType == typeof(Furniture))
		{
			return new List<Type> { typeof(Chair), typeof(Table), typeof(WoodenChair) };
		}

		return new List<Type>();
	});
});
builder.Services.AddSwaggerGenNewtonsoftSupport();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	SwaggerBuilderExtensions.UseSwagger(app);
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
