using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Controllers.Resources;
using vega.Models;
using vega.Persistence;

namespace vega.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        private VegaDbContext dbContext;
        private readonly IMapper mapper;

        public MakesController(VegaDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await dbContext.Makes.Include(m => m.Models).ToListAsync();
            var makesResource = new List<MakeResource>();
            foreach (var item in makes)
            {
                makesResource.Add(new MakeResource(item));
            }
            return makesResource;
            Console.WriteLine("a", "a");
        }
        [HttpGet("/api/features")]
        public async Task<IEnumerable<Features>> GetFeatures()
        {
            var features = await dbContext.Features.ToListAsync();
            return features; ;
        }
    }
}