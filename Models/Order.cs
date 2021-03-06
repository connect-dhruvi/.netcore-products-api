﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace web_api.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int USerID { get; set; }

        [JsonIgnore]
        public virtual User User { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}