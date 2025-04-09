﻿using ApiProjectKampi.WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiProjectKampi.WebApi.Context
{
    public class ApiContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;initial catalog=ApiYummyDb;integrated security=true;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Contact> Contacts  { get; set; }
        public DbSet<Feature> Features  { get; set; }
        public DbSet<Image> Images  { get; set; }
        public DbSet<Message> Messages  { get; set; }
        public DbSet<Product> Products  { get; set; }
        public DbSet<ReservationTable> ReservationTables  { get; set; }
        public DbSet<Service> Services  { get; set; }
        public DbSet<Testimonial> Testimonials  { get; set; }
    }
}
