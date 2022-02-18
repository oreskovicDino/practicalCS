namespace PocketBook.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using PocketBook.Core.IConfiguration;
    using PocketBook.Models;
    using System;
    using System.Threading.Tasks;

    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> logger;
        private readonly IUnitOfWork unitOfWork;

        public UsersController(ILogger<UsersController> logger, IUnitOfWork unitOfWork)
        {
            this.logger = logger;
            this.unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            if (ModelState.IsValid)
            {
                user.Id = Guid.NewGuid();

                await unitOfWork.Users.Add(user);
                await unitOfWork.CompleateAsync();

                return CreatedAtAction("GetItem", new { user.Id }, user);
            }

            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(Guid id)
        {
            var ussr = await unitOfWork.Users.GetById(id);

            if (ussr is null)
            {
                return NotFound();// 404 http status code.
            }

            return Ok(User);
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> UpdateItem(Guid id, User user)
        {
            if (!ModelState.IsValid || user.Id != id)
            {
                return BadRequest();
            }

            await unitOfWork.Users.Upsert(user);
            await unitOfWork.CompleateAsync();
            return NoContent();
        }
        
    }
}