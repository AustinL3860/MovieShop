using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class PurchaseRequestModel
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public Decimal TotalPrice { get; set; }
        public DateTime PurchaseDateTime { get; set; }

    }
}