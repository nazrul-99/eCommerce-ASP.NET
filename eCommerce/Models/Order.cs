﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        public string Email { get; set; }

        public string UserID { get; set; }      
    
        public List<OrderItem> OrderItems { get; set; }
    }
}