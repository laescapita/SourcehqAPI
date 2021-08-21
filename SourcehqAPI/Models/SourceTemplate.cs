using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourcehqAPI.Models
{
    public class SourceTemplate
    {
        int SourceTemplateId { get; set; }
        string TemplateBody { get; set; }
        bool ActiveInd { get; set; }
    }
}
