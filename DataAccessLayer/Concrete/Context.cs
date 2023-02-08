using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-E8FO8AIP\\SQLEXPRESS;database=RentaBikeDb;integrated security=true;");
        }
        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ReserveBikeMessage> ReserveBikeMessages { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<MessageContact> MessageContacts { get; set; }
        public DbSet<Login> Logins { get; set; }

    }
}
