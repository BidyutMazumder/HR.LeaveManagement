using HR.LeaveManagement.Application.Persistence.Contracts;
using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Persistence.DatabaseContext;

namespace HR.LeaveManagement.Persistence.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        public LeaveRequestRepository(HrDatabaseContext hrDatabaseContext) : base(hrDatabaseContext)
        {
        }

        public Task<List<LeaveRequest>> GetLeaveRequestsWithDetails()
        {
            throw new NotImplementedException();
        }

        public Task<List<LeaveRequest>> GetLeaveRequestsWithDetails(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<LeaveRequest> GetLeaveRequestWithDetails(int id)
        {
            throw new NotImplementedException();
        }
    }
}
