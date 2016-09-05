using EstiemPortal6.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace EstiemPortal6.App_Start
{
    public class GlobalConfigurationModule
    {
        private readonly Assembly assembly;

        public GlobalConfigurationModule()
            : this(Assembly.GetExecutingAssembly())
        {
        }

        public GlobalConfigurationModule(Assembly assembly)
        {
            this.assembly = assembly;
        }

        public void Load()
        {
            var ins = from x in assembly.GetExportedTypes()
                      where x.GetInterfaces().Contains(typeof(IGlobalConfiguration))
                      select Activator.CreateInstance(x) as IGlobalConfiguration;

            foreach (var config in ins)
            {
                config.Configure();
            }
        }
    }
}