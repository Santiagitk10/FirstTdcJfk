using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jfk.Tc.Decn.Application.Interfaces;
using Jfk.Tc.Decn.Domain.Entities;

namespace Jfk.Tc.Decn.Application.Services
{
    public class DecisionMotorServices : IDecisionMotorServices
    {
        private readonly IDecisionMotorAdapter _decisionMotorAdapter;

        public DecisionMotorServices(IDecisionMotorAdapter decisionMotorAdapter)
        {
            _decisionMotorAdapter = decisionMotorAdapter;
        }

        public Task<DecisionMotorEvertec> ObtnerDecision(Usuario usuario)
        {
            return _decisionMotorAdapter.ObtenerDecision(usuario); ;
        }
    }
}
