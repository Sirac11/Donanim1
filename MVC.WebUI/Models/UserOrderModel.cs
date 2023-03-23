﻿using MVC.WebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.WebUI.Models
{
    public class UserOrderModel
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public EnumOrderState OrderState { get; set; }
        public DateTime OrderDate { get; set; }        
    }
}