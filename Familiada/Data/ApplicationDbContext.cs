using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Familiada.Models;

namespace Familiada.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Player> players { get; set; }
        public DbSet<Familiada.Models.GameVM> GameVM { get; set; }
        public DbSet<Familiada.Models.AnswerVM> AnswerVM { get; set; }
        public DbSet<Familiada.Models.QuestionVM> QuestionVM { get; set; }
        public DbSet<Familiada.Models.PlayerVM> PlayerVM { get; set; }

    }
}
