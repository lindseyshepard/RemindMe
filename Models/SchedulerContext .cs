using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemindMe.Models
{
    public partial class SchedulerContext : DbContext
    {
        public SchedulerContext() : base("name=SchedulerContext") { }
        public virtual DbSet<Event> Events { get; set; }
    }
}
