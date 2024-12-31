using Microsoft.EntityFrameworkCore;

namespace OkulEFAppProject
{
    public class OgrenciModel : DbContext
    {
        public DbSet<Ogrenci> tblOgrenciler { get; set; }
        public DbSet<Sinif> tblSiniflar { get; set; }
        public DbSet<Ders> tblDersler { get; set; }
        public DbSet<OgrenciDers> tblOgrenciDers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=OkulProject;Integrated Security=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Öğrenci
            modelBuilder.Entity<Ogrenci>()
                .Property(o => o.Ad).HasMaxLength(20).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ogrenci>()
                .Property(o => o.Soyad).HasMaxLength(20).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ogrenci>()
                .Property(o => o.Numara).HasMaxLength(20).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ogrenci>().HasIndex(o => o.Numara).IsUnique();
            modelBuilder.Entity<Ogrenci>()
                .HasOne(o => o.Sinif)
                .WithMany(s => s.Ogrenciler)
                .HasForeignKey(o => o.SinifId);

            // Sınıf
            modelBuilder.Entity<Sinif>()
                .Property(d => d.SinifAd).HasMaxLength(20).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Sinif>().HasIndex(s => s.SinifAd).IsUnique();

            // Ders
            modelBuilder.Entity<Ders>()
                .Property(d => d.DersAd).HasMaxLength(20).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ders>()
                .Property(d => d.DersKod).HasMaxLength(10).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ders>().HasIndex(d => d.DersKod).IsUnique();

            // OgrenciDers
            modelBuilder.Entity<OgrenciDers>()
                .HasOne(od => od.Ogrenci)
                .WithMany(o => o.OgrenciDers)
                .HasForeignKey(od => od.OgrenciId);

            modelBuilder.Entity<OgrenciDers>()
                .HasOne(od => od.Ders)
                .WithMany(d => d.OgrenciDers)
                .HasForeignKey(od => od.DersId);
        }
    }

    public class Ogrenci
    {
        public int OgrenciId { get; set; }
        public string Numara { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int SinifId { get; set; }
        public Sinif Sinif { get; set; }
        public ICollection<OgrenciDers> OgrenciDers { get; set; } = new List<OgrenciDers>();
    }

    public class Sinif
    {
        public int SinifId { get; set; }
        public string SinifAd { get; set; }
        public int Kontenjan { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; } = new List<Ogrenci>();
    }

    public class Ders
    {
        public int DersId { get; set; }
        public string DersKod { get; set; }
        public string DersAd { get; set; }
        public ICollection<OgrenciDers> OgrenciDers { get; set; } = new List<OgrenciDers>();
    }

    public class OgrenciDers
    {
        public int Id { get; set; }
        public int DersId { get; set; }
        public int OgrenciId { get; set; }
        public Ders Ders { get; set; }
        public Ogrenci Ogrenci { get; set; }
    }
}
