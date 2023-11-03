using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.StaticFiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// (Add any services you need here, like MVC, Razor Pages, etc.)
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

// Custom Middleware to set Cross-Origin Isolation headers
app.Use(async (context, next) =>
{
    context.Response.Headers.Add("Cross-Origin-Opener-Policy", "same-origin");
    context.Response.Headers.Add("Cross-Origin-Embedder-Policy", "require-corp");
    context.Response.Headers.Add("X-Content-Type-Options", "nosniff");
    await next();
});


// Configure MIME type mapping for JavaScript files
var contentTypeProvider = new FileExtensionContentTypeProvider();
// contentTypeProvider.Mappings[".js"] = "application/javascript"; // Set the MIME type for .js files
if (!contentTypeProvider.Mappings.ContainsKey(".pck"))
{
    contentTypeProvider.Mappings[".pck"] = "application/octet-stream";
}


app.UseDefaultFiles(new DefaultFilesOptions
{
    DefaultFileNames = new List<string> { "index.html" } // Godot project's main HTML file
});


app.UseStaticFiles(new StaticFileOptions
{
    ContentTypeProvider = contentTypeProvider
});



app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
