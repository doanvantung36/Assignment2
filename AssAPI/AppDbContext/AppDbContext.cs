using AssAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace AssAPI.AppDbContext
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-7HORMRAF\\SQLEXPRESS01;Initial Catalog=AppAss;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True");
        }
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<User> Users { get; set;}
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set;}
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
    }
}
