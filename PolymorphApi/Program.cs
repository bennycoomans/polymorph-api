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
			return new List<Type> { typeof(Chair), typeof(WoodenChair) };
		}

		return new List<Type>();
	});
});
builder.Services.AddSwaggerGenNewtonsoftSupport();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	// app.UseOpenApi();
	SwaggerBuilderExtensions.UseSwagger(app);
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
