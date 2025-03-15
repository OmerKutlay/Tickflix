using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickflix.Repository.Shared.Abstract;
using Tickflix.Repository.Shared.Concrete;

namespace Tickflix.Repository.Configuration
{
    public static class BusinessExtension
    {

        public static void RepositoryDI(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
