using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineBanking.Models
{
    public class Beneficiary
    {
        public int Id { get; set; }

        [Required]
        public string BeneficiaryName { get; set; }

        [Required]
        public string BeneficiaryAccountNo { get; set; }

        [Required]
        public string BeneficiaryBankName { get; set; }

        [Required]
        public string BeneficiaryIFSCode { get; set; }

        public string TransferLimit { get; set; }

    }
}