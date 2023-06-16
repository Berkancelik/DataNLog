using Contracts;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DataNLog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataTestController : ControllerBase
    {
        private List<Project> _projectList;
        private ILoggerManager _logger;



        public DataTestController(ILoggerManager logger)
        {
            _logger = logger; ;
            _projectList = new List<Project>
            {
                new Project{Id = Guid.NewGuid(), Name = "Project 1"},
                new Project{Id = Guid.NewGuid(), Name = "Project 2"},
                new Project{Id = Guid.NewGuid(), Name = "Project 3"},
            };       

        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                _logger.LogInfo("Projects.Get() has been run.");
                return Ok(_projectList);
            }
            catch (Exception ex)
            {

                _logger.LogInfo("Projects.Get() has been crashed." + ex.Message);
                throw;
            }
        }
    }
}
