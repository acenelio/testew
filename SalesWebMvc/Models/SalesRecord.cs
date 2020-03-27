using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public uint Id { get;set; }
        public DateTime Date { get; set; }
        public double Amount { get;set; }
        public SaleStatus Status { get;set; }
        public Seller Seller { get;set; }

        public SalesRecord()
        {

        }

        public SalesRecord(uint id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}