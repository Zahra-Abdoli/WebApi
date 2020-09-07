using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class CheckOutInformations
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public string ZipCode { get; set; }
        public string MobilePhone { get; set; }
        public string EmailAdress { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
