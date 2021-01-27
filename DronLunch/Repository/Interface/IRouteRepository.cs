using System;
using System.Collections.Generic;
using System.Text;
using DronLunch.Model;

namespace DronLunch.Repository.Interface
{
    public interface IRouteRepository
    {
        List<Route> ReadFile(string FilePath, Drone drone);

    }
}
