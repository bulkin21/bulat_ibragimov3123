using Ibragimov_Variant9.Filters.DisciplineFilters;
using Ibragimov_Variant9.Interfaces.DisciplinesInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ibragimov_Variant9.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DisciplinesController : ControllerBase
    {
        private readonly ILogger<DisciplinesController> _logger;
        private readonly IDisciplineService _disciplineService;

        public DisciplinesController(
            ILogger<DisciplinesController> logger,
            IDisciplineService disciplineService)
        {
            _logger = logger;
            _disciplineService = disciplineService;
        }

        /// <summary>
        /// Получить без повторов список дисциплин, по которым у студентов группы есть оценки 2
        /// </summary>
        [HttpPost("filter")]
        public async Task<ActionResult<string[]>> GetDisciplinesWithGradeTwoByGroupAsync(
            DisciplineGroupFilter filter,
            CancellationToken cancellationToken = default)
        {
            _logger.LogInformation(
                "Method GetDisciplinesWithGradeTwoByGroup was called");

            var disciplines = await _disciplineService
                .GetDisciplinesWithGradeTwoByGroupAsync(filter, cancellationToken);

            return Ok(disciplines);
        }
    }
}
