using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jfk.Tc.Decn.Application.Interfaces
{
    public interface IUnitOfWork
    {
        ICreditCardRepository Tdcs { get; }
    }
}