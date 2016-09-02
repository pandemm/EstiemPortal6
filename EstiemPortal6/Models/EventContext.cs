using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EstiemPortal6.Models
{
    public class EstiemPortalContext : DbContext
    {
        public EstiemPortalContext() : base("name=EP6")
        {

        }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventParticipants> EventParticipants { get; set; }
        public DbSet<User> Users { get; set; }
    }


}