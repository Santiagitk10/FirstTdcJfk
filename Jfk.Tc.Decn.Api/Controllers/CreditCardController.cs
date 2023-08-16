using Jfk.Tc.Decn.Application.Interfaces;
using Jfk.Tc.Decn.Application.Services;
using Jfk.Tc.Decn.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jfk.Tc.Decn.Api.Controllers
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

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await creditCardService.GetAllCards();
            return Ok(data);
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await creditCardService.GetCardById(id);
            if (data == null) return Ok();
            return Ok(data);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(CreditCard tdc)
        {
            var data = await creditCardService.AddCard(tdc);
            return Ok(data);
        }

        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await creditCardService.DeleteCard(id);
            return Ok(data);
        }

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> Update(CreditCard tdc)
        {
            var data = await creditCardService.UpdateCard(tdc);
            return Ok(data);
        }
    }
}