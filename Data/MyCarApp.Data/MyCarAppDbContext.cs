using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyCarApp.Data.Models;

namespace MyCarApp.Data
{
    public class MyCarAppDbContext : ApiAuthorizationDbContext<User>
    {
        public MyCarAppDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {

        }
    }
}