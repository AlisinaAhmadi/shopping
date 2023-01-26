using Microsoft.AspNetCore.Mvc;
using RestShopping.Managers;
using shoppinglist;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestShopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class shoppingsController : ControllerBase
    {
        private readonly shoppingsMangercs _manager = new shoppingsMangercs();

        // GET: api/<BooksController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        
        [HttpGet]
        public ActionResult <IEnumerable<shopping>>Get()
        {
            IEnumerable<shopping> list = _manager.GetAll();
            if (list == null || list.Count() == 0)
            {
                return NoContent();
            }
            else
            {
                return Ok(list);
            }
        }
        // GET api/<BooksController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        
      
        // POST api/<BooksController>
        [HttpPost]
        public ActionResult < shopping >Post([FromBody] shopping value)
        {
            IEnumerable<shopping> list = _manager.GetAll();
            if (list == null || list.Count() == 0)
            {
                return NoContent();
            }
            else
            {
                return Ok(list);
            }
        }

        // DELETE api/<BooksController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        
        [HttpDelete("{id}")]
        public ActionResult <shopping> Delete(int id)
        {
            shopping deletedshopping = _manager.Delete(id);
            if (deletedshopping == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(deletedshopping);
            }
        }

    }
}
