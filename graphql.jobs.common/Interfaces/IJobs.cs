using System.Threading.Tasks;

namespace graphql.jobs.common.Interfaces
{
    public interface IJobs
    {
        public Task<Job> GetJobs(); 
    }
}
