// Copyright (C) 2016 David Straw

using System.Data.Entity;
using HomeAutomation.Models;

namespace HomeAutomation.DataAccess
{
    public class HomeAutomationContext : DbContext
    {
        public HomeAutomationContext() : base("HomeAutomation")
        {
        }

        public DbSet<GarageDoor> GarageDoors { get; set; }
    }
}