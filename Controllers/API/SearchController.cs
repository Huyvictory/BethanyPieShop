using BethanyPieShop.Models;
using BethanyPieShop.Repository;
using BethanyPieShop.Controllers.API.Payload;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BethanyPieShop.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IPieRepository _pieRepository;

        public SearchController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        [HttpGet]
        public IActionResult GetAllPies()
        {
            var allPies = _pieRepository.AllPies;
            return Ok(allPies);
        }

        [HttpGet("{id}")]
        public IActionResult GetPieById(int id)
        {
            var pieFound = _pieRepository.AllPies.Where(p => p.PieId == id).FirstOrDefault();
            if (pieFound == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(pieFound);
            }
        }

        [HttpPost]
        public IActionResult SearchPiesByName([FromBody] SearchPieName pieSearchTerm)
        {
            IEnumerable<Pie> listPiesFound_ByName;

            if (!string.IsNullOrEmpty(pieSearchTerm.pieName))
            {
                listPiesFound_ByName = _pieRepository.SearchPiesByName(pieSearchTerm.pieName);

                if (listPiesFound_ByName.Count() == 0)
                {
                    return NotFound();
                }
                else
                {
                    return new JsonResult(listPiesFound_ByName);
                }
            }

            return BadRequest();
        }
    }
}
