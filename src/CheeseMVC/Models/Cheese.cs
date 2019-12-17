﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public CheeseType Type { get; set; }
        public int CategoryID { get; set; }
        public CheeseCategory Category { get; set; }
        public List<CheeseMenu> CheeseMenus { get; set; }
    }
}
