using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using graphql.jobs.common.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace graphql.jobs.api.Controllers
{
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IJobs _jobs;

        public JobsController(IJobs jobs)
        {
            _jobs = jobs;
        }

        [HttpGet]
        [Produces("application/json")]
        [Route("/api/jobs")]
        public async Task<ActionResult> GetAllJobs()
        {
            var response = await _jobs.GetJobs();
            return Ok(response);
        }

        [HttpGet]
        [Produces("application/json")]
        [Route("/api/jobs/search")]
        public async Task<ActionResult> GetJobsByCity([FromQuery]string city)
        {
            var response = await _jobs.GetJobsByCity(city);
            return Ok(response);
        }
    }
}