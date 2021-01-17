using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Familiada.Data
{
    public class User : IdentityUser
    {
        [ForeignKey("GameId")]
        public Game Game { get; set; }
        public int GameId { get; set; }
    }
}
