using Jfk.Tc.Decn.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jfk.Tc.Decn.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICreditCardRepository Tdcs { get; }

        public UnitOfWork(ICreditCardRepository tdcRepository)
        {
            Tdcs = tdcRepository;
        }
    }
}