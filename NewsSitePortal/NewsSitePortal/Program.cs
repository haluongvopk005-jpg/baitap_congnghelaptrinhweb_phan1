var builder = WebApplication.CreateBuilder(args);

// Thêm dịch vụ Razor Pages vào container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Cấu hình HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
