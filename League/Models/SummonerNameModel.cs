using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace League.Models
{
    public class SummonerNameModel
    {
        [Required]
        public string SummonerName { get; set; }
    }
}