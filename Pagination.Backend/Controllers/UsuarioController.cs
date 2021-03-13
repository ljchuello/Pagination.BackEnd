using Microsoft.AspNetCore.Mvc;

namespace Pagination.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public Paginacion PagIn([FromBody]Paginacion q)
        {
            Paginacion paginacionOut = new Paginacion();
            return paginacionOut;
        }
    }
}
