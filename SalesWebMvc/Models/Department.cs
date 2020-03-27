using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public uint Id { get;set; }
        public string Name { get;set; }//Nome do departamento
        public ICollection<Seller> Sellers { get;set; } = new List<Seller>();

        public Department()
        {

        }

        public Department(uint id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller) 
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}