using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AwesomeEnterpriseApp.Models;

namespace AwesomeEnterpriseApp.DataAccessLayer
{
    public class AddressDAL
    {
        public Address findAddress(int idAddress)
        {
            return null;
        }
        public Address addAddress(String houseNumber, String street1, String street2, String zipCode, String city)
        {
            Address address = new Address(houseNumber, street1, street2, zipCode, city);
            return address;
        }

        public Boolean deleteAddress(int idAddress)
        {
            return false;
        }

    }
}