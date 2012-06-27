using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AwesomeEnterpriseApp.Models;

namespace AwesomeEnterpriseApp.DataAccessLayer
{
    public class RestaurantDAL
    {
        public Restaurant findRestaurant(String xCoord, String yCoord)
        {
            //get restaurant
            return null;
        }

        public Restaurant addRestaurant(String name, int cuisine, int fanciness, String websiteUrl, String houseNumber, String street1, 
            String street2, String zipCode, String city, String xCoord, String yCoord)
        {
            AddressDAL addressDAL = new AddressDAL();
            Address restaurantAddress = addressDAL.addAddress(houseNumber, street1, street2, zipCode, city);

            Restaurant restaurant = new Restaurant(name, cuisine, fanciness, websiteUrl, restaurantAddress, xCoord, yCoord);
            return restaurant;
        }

        public Boolean deleteRestaurant(int idRestaurant)
        {
            return false;
        }
    }
}