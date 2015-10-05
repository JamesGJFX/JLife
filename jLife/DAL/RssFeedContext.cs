using jLife.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace jLife.DAL
{
    public class RssFeedContext : DbContext
    {
        public RssFeedContext() : base("RssFeedContext")
        {

        }

        public DbSet<RssFeed> RssFeeds { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}