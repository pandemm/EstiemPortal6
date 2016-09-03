namespace EstiemPortal6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORUM_Replace_Words
    {
        public int ID { get; set; }

        public int BoardId { get; set; }

        [StringLength(255)]
        public string BadWord { get; set; }

        [StringLength(255)]
        public string GoodWord { get; set; }
    }
}
