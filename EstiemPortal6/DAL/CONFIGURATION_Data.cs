namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONFIGURATION_Data
    {
        public int Id { get; set; }

        public int SetId { get; set; }

        public int KeyId { get; set; }

        public bool IsAsset { get; set; }

        [StringLength(200)]
        public string Value { get; set; }

        public bool? IsNull { get; set; }

        public int? AssetId { get; set; }

        public virtual CONFIGURATION_Assets CONFIGURATION_Assets { get; set; }

        public virtual CONFIGURATION_Keys CONFIGURATION_Keys { get; set; }

        public virtual CONFIGURATION_Sets CONFIGURATION_Sets { get; set; }
    }
}
