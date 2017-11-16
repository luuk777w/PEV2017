using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PEV.Models.ManageViewModels
{
    public class GenerateRecoveryCodesViewModel
    {

        public int Id { get; set; }
        [NotMapped]
        public string[] RecoveryCodes { get; set; }
    }
}
