using AssAPI.AppDbContext;
using AssAPI.IRepositories.IRepository;
using AssAPI.IRepositories.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContexts>(
    option =>
    {
        option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnect"));
    });
builder.Services.AddTransient<IHoaDonChiTietRepository, HoaDonChiTietRepository>();
builder.Services.AddTransient<IHoaDonRepository, HoaDonRepository>();
builder.Services.AddTransient<IKhachHangRepository, KhachHangRepository>();
builder.Services.AddTransient<INhanVienRepository, NhanVienRepository>();
builder.Services.AddTransient<IRoleRepository, RoleRepository>();
builder.Services.AddTransient<ISanPhamRepository, SanPhamRepository>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
