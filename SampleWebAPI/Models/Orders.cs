using System;
using System.Collections.Generic;

namespace SampleWebAPI.Models
{
    public partial class Orders
    {
        public string OrderId { get; set; }
        public string OrderName { get; set; }
        public int? Quantity { get; set; }
        public int? Price { get; set; }
        public string Description { get; set; }
        public string IsDelivered { get; set; }
        public string Status { get; set; }
        public string BatchCategory { get; set; }
    }
}
