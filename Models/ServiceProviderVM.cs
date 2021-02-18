﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliveryApp.API.Models
{
    [Table("ServiceProvider")]
    public partial class ServiceProviderVM
    {
        [Key]
        public string ProviderId { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [Required]
        [StringLength(256)]
        public string Email { get; set; }
        [Required]
        [StringLength(35)]
        public string PhoneNumber { get; set; }
        public int? CityCode { get; set; }
        [StringLength(150)]
        public string Logo { get; set; }

        public string CityName { get; set; }

        public virtual ICollection<MealVM> Meals { get; set; }
    }
}