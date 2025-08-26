using Microsoft.AspNetCore.Mvc;
using desafioNubank.Data;

namespace desafioNubank.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClientsController(AppDbContext context)
        {
            _context = context;
        }
    }
}
