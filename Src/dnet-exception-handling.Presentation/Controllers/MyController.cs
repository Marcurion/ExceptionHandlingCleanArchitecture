using dnet_exception_handling.Application;
using Microsoft.AspNetCore.Mvc;

namespace dnet_exception_handling.Presentation.Controllers
{
    public class MyController : Controller
    {

        MyService _service;

        public MyController(MyService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntry(int id)
        {
            try
            {
                _service.ChangeSomeData();
            }
            catch (Exception e)
            {
                // Important we split the flow of information here,
                // the stack trace goes to console or logs for developers to read
                // and the exception is re-contextualized for the webapi into a http response code,
                // you do not want to expose your stack trace to the user!
                Console.WriteLine(e);
                return StatusCode(500); // 500 - Internal Server Error, we do not know what exactly went wrong as we react to any exception
            }


            return Ok();
        }
    }
}
