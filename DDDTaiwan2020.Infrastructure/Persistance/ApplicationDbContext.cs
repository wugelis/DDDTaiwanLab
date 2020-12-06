using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DDDTaiwan2020.Domain.Entities;
using DDDTaiwan2020.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DDDTaiwan2020.Infrastructure.Persistance
{
    public partial class ApplicationDbContext : DbContext , IApplicationDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
		
		public virtual DbSet<CustomerDetailEnt> CustomerDetail { get; set; }

		
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=(local)\\MSSQLSERVER2017;Database=Northwind;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public Task<int> SaveChangesAsync(bool cancellationToken)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}


