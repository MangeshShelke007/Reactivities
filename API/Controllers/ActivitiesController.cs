using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;

        public ActivitiesController(DataContext context) {
            _context = context;
        }


        [HttpGet]// api/Activities
        public async Task<ActionResult<List<Activity>>> GetActivity()
        {
            return await _context.Activities.ToListAsync();
        }


        [HttpGet("{id}")] // api/Activities/jiijo
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }
       

    }
}
