﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CadEntities : DbContext
    {
        public CadEntities()
            : base("name=CadEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Action> Action { get; set; }
        public virtual DbSet<Audit> Audit { get; set; }
        public virtual DbSet<Script> Script { get; set; }
        public virtual DbSet<Preference> Preference { get; set; }
        public virtual DbSet<Execution> Execution { get; set; }
        public virtual DbSet<ExecutionPlane> ExecutionPlane { get; set; }
    }
}
