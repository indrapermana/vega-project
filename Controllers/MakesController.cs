using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Models;
using vega.Persistence;

namespace vega.Controllers
{
    public class MakesController : Controller
    {
        private readonly VegaDBContext context;
        public MakesController(VegaDBContext context)
        {
            this.context = context;

        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            return await context.Makes.Include(m => m.Models).ToListAsync();
        }
    }
}