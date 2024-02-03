using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_PartsReview_Website.Shared.Domain
{
    public class Review : BaseDomainModel
    {
        public string? ReviewTitle { get; set; }
        public string? ReviewDescription { get; set; }

        public int RatingId {  get; set; }
        public virtual Rating? Rating {  get; set; }

        public int PcPartId { get; set; }
        public virtual PcPart? PcPart { get; set; }
    }
}
