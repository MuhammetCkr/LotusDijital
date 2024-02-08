using LotusDijital.Business.Abstract;
using LotusDijital.Business.Concrete;
using LotusDijital.Data.Abstract;
using LotusDijital.Data.Concrete.EfCore.Context;
using LotusDijital.Data.Concrete.EfCore.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<LotusDijitalDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
//builder.Services.AddScoped<IColorService, ColorManager>();
builder.Services.AddScoped<IDocumentGalleryService, DocumentGalleryManager>();
builder.Services.AddScoped<IImageGalleryService, ImageGalleryManager>();
builder.Services.AddScoped<IInnerPageService, InnerPageManager>();
builder.Services.AddScoped<IPageService, PageManager>();
builder.Services.AddScoped<IVideoGalleryService, VideoGalleryManager>();
builder.Services.AddScoped<IImageService, ImageManager>();

builder.Services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();
builder.Services.AddScoped<IProductRepository, EfCoreProductRepository>();
//builder.Services.AddScoped<IColorRepository, EfCoreColorRepository>();
builder.Services.AddScoped<IDocumentGalleryRepository, EfCoreDocumentGalleryRepository>();
builder.Services.AddScoped<IImageGalleryReposiyory, EfCoreImageGalleryRepository>();
builder.Services.AddScoped<IInnerPageRepository, EfCoreInnerPageRepository>();
builder.Services.AddScoped<IPageRepository, EfCorePageRepository>();
builder.Services.AddScoped<IVideoGalleryRepository, EfCoreVideoGalleryRepository>();
builder.Services.AddScoped<IImageRespository, EfCoreImageRespository>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
