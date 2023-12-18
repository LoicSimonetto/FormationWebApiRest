using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }

        protected DefaultContext()
        {
        }

        #region Properties
        public DbSet<Models.Aventure> Aventures { get; set; }
        public DbSet<Models.Paragraphe> Paragraphes { get; set; }
        public DbSet<Models.Question> Questions { get; set; }
        public DbSet<Models.Reponse> Reponses { get; set; }
        #endregion
    }
}
