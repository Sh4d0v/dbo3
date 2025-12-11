using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersect.Server.Entities;

public partial class Achievement
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string Icon { get; set; } = ""; // path to resource e.g. "ach_icons/firstkill.png"
    public bool IsProgress { get; set; } = false;
    public int Max { get; set; } = 1; // for progress achievements
}
