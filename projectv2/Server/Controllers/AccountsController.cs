using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projectv2.Server.Controllers.Data;
using projectv2.Shared.Models;

namespace projectv2.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly Context _context;

        public AccountsController(Context context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Accounts>> PostAccount(Accounts account)
        {
            _context.accounts.Add(account);
            await _context.SaveChangesAsync();

            return Ok(account);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Accounts>>> Get()
        {
            if (_context.accounts == null)
            {
                return NotFound();
            }
            return Ok(await _context.accounts.ToListAsync());
        }
    }
}
