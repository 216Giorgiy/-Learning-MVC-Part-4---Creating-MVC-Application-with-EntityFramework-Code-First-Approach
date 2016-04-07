using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LearningMVC.Models;

namespace LearningMVC
{
    public class MVCDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}