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
    public class TadcountryPopulationsController : ControllerBase
    {
        private readonly Trivia_App_DatabaseContext _context;

        public TadcountryPopulationsController(Trivia_App_DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/TadcountryPopulations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TadcountryPopulations>>> GetTadcountryPopulations()
        {
            return await _context.TadcountryPopulations.ToListAsync();
        }

        // GET: api/TadcountryPopulations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TadcountryPopulations>> GetTadcountryPopulations(int id)
        {
            var tadcountryPopulations = await _context.TadcountryPopulations.FindAsync(id);

            if (tadcountryPopulations == null)
            {
                return NotFound();
            }

            return tadcountryPopulations;
        }

        private bool TadcountryPopulationsExists(int id)
        {
            return _context.TadcountryPopulations.Any(e => e.Id == id);
        }
    }
}
