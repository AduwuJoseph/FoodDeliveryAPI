﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliveryApp.API.Models
{
    public partial class CartItemVM
    {
        [Key]
        public string ItemId { get; set; }
        [Required]
        [StringLength(450)]
        public string CartId { get; set; }
        public int? MealId { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Discount { get; set; }
        [StringLength(450)]
        public string CustomerId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }

        public int OrderId { get; set; }
        public string MealName { get; set; }

        public virtual CustomerVM Customer { get; set; }
        public virtual MealVM Meal { get; set; }
        public virtual IEnumerable<CartItemVM> CartItems { get; set; }
    }
}