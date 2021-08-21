using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourcehqAPI.Models
{
    public class SourceNewsModel
    {
        int SourceNewsId { get; set; }
        string SourceCategory { get; set; }
        string SourceTitle { get; set; }
        string SourceDescription { get; set; }
        string SourceImageUrl { get; set; }
        int TemplateId { get; set; }
        bool CurrentNews { get; set; }
        DateTime DateCreated { get; set; }
        DateTime DateUpdated { get; set; }
    }
}
