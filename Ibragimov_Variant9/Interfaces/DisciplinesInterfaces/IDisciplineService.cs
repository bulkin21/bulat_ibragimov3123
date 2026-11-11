using Ibragimov_Variant9.Database;
using Ibragimov_Variant9.Filters.DisciplineFilters;
using Microsoft.EntityFrameworkCore;

namespace Ibragimov_Variant9.Interfaces.DisciplinesInterfaces
{
    public interface IDisciplineService
    {
        Task<string[]> GetDisciplinesWithGradeTwoByGroupAsync(
            DisciplineGroupFilter filter,
            CancellationToken cancellationToken = default);
    }

    public class DisciplineService : IDisciplineService
    {
        private readonly StudentDbContext _dbContext;

        public DisciplineService(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string[]> GetDisciplinesWithGradeTwoByGroupAsync(
            DisciplineGroupFilter filter,
            CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(filter.GroupName))
            {
                return Array.Empty<string>();
            }

            var groupName = filter.GroupName.Trim();

            return await _dbContext.Grades
                .Where(grade => grade.Value == 2
                    && grade.Student.Group.Name == groupName)
                .Select(grade => grade.Discipline.Name)
                .Distinct()
                .OrderBy(name => name)
                .ToArrayAsync(cancellationToken);
        }
    }
}
