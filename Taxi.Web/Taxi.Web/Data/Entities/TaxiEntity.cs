﻿using System.ComponentModel.DataAnnotations;

namespace Taxi.Web.Data.Entities
{
    public class TaxiEntity : IEntity
    {
        public int Id { get; set; }


        [StringLength(6, MinimumLength = 6, ErrorMessage = "The {0} field must have {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory")]
        [RegularExpression(@"^([A-Za-z]{3}\d{3})$", ErrorMessage = "The field {0} must starts with three characters and ends with numbers.")]

        public string Plaque { get; set; }
        /* * 
        public ICollection<TripEntity> Trips { get; set; }

        public UserEntity User { get; set; }
         */
    }
}