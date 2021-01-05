using Microsoft.AspNetCore.Mvc;
using PizzaApiManager.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApiManager.Controllers
{
    [ApiController]
    [Route("api/pizzas")]
    public class PizzasController : ControllerBase
    {
        private readonly PizzaDataContext context;

        public PizzasController(PizzaDataContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public IEnumerable<Pizza> GetAllPizzas() => context.Pizzas;

        [HttpGet]
        [Route("{id}")]
        public Pizza GetPizzaByID(int id) => context.Pizzas.FirstOrDefault(g => g.ID == id);

        [HttpPost]
        public async Task<Pizza> AddPizza([FromBody] Pizza newPizza)
        {
            context.Add(newPizza);
            await context.SaveChangesAsync();
            return newPizza;
        }

    }
}
