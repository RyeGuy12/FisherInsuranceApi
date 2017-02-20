using System;
using System.Collections.Generic;
using FisherInsuranceApi.Models;

namespace FisherInsuranceApi.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string PolicyNumber { get; set; }
        public decimal LossAmount { get; set; }
        public DateTime LossDate { get; set; }
        public string Status { get; set; }
    }
}