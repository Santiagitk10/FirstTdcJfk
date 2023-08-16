using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jfk.Tc.Decn.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal Ingresos { get; set; }
        public decimal GastosFamiliares { get; set; }
        public int CuotasFinancieras { get; }
        public int Edad { get; set; }
        public int FactorDeRiesgo { get; set; }
        public decimal TasaInteres { get; set; }
        public int ValorUDI { get; set; }
        public string HabitoDePago { get; set; }
        public string EstadoCedula { get; set; }
        public string Alertas { get; set; }
    }
}