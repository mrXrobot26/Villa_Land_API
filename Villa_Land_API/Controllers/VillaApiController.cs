using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VillaLand.Models;
using VillaLand.Models.DTO;

namespace Villa_Land_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaApiController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return new List<VillaDTO>{
                new VillaDTO { Id =1, Name ="bool view"},
                new VillaDTO { Id =2,Name="Beach View"}
            };

        }
    }
}
