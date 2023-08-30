using Jfk.Tc.Decn.Application.Services;
using Jfk.Tc.Decn.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Jfk.Tc.Decn.Soap
{
    public class CreditCardSoapService : ICreditCardSoapService
    {
        private readonly ICreditCardService creditCardService;

        public CreditCardSoapService(ICreditCardService creditCardService)
        {
            this.creditCardService = creditCardService;
        }

        public async Task<IEnumerable<CreditCard>> GetAll()
        {
            return await creditCardService.GetAllCards();
        }

        public async Task<CreditCard> GetById(int id)
        {
            return await creditCardService.GetCardById(id);
        }

        public async Task<int> Add(CreditCard tdc)
        {
            return await creditCardService.AddCard(tdc);
        }

        public string Res(int num1, int num2)
        {
            return $"Res of two number is: {num1 - num2}";
            //https://localhost:7123/CreditCard.asmx/Res?num1=2&num2=3
        }
    }
}
