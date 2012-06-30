using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace AwesomeEnterpriseApp.Models
{
    [Table(Name = "address")]
    public class Address
    {
        [Column(IsPrimaryKey = true, Storage = "idAddress")]
        public int idAddress { get; set; }
        [Column(Name = "houseNumber")]
        public String houseNumber { get; set; }
        [Column(Name = "streetAddress1")]
        public String streetAddress1 { get; set; }
        [Column(Name = "streetAddress2")]
        public String streetAddress2 { get; set; }
        [Column(Name = "zipCode")]
        public String zipCode { get; set; }
        [Column(Name = "city")]
        public String city { get; set; }

        public Address(String houseNumber, String street1, String street2, String zipCode, String city)
        {
            this.houseNumber = houseNumber;
            this.streetAddress1 = street1;
            this.streetAddress2 = street2;
            this.zipCode = zipCode;
            this.city = city;
        }

    }
}