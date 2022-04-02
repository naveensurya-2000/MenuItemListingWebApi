using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MenuItemListingWebApi.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Free Delivery")]
        public bool FreeDelivery { get; set; }

        [Required]
        public double Price { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfLaunch { get; set; }
        public bool Active { get; set; }

        public MenuItem(int id, string name, bool freedelivery, double price, string dateoflaunch, bool active)
        {
            this.Id = id;
            this.Name = name;
            this.FreeDelivery = freedelivery;
            this.Price = price;
            this.DateOfLaunch = DateTime.Parse(dateoflaunch);
            this.Active = active;
        }

    }
}
