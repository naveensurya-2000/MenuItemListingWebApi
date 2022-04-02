using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuItemListingWebApi.Models;

namespace MenuItemListingWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        List<MenuItem> menuItems = new List<MenuItem>()
        {
                new MenuItem(1,"Pizza",true,400,"2022-03-31",false),
                new MenuItem(2,"Burger",true,200,"2022-03-26",true),
                new MenuItem(3,"Sandwich",false,600,"2022-03-20",true),
                new MenuItem(4,"French fries",true,400,"2022-03-31",false)
        };

        [HttpGet]
        public List<MenuItem> Get()
        {
            return menuItems;
        }

        [HttpGet("{id}")]
        public MenuItem Get(int id)
        {
            return menuItems[id - 1];
        }
    }
}