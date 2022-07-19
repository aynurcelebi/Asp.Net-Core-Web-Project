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
    }
}
