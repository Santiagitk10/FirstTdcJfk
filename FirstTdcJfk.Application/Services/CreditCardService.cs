using FirstTdcJfk.Application.Interfaces;
using FirstTdcJfk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTdcJfk.Application.Services
{
    public class CreditCardService : ICreditCardService
    {
        private readonly IUnitOfWork unitOfWork;

        public CreditCardService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<int> AddCard(CreditCard card)
        {
            var data = await unitOfWork.Tdcs.AddAsync(card);
            return data;
        }

        public async Task<int> DeleteCard(int id)
        {
            var data = await unitOfWork.Tdcs.DeleteAsync(id);
            return data;
        }

        public async Task<IEnumerable<CreditCard>> GetAllCards()
        {
            var data = await unitOfWork.Tdcs.GetAllAsync();
            return data;
        }

        public async Task<CreditCard> GetCardById(int id)
        {
            try
            {
                var data = await unitOfWork.Tdcs.GetByIdAsync(id);
                if (data != null) return data;
                throw new InvalidOperationException("Object not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return null;
            }
        }

        public async Task<int> UpdateCard(CreditCard card)
        {
            var data = await unitOfWork.Tdcs.UpdateAsync(card);
            return data;
        }
    }
}