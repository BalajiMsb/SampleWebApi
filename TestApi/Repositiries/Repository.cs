using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TestApi.Models;
namespace TestApi.Repositiries
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {

        protected readonly PostgreSqlContext context;
        public DbSet<T> currencyDefinition{get; set;}
        public Repository(PostgreSqlContext context)
        {
            this.context = context;
            currencyDefinition = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return currencyDefinition.AsEnumerable();
        }
    }
}