﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TarKuz.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Breed> Breed { get; set; }
        public virtual DbSet<Cabinet> Cabinet { get; set; }
        public virtual DbSet<Cheque> Cheque { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Diagnosis> Diagnosis { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Graphic> Graphic { get; set; }
        public virtual DbSet<MedicalCard> MedicalCard { get; set; }
        public virtual DbSet<Pet> Pet { get; set; }
        public virtual DbSet<PetType> PetType { get; set; }
        public virtual DbSet<Reception> Reception { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Specialization> Specialization { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}