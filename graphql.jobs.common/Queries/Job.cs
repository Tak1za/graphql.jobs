using System;
using System.Collections.Generic;
using System.Text;

namespace graphql.jobs.common.Queries
{
    public class Job
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public Commitment Commitment { get; set; }
        public IEnumerable<City> Cities { get; set; }
        public string Description { get; set; }
        public Company Company { get; set; }
        public string ApplyUrl { get; set; }
        public string LocationNames { get; set; }
        public DateTime postedAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
