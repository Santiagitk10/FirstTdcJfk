using FirstTdcJfk.Application.Interfaces;
using FirstTdcJfk.Application.Services;
using FirstTdcJfk.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FirstTdcJfk.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardController : Controller
    {
        private readonly ICreditCardService creditCardService;

        public CreditCardController(ICreditCardService creditCardService)
        {
            this.creditCardService = creditCardService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await creditCardService.GetAllCards();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await creditCardService.GetCardById(id);
            if (data == null) return Ok();
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreditCard tdc)
        {
            var data = await creditCardService.AddCard(tdc);
            return Ok(data);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await creditCardService.DeleteCard(id);
            return Ok(data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(CreditCard tdc)
        {
            var data = await creditCardService.UpdateCard(tdc);
            return Ok(data);
        }
    }
}