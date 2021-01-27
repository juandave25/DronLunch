using System;
using System.Collections.Generic;
using System.Text;

namespace DronLunch.Model
{
    public class Route
    {
        public Drone Drone { get; set; }
        public List<string> AssignedRoutes { get; set; }
    }
}
