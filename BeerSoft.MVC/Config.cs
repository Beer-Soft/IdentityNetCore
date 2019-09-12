using System.Collections.Generic;
using System.Linq;
using IdentityServer4.Models;

namespace BeerSoft.MVC
{
    public static class Config
    {
        public  static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId ="cliente1",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = {
                        new Secret("secreto".Sha256())
                    },
                    AllowedScopes = {"resourceApi1"}
                }
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("resourceApi1","Mi recurso")
            };
        }
    }
}