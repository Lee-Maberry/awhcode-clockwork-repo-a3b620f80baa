﻿using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Clockwork.API.Models
{
    public class ClockworkContext : DbContext
    {

        public DbSet<CurrentTimeQuery> CurrentTimeQueries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=clockwork.db");
        }
    }



    public class CurrentTimeQuery
    {
        [Key]
        public int  CurrentTimeQueryId { get; set; }
        public DateTime Time { get; set; }
        public string ClientIp { get; set; }
        public DateTime UTCTime { get; set; }
        public string TimeZone { get; set; } //added in the timezone
    }
}
