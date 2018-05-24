using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PE3.Dlusion.Entities
{
    public class QueueItem
    {
        [Key]
        public long QueueItemId { get; set; }
        [MaxLength(8)]
        public string URL { get; set; }
        public DateTime TimeSubmitted { get; set; }
    }
}
