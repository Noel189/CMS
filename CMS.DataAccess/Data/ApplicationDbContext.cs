using CMS.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DataAccess.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Members> Membertbl { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Members>().HasData(

                new Members
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Bob",
                    Address = "466 dummy address",
                    Email = "dummy@gmail.com",
                    Phone = "555-888-666",
                    MemberSince="11/05/2024"

                },
                      new Members
                      {
                          Id = 2,
                          FirstName = "James",
                          LastName = "Rob",
                          Address = "466 dummy address",
                          Email = "dummy2@gmail.com",
                          Phone = "555-888-888",
                          MemberSince = "11/05/2024"

                      },
                            new Members
                            {
                                Id = 3,
                                FirstName = "Jacob",
                                LastName = "Job",
                                Address = "466 dummy address",
                                Email = "dummy3@gmail.com",
                                Phone = "555-888-777",
                                MemberSince = "11/05/2024"

                            });
        }
    }
}
