using System;
using System.Collections.Generic;
using System.Text;
using DronLunch.Model;
using DronLunch.Repository.Interface;
using DronLunch.Helper;

namespace DronLunch.Repository
{
    public class RouteRepository : IRouteRepository
    {
        public List<Route> ReadFile(string FilePath, Drone drone)
        {
            List<Route> Assignedroutes = new List<Route>();
            Route AssignedRoute = new Route();
            List<String> Routes = new List<string>();
            FileReading fileReading = new FileReading();

            string[] Filelines = fileReading.ReadFile(FilePath);

            foreach (string line in Filelines)
            {
                Routes.Add(line.Trim());
            }

            AssignedRoute.AssignedRoutes = Routes;
            AssignedRoute.Drone = drone;

            Assignedroutes.Add(AssignedRoute);

            return Assignedroutes;
        }
    }
}
