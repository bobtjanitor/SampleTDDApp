﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleApplication.Repository
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class adventureworksEntities : DbContext
    {
        public adventureworksEntities()
            : base("name=adventureworksEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Employee> Employees { get; set; }
        public DbSet<vEmployee> vEmployees { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<BusinessEntity> BusinessEntities { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<BusinessEntityAddress> BusinessEntityAddresses { get; set; }
    }
}
