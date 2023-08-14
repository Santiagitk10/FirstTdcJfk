using FirstTdcJfk.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTdcJfk.Domain.Entities
{
    public class CreditCard
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string Category { get; set; }
        public string Franchise { get; set; }
        public string GoodThru { get; set; }
        public string ClientName { get; set; }
        public string CutoffDate { get; set; }
        public string PaymentDate { get; set; }
        public decimal Limit { get; set; }
        public decimal Spent { get; set; }
        public decimal Rate { get; set; }
        public CardStatus Status { get; set; }
    }
}