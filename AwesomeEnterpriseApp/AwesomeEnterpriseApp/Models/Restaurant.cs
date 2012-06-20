using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace AwesomeEnterpriseApp.Models
{
    [Table(Name="restaurant")]
    public class Restaurant
    {
        [Column(IsPrimaryKey = true, Storage = "idRestaurant")]
        int idRestaurant { get; set; }
        [Column(Name="name")]
        String name { get; set; }
        [Column(Name = "cuisine")]
        int cuisine { get; set; }
        [Column(Name = "fanciness")]
        int fanciness { get; set; }
        [Column(Name = "websiteUrl")]
        String websiteUrl { get; set; }
        [Column(Name = "address")]
        Address address { get; set; }
        [Column(Name = "xCoord")]
        String xCoord { get; set; }
        [Column(Name = "yCoord")]
        String yCoord { get; set; }

        public int ID
        {
            get { return idRestaurant; }
        }

        public void setID(int idRestaurant)
        {
           this.idRestaurant = idRestaurant; 
        }

        public Restaurant(String name, int cuisine, int fanciness, String websiteUrl, Address address, String xCoord, String yCoord)
        {
            this.name = name;
            this.cuisine = cuisine;
            this.fanciness = fanciness;
            this.websiteUrl = websiteUrl;
            this.address = address;
            this.xCoord = xCoord;
            this.yCoord = yCoord;
        }

    }
}