using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstiemPortal6.ViewModels
{
    interface IGlobalConfiguration
    {
        void Configure();
    }
    public class AutoMapperViewModelConfiguration : IGlobalConfiguration
    {
        public void Configure()
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EVENTS_Events, EventViewModel>();
                cfg.CreateMap<EventViewModel, EVENTS_Events>();
            });

            IMapper mapper = config.CreateMapper();
            var source = new EventViewModel();
            var dest = mapper.Map<EventViewModel, EVENTS_Events>(source);

        }
    }
}