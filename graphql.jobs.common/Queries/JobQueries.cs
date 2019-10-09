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

        public async Task<City> GetJobsByCity(string citySlug)
        {
            var cityQuery = new
            {
                slug = citySlug
            };
            var query = new GraphQLRequest
            {
                Query = @"
                    query getJobsByCity($cityQuery: LocationInput!){
                        city(input: $cityQuery){
                            id
                            name
                            country{
                                name
                            }
                            jobs{
                                id
                                title
                                commitment{
                                    title
                                }
                                description
                                company{
                                    name
                                }
                                applyUrl
                                postedAt
                                updatedAt
                            }
                        }
                    }
                ",
                Variables = new
                {
                    cityQuery = cityQuery
                },
            };

            try
            {
                
                
                var response = await _client.SendQueryAsync(query);
                var data = response.GetDataFieldAs<City>("city");
                return data;
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }
    }
}
