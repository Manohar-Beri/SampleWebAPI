using System;
using System.Collections.Generic;

namespace SampleWebAPI.Models
{
    public partial class Customer
    {
        public string Custid { get; set; }
        public string CustName { get; set; }
        public string OrderId { get; set; }
        public string OrderReceived { get; set; }
        public string City { get; set; }
    }
}
