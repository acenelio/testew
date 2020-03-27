using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.Enums
{
    public enum SaleStatus : int
    {
        Pending = 0,
        Billed = 1,//pedido faturado
        Canceled = 2
    }
}