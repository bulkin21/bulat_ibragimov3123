using Ibragimov_Variant9.Database;
using Ibragimov_Variant9.Filters.StudentFilters;
using Ibragimov_Variant9.Models;
using Microsoft.EntityFrameworkCore;

namespace Ibragimov_Variant9.Interfaces.StudentsInterfaces
{
    public interface IStudentService
    {
        Task<Student[]> GetStudentsByFilterAsync(
            StudentFilter filter,
            CancellationToken cancellationToken = default);
    }

    public class StudentService : IStudentService
    {
        private readonly StudentDbContext _dbContext;

        public StudentService(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Student[]> GetStudentsByFilterAsync(
            StudentFilter filter,
            CancellationToken cancellationToken = default)
        {
            var query = _dbContext.Students
                .Include(student => student.Group)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter.GroupName))
            {
                query = query.Where(student => student.Group.Name == filter.GroupName);
            }

            return await query
                .OrderBy(student => student.LastName)
                .ThenBy(student => student.FirstName)
                .ToArrayAsync(cancellationToken);
        }
    }
}
