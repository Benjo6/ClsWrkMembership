using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClsWrkMembership.Models
{
    public class Bank
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Credit_Card { get; set; }
        [Required]
        public int Money { get; set; }
    }
}
