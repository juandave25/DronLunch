using System;
using System.Collections.Generic;
using System.Text;
using DronLunch.Model;

namespace DronLunch.Domain.Interfaces
{
    public interface IRouteDomain
    {
        List<Route> ReadFile(string FilePath, Drone drone);
    }
}
