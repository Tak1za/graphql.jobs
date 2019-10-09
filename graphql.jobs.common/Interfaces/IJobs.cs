using graphql.jobs.common.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace graphql.jobs.common.Interfaces
{
    public interface IJobs
    {
        public Task<IEnumerable<Job>> GetJobs();
        public Task<City> GetJobsByCity(string citySlug);
    }
}
