﻿using RealEstateApp.Core.Application.Interfaces.Repositories;
using RealEstateApp.Core.Domain.Entities;
using RealEstateApp.Infrastructure.Persistence.Contexts;
using RealEstateApp.Infrastructure.Persistence.Repository;

namespace RealEstateApp.Infrastructure.Persistence.Repositories
{
    public class TypeOfSalesRepository : GenericRepository<TypeOfSales>, ITypeOfSalesRepository
    {
        private readonly ApplicationContext _dbContext;

        public TypeOfSalesRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}