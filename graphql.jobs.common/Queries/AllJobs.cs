using System;
using System.Collections.Generic;
using System.Text;

namespace graphql.jobs.common.Queries
{
    public class AllJobs
    {
        public IEnumerable<Job> Jobs { get; set; }
    }
}
