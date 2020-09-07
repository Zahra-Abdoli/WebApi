using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Categories
    {
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public string Image { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
