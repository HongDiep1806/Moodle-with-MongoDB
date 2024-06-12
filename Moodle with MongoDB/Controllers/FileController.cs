using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moodle_with_MongoDB.Repository;

namespace Moodle_with_MongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IFileRepository _fileRepository;
        public FileController(IFileRepository fileRepository)
        {
            _fileRepository = fileRepository;
        }

        [HttpPut]
        public IActionResult InsertStudentsFromFile()
        {
            _fileRepository.ImportStudentsFromFile();
            return Ok();
        }
    }
}
