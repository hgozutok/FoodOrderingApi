﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FOApi
{
    public partial class Tblpayment
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public double Amount { get; set; }
        public string PaidBy { get; set; }
        public DateTime PaymentDate { get; set; }
        public int ProcessedBy { get; set; }
    }
}