using Microsoft.AspNet.Identity;
using MvcAuth.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcAuth.DAL
{
    public class BlogPostContext : ApplicationDbContext
    {
        public virtual DbSet<BlogPost> Posts { get; set; }
    }
}