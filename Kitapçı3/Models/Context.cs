using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitapçı3.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-AFO43PH; database=kitapliste; integrated security=true;");
        }

        public DbSet<Kitap> kitaps { get; set; }
        public DbSet<Bilim> bilims { get; set; }
        public DbSet<Felsefe> felseves { get; set; }
        public DbSet<Psikoloji> psikolojis { get; set; }
        public DbSet<Roman> romen { get; set; }
        public DbSet<YeniKitap> YeniKitaps { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Üye> üyes { get; set; }
        public DbSet<YeniÇıkanKitap> yeniÇıkanKitaps { get; set; }
    }
}
