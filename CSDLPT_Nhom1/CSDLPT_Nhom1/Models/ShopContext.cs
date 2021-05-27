using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLPT_Nhom1.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext(string connectionString) : base(connectionString)
        {

        }
        public ShopContext()
        {

        }
        public DbSet<LoaiSanPhamCha> LoaiSanPhamChas { get; set; }
        public DbSet<ChiNhanh> ChiNhanhs { get; set; }
        public DbSet<ChiTietSanPham> ChiTietSanPhams { get; set; }
        public DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Conventions
                .Remove
                <PluralizingTableNameConvention>();

            modelBuilder.Entity<SanPham>()
                .HasRequired(x => x.LoaiSanPham)
                .WithMany()
                .HasForeignKey(x => x.MaLSP)
                .WillCascadeOnDelete(true);
        }
    }
}
