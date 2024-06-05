using AssAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace AssAPI.AppDbContext
{
    public class AppDbContexts : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HHUNGDZ\\SQLEXPRESS;Initial Catalog=AppAssmt;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
        public AppDbContexts()
        {

        }
        public AppDbContexts(DbContextOptions options) : base(options)
        {
        }

        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<User> Users { get; set;}
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set;}
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HoaDonChiTiet>()
                .HasKey(h => new { h.MaHoaDon, h.MaSanPham });

            modelBuilder.Entity<HoaDonChiTiet>()
                .HasOne(h => h.HoaDon)
                .WithMany(hd => hd.HoaDonChiTiet)
                .HasForeignKey(h => h.MaHoaDon);

            modelBuilder.Entity<HoaDonChiTiet>()
                .HasOne(h => h.SanPham)
                .WithMany(sp => sp.HoaDonChiTiet)
                .HasForeignKey(h => h.MaSanPham);
        }
    }
}
