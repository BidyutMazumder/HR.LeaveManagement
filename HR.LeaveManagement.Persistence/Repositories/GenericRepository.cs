using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Domain.Common;
using HR.LeaveManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseDomainEntity
    {
        protected readonly HrDatabaseContext _hrDatabaseContext;

        public GenericRepository(HrDatabaseContext hrDatabaseContext)
        {
            this._hrDatabaseContext = hrDatabaseContext;
        }
        public async Task<T> CreateAsync(T entity)
        {
            await _hrDatabaseContext.AddAsync(entity);
            await _hrDatabaseContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _hrDatabaseContext.Remove(entity);
            await _hrDatabaseContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAsync()
        {
            return await _hrDatabaseContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return  await _hrDatabaseContext.Set<T>()
                .AsNoTracking()
                .FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _hrDatabaseContext.Entry(entity).State = EntityState.Modified;
            await _hrDatabaseContext.SaveChangesAsync();
            return entity;
        }
    }

}