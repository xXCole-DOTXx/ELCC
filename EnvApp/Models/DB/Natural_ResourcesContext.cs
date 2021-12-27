using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EnvApp.Models.DB
{
    public partial class Natural_ResourcesContext : DbContext
    {
        public Natural_ResourcesContext()
        {
        }

        public Natural_ResourcesContext(DbContextOptions<Natural_ResourcesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NR_User> NR_Users { get; set; }
        public virtual DbSet<Project_Screen> Project_Screen { get; set; }
        public virtual DbSet<TypeOne> TypeOne { get; set; }
        public virtual DbSet<TypeTwo> TypeTwo { get; set; }
    } 
}
