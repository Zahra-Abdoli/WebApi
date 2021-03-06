﻿using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Products
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
