﻿using DataAccess.DataRepositories.Interface;
using DataAccess.DataRepositories.Interfaces;
using DataAccess.DataRepositories.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class Extensions
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection servicesCollection)
        {
            servicesCollection.AddScoped<IUserRepository, UserRepository>();
            servicesCollection.AddScoped<IAdminRepository, AdminRepository>();
            servicesCollection.AddScoped<IComputerRepository, ComputerRepository>();
            servicesCollection.AddScoped<IGroupRepository, GroupRepository>();
            servicesCollection.AddScoped<IReservationRepository, ReservationRepository>();

            servicesCollection.AddDbContext<ApplicationDbContext>(x =>
            {
                x.UseNpgsql("Host=localhost; Database=ComputerClub; Username=vadim; Password=1707");
            });

            return servicesCollection;
        }
    }
}
