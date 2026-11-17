using Api_net_9.Context;
using Microsoft.AspNetCore.Mvc;

namespace Api_net_9.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Produces("application/json")] 
    public class ProdutosController : Controller
    {
        private readonly AppDbContext _context;

        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Models.Produto>> Get()
        {
            var produtos = _context.Produtos.ToList();
            if (produtos is null)
            {
                return NotFound("local não encontrado");
            }
            return produtos;
        }
    }
}