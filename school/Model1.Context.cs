﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace school
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class schoolEntities : DbContext
    {
        public schoolEntities()
            : base("name=schoolEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<activities> activities { get; set; }
        public virtual DbSet<admin> admin { get; set; }
        public virtual DbSet<aspnet_Applications> aspnet_Applications { get; set; }
        public virtual DbSet<aspnet_Membership> aspnet_Membership { get; set; }
        public virtual DbSet<aspnet_Paths> aspnet_Paths { get; set; }
        public virtual DbSet<aspnet_PersonalizationAllUsers> aspnet_PersonalizationAllUsers { get; set; }
        public virtual DbSet<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }
        public virtual DbSet<aspnet_Profile> aspnet_Profile { get; set; }
        public virtual DbSet<aspnet_Roles> aspnet_Roles { get; set; }
        public virtual DbSet<aspnet_SchemaVersions> aspnet_SchemaVersions { get; set; }
        public virtual DbSet<aspnet_Users> aspnet_Users { get; set; }
        public virtual DbSet<aspnet_WebEvent_Events> aspnet_WebEvent_Events { get; set; }
        public virtual DbSet<attendence> attendence { get; set; }
        public virtual DbSet<attendtype> attendtype { get; set; }
        public virtual DbSet<course> course { get; set; }
        public virtual DbSet<EV> EV { get; set; }
        public virtual DbSet<grades> grades { get; set; }
        public virtual DbSet<gradetype> gradetype { get; set; }
        public virtual DbSet<homecourse> homecourse { get; set; }
        public virtual DbSet<homework> homework { get; set; }
        public virtual DbSet<parent> parent { get; set; }
        public virtual DbSet<parentcity> parentcity { get; set; }
        public virtual DbSet<reports> reports { get; set; }
        public virtual DbSet<schedule> schedule { get; set; }
        public virtual DbSet<scheduletype> scheduletype { get; set; }
        public virtual DbSet<SchoolGender> SchoolGender { get; set; }
        public virtual DbSet<schools> schools { get; set; }
        public virtual DbSet<Schoolsemester> Schoolsemester { get; set; }
        public virtual DbSet<student> student { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
