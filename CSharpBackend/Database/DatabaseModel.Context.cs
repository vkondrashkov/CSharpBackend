﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSharpBackend.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseEntities : DbContext
    {
        public DatabaseEntities()
            : base("name=DatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<brand> brands { get; set; }
        public virtual DbSet<cart> carts { get; set; }
        public virtual DbSet<device> devices { get; set; }
        public virtual DbSet<news> news { get; set; }
        public virtual DbSet<operating_systems> operating_systems { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<picture> pictures { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
