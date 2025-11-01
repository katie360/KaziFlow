using KaziFlowApi.Data;
using KaziFlowApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KaziFlowApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext db;

        public UsersController(AppDbContext context)
        {
            db = context;
        }

        [HttpPost(Name = "CreateUser")]
        public async Task<ActionResult<User>> Post(User user)
        {
            user.CreatedAt = DateTime.UtcNow;
            user.IsActive = true;

            await db.Users.AddAsync(user);
            await db.SaveChangesAsync();

            return CreatedAtAction(nameof(Post), new { id = user.Id }, user);
        }

    }
}
