using System;
using System.Collections.Generic;
using System.Text;

namespace graphql.jobs.common.Queries
{
    public class City
    {
        public string Name { get; set; }
        public Country Country { get; set; }
    }
}
