using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourcehqAPI.Models
{
    public class RobotNewsTypeModel
    {
        int RobotNewsId { get; set; }
        string RobotCategory { get; set; }
        string RobotTitle { get; set; }
        string RobotDescription { get; set; }
        string RobotImageUrl { get; set; }
        int RobotTemplateId { get; set; }
        DateTime RobotDateCreated { get; set; }
        DateTime RobotDateUpdated { get; set; }
    }
}
