using System;
using System.Collections.Generic;
using System.Text;

namespace graphql.jobs.common.Queries
{
    public class City
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }

        public IEnumerable<Job> Jobs { get; set; }
    }
}
