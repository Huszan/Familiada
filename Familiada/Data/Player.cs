using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Familiada.Data
{
    public class Player : IdentityUser
    {
        public int Highscore { get; set; }
        public int PointsScored { get; set; }
        public int GamesPlayed { get; set; }
    }
}
