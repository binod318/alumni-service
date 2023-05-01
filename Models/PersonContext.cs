using System;
using Microsoft.EntityFrameworkCore;

namespace Api.Models;

public class PersonContext : DbContext
{
    public PersonContext(DbContextOptions<PersonContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ////base.OnModelCreating(modelBuilder);
        //modelBuilder.Entity<Person>()
        //    .HasOne(a => a.Address) // A person has one Address
        //    .WithOne(p => p.Person) // An address belongs to one category
        //    .HasForeignKey(a => a.);
    }

    public DbSet<Person> Person { get; set; }
    public DbSet<Address> Address { get; set; }

}



