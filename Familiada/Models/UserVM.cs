using Familiada.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Familiada.Models
{
    public class UserVM
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public GameVM Game { get; set; }
        public int GameId { get; set; }
    }
}
