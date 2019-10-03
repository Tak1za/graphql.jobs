using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using graphql.jobs.common.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace graphql.jobs.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IJobs _jobs;

        public JobsController(IJobs jobs)
        {
            _jobs = jobs;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllJobs()
        {
            var response = await _jobs.GetJobs();
            return Ok(response);
        } 
    }
}