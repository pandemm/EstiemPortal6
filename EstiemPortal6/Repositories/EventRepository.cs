using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EstiemPortal6.Models;
using System.Data.Entity;

namespace EstiemPortal6.Repositories
{
    public class EventRepository : IEventRepository, IDisposable
        
    {
        private EstiemPortalContext context;

        public EventRepository(EstiemPortalContext context)
        {
            this.context = context;
        }

        public List<Event> GetEvents()
        {
            return context.Events.ToList();
        }

        public Event GetEvent(int id)
        {
            return context.Events.Find(id);
        }


        public void AddEvent(Event ev)
        {
            context.Events.Add(ev);
        }

        public void DeleteEvent(int id)
        {
            Event ev = context.Events.Find(id);
            context.Events.Remove(ev);
        }
        public void EditEvent(Event ev)
        {
            context.Entry(ev).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}