using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jfk.Tc.Decn.Application.Interfaces;
using Jfk.Tc.Decn.Domain.Entities;

namespace Jfk.Tc.Decn.Infrastructure.Adapters
{

    public class DecisionMotorAdapter : IDecisionMotorAdapter
    {
        private readonly HttpClient _httpClient;

        public DecisionMotorAdapter(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<DecisionMotorEvertec> ObtenerDecision(Usuario usuario)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"https://api.example.com/id");

            if (response.IsSuccessStatusCode)
            {
                var decision = await response.Content.ReadAsStringAsync();
                // Realizar mapeo de datos a un objeto DecisionMotorEvertec
            }

            return null; // Manejo de errores
        }
    }
}
