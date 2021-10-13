using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;


namespace Lab3.Models
{
    public class Person
    {
        [Required]
        [StringLength(50)]
        [BindProperty(Name = "firstName")]
        public String FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [BindProperty(Name = "lastName")]
        public String LastName { get; set; }

        [Required]
        [BindProperty(Name = "age")]
        public int Age { get; set; }

        [Required]
        [BindProperty(Name = "email")]
        [StringLength(255)]
        public String EmailAddress { get; set; }

        [Required]
        [StringLength(255)]
        [BindProperty(Name = "pwd")]
        public String Password { get; set; }

        [Required]
        [StringLength(255)]
        [BindProperty(Name = "description")]
        public String Description { get; set; }
    }
}
