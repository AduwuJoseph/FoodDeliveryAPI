﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliveryApp.API.Models
{
    public partial class OrderDetailVM
    {
        [Key]
        public int OrderId { get; set; }
        [Key]
        public int MealId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public short Quantity { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Discount { get; set; }

        public string MealName { get; set; }
        public virtual MealVM Meal { get; set; }
        public virtual OrderVM Order { get; set; }
    }
}