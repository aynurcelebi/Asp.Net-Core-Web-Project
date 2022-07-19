using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Context Class'ı ; Veri Tabanı yapılandırması içerisindeki bağlantı stringini tutan ve
// veri tabanına yansıtılacak olan tabloları tutan class'dır.

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext // Db setlerini dahil ettik.
    {
        // Burada Web confing dosyası olmadığından şöyle bir kod yazarız:

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= DESKTOP-07T8MF2\\MSSQLSERVER01;database=CoreProjeDB; integrated security= true");
        }
        // proporti'ler tanımlanacak ve entity katmanı içerinde bulunan sınıflar çağırılacak;

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
