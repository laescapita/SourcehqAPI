using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourcehqAPI.Models
{
    public class OfficerMinutesType
    {
        int MinutesId { get; set; }
        int OfficerId { get; set; }
        string MinutesDescription { get; set; }
        bool CurrentMintesInd { get; set; }
        DateTime MinutesWeek { get; set; }
        DateTime DateUpdated { get; set; }
        DateTime DateCreated { get; set; }
    }
}
