﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App_Banco
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AppBancoDBEntities1 : DbContext
    {
        public AppBancoDBEntities1()
            : base("name=AppBancoDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CLIENTES> CLIENTES { get; set; }
        public DbSet<CUENTAS> CUENTAS { get; set; }
        public DbSet<MOVIMIENTOS> MOVIMIENTOS { get; set; }
        public DbSet<PARAMETROS> PARAMETROS { get; set; }
        public DbSet<TIPO_MOV> TIPO_MOV { get; set; }
        public DbSet<USUARIOS> USUARIOS { get; set; }
    }
}