using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestApi.Models;
using TestApi.Repositiries;
using System;
namespace TestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CurrencyDefinitionController:ControllerBase
    {
        private IRepository<CurrencyDefinition> CurrencyDefRepository;
        public CurrencyDefinitionController(IRepository<CurrencyDefinition> CurrencyDefRepository)
            { this.CurrencyDefRepository = CurrencyDefRepository;}

        [HttpGet]
        [Route("")]
        public IEnumerable<CurrencyDefinition> GetAllData() => CurrencyDefRepository.GetAll();
    }
}