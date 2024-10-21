using BusinessLogic.LogicServices.Interfaces;
using BusinessLogic.LogicServices.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class Extensions
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection servicesCollection)
        {
            servicesCollection.AddScoped<IUserService, UserService>();
            servicesCollection.AddScoped<IAdminService, AdminService>();
            servicesCollection.AddScoped<IComputerService, ComputerService>();
            servicesCollection.AddScoped<IGroupService, GroupService>();
            servicesCollection.AddScoped<IReservationService, ReservationService>();

            return servicesCollection;
        }
    }
}
