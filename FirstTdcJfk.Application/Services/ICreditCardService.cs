﻿using FirstTdcJfk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTdcJfk.Application.Services
{
    public interface ICreditCardService
    {
        Task<int> AddCard(CreditCard card);

        Task<int> DeleteCard(int id);

        Task<IEnumerable<CreditCard>> GetAllCards();

        Task<CreditCard> GetCardById(int id);

        Task<int> UpdateCard(CreditCard card);
    }
}