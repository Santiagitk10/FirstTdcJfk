using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jfk.Tc.Decn.Domain.Entities;

namespace Jfk.Tc.Decn.Application.Interfaces
{
    public  interface IDecisionMotorAdapter
    {
        Task<DecisionMotorEvertec> ObtenerDecision(Usuario usuario);
    }
}
