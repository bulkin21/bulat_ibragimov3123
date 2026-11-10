using Ibragimov_Variant9.Filters.StudentFilters;
using Ibragimov_Variant9.Interfaces.StudentsInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ibragimov_Variant9.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly ILogger<StudentsController> _logger;
        private readonly IStudentService _studentService;

        public StudentsController(
            ILogger<StudentsController> logger,
            IStudentService studentService)
        {
            _logger = logger;
            _studentService = studentService;
        }

        /// <summary>Получить студентов с фильтрацией по названию группы</summary>
        [HttpPost("filter")]
        public async Task<IActionResult> GetStudentsByFilterAsync(
            StudentFilter filter,
            CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Method GetStudentsByFilter was called");

            var students = await _studentService.GetStudentsByFilterAsync(
                filter,
                cancellationToken);

            return Ok(students);
        }
    }
}
