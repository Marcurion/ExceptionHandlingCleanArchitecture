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
            _service.ChangeSomeData();

            return Ok();
        }
    }
}
