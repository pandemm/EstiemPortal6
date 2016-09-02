using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EstiemPortal6.Models;
namespace EstiemPortal6.Repositories
{
    public interface IEventRepository : IDisposable
    {
        List<Event> GetEvents();
        Event GetEvent(int id);
        void AddEvent(Event ev);
        void DeleteEvent(int id);
        void EditEvent(Event ev);
        void Save();

    }
}