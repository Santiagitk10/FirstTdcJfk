using FirstTdcJfk.Application.Interfaces;
using FirstTdcJfk.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FirstTdcJfk.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TdcController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public TdcController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await unitOfWork.Tdcs.GetAllAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.Tdcs.GetByIdAsync(id);
            if (data == null) return Ok();
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Tdc tdc)
        {
            var data = await unitOfWork.Tdcs.AddAsync(tdc);
            return Ok(data);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await unitOfWork.Tdcs.DeleteAsync(id);
            return Ok(data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Tdc tdc)
        {
            var data = await unitOfWork.Tdcs.UpdateAsync(tdc);
            return Ok(data);
        }
    }
}