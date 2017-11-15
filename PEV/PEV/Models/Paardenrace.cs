
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PEV.Models
{

    public class Paardenrace
        {
            public int gameid { get; set; }

            public string userid { get; set; }

            public int inzet { get; set; }

            public string paard { get; set; }
        }

}
