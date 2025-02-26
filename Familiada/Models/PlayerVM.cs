﻿using Familiada.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Familiada.Models
{
    public class PlayerVM
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int Highscore { get; set; }
        public int PointsScored { get; set; }
        public int GamesPlayed { get; set; }
    }
}
