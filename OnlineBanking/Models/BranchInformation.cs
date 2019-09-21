using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineBanking.Models
{
    public class BranchInformation
    {
        public int Id { get; set; }
        [Required]
        public string BranchCode { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string PinCode { get; set; }

        [Required]
        public string IFSCode { get; set; }
    }
}