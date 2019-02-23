using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TriviaWebService.Models;

namespace TriviaWebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TadcityweathersController : ControllerBase
    {
        private readonly Trivia_App_DatabaseContext _context;

        public TadcityweathersController(Trivia_App_DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Tadcityweathers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tadcityweathers>>> GetTadcityweathers()
        {
            return await _context.Tadcityweathers.ToListAsync();
        }

        // GET: api/Tadcityweathers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tadcityweathers>> GetTadcityweathers(int id)
        {
            var tadcityweathers = await _context.Tadcityweathers.FindAsync(id);

            if (tadcityweathers == null)
            {
                return NotFound();
            }

            return tadcityweathers;
        }

        private bool TadcityweathersExists(int id)
        {
            return _context.Tadcityweathers.Any(e => e.Id == id);
        }
    }
}
