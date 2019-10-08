using graphql.jobs.common.Interfaces;
using GraphQL.Client.Http;
using GraphQL.Common.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace graphql.jobs.common.Queries
{
    public class JobQueries : IJobs
    {
        private readonly GraphQLHttpClient _client;

        public JobQueries(GraphQLHttpClient client)
        {
            _client = client;
        }
        public async Task<IEnumerable<Job>> GetJobs()
        {
            var query = new GraphQLRequest
            {
                Query = @"
                    query getJobs{
                        jobs{
                            id
                            title
                            commitment{
                                title
                            }
                            cities{
                                name
                                country{
                                    name
                                }
                            }
                            description
                            company{
                                name
                            }
                            applyUrl
                            locationNames
                            postedAt
                            updatedAt
                        }
                    }
                "
            };

            var response = await _client.SendQueryAsync(query);
            var data = response.GetDataFieldAs<IEnumerable<Job>>("jobs");
            return data;
        }
    }
}
