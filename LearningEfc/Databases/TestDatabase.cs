using System;
using LearningEfc.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningEfc.Databases
{
    public class TestDatabase : DbContext
    {
        public DbSet<Foo> Foos { get; set; }
        public DbSet<Bar> Bars { get; set; }
        
        public string DbPath { get; }

        public TestDatabase(DbContextOptions<TestDatabase> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
        }
    }
}