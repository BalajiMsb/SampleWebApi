using System;
using System.Collections.Generic;
using TestApi.Models;
namespace TestApi.Repositiries
{
    public interface IRepository<T> where T : BaseEntity
    {
         IEnumerable<T> GetAll();
    }
}