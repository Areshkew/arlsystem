var builder = WebApplication.CreateBuilder();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    // Header: Strict-Transport-Security: Ensure HTTPS always.
    app.UseHsts();
}

app.UseHttpsRedirection(); // middleware for redirect http to https
app.UseStaticFiles(); // Folder for static files(js, html, css), default: wwwroot

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
