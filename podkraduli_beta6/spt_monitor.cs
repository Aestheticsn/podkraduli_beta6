//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace podkraduli_beta6
{
    using System;
    using System.Collections.Generic;
    
    public partial class spt_monitor
    {
        public System.DateTime lastrun { get; set; }
        public int cpu_busy { get; set; }
        public int io_busy { get; set; }
        public int idle { get; set; }
        public int pack_received { get; set; }
        public int pack_sent { get; set; }
        public int connections { get; set; }
        public int pack_errors { get; set; }
        public int total_read { get; set; }
        public int total_write { get; set; }
        public int total_errors { get; set; }
    }
}
