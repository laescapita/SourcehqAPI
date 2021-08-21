using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourcehqAPI.Models
{
    public class RobotNewsModel
    {
        int RobotNewsId { get; set; }
        string RobotCategory { get; set; }
        string RobotTitle { get; set; }
        string RobotDescription { get; set; }
        string RobotImageUrl { get; set; }
        int TemplateId { get; set; }
        bool CurrentNews { get; set; }
        DateTime DateCreated { get; set; }
        DateTime DateUpdated { get; set; }

    }
}
