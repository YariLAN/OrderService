using Microsoft.AspNetCore.Mvc;
using OrderService.Business.Interfaces;
using OrderService.Models.Dto.Requests;
using OrderService.Models.Dto.Responses;

namespace OrderService.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return RedirectToAction("GetAsync", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(
            [FromServices] IGetOrdersCommand command,
            CancellationToken ct)
        {
            var orders = await command.ExecuteAsync(ct);

            return View(orders);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromServices] ICreateOrderCommand command,
            OrderRequest request,
            CancellationToken ct)
        {
            var orderId = await command.ExecuteAsync(request, ct);

            return RedirectToAction(nameof(Index), "Home");
        }

        [HttpGet("GetAsync/{id}")]
        public async Task<IActionResult> GetAsync(
            [FromServices] IGetOrderCommand command,
            [FromRoute] int id,
            CancellationToken ct)
        {
            var order = await command.ExecuteAsync(id, ct);

            if (order is null)
            {
                return NotFound();
            }

            return View("Item", order);
        }
    }
}
