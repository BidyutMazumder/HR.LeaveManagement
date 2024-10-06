using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistence.DatabaseContext
{
    public class HrDatabaseContext : DbContext
    {
        public HrDatabaseContext(DbContextOptions<HrDatabaseContext> options) : base(options)
        {
        }

        public DbSet<LeaveType> leaveTypes { get; set;}
        public DbSet<LeaveAllocation> leaveAllocation { get; set;}  
        public DbSet<LeaveRequest> leaveRequests { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HrDatabaseContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            
            foreach(var entity in base.ChangeTracker.Entries<BaseDomainEntity>()
                .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
            {
                entity.Entity.DatetModified = DateTime.Now;
                if (entity.State == EntityState.Added)
                {
                    entity.Entity.DateCreated = DateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }


    }
}
