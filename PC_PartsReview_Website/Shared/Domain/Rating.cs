using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_PartsReview_Website.Shared.Domain
{
    public class Rating : BaseDomainModel
    {
        public string? Quality { get; set; }
        public string? PersonalRating { get; set; }
    }
}
