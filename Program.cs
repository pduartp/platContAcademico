using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TrabConteudoAcademico.Data;
using Microsoft.EntityFrameworkCore;
// TODO - IMPLEMENTAR O CRUD quando persistir a conex�o com o BD
// using TrabConteudoAcademico.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();



builder.Services.AddDbContext<PostagemDbContext>
(options =>{
options.UseSqlite("Data Source=Postagem.db");
});
builder.Services.AddScoped<PostagemServices>();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

//app.MapBlazorHub();
//app.MapFallbackToPage("/_Host");

app.UseEndpoints(endpoints =>
{
    endpoints.MapBlazorHub();
    endpoints.MapFallbackToPage("/_Host");
});

app.Run();



