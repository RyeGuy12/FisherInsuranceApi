using System;
using System.Collections.Generic;
using FisherInsuranceApi.Models;

namespace FisherInsuranceApi.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}