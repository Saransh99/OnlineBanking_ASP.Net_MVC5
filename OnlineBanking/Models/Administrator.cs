using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineBanking.Models
{
    public class Administrator
    {
        public int Id { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Username { get; set; }
        public BranchManager BranchManager { get; set; }

    }
}