namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PORTAL_PageModule
    {
        public int Id { get; set; }

        public int PageId { get; set; }

        public int ModuleId { get; set; }

        public int ModuleOrder { get; set; }

        public int AreaId { get; set; }

        public bool ShowAlways { get; set; }

        public bool IsUniqueModuleInstance { get; set; }

        public bool IncludeInSearch { get; set; }

        public virtual PORTAL_Module PORTAL_Module { get; set; }

        public virtual PORTAL_Page PORTAL_Page { get; set; }
    }
}
