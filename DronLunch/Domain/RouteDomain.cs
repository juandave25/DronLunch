using System;
using System.Collections.Generic;
using System.Text;
using DronLunch.Domain.Interfaces;
using DronLunch.Model;
using DronLunch.Repository.Interface;

namespace DronLunch.Domain
{
    public class RouteDomain : IRouteDomain
    {
        private readonly IRouteRepository _RouteRepository;

        public RouteDomain()
        {
        }

        public RouteDomain(IRouteRepository RouteRepository)
        {
            _RouteRepository = RouteRepository;
        }

        public List<Route> ReadFile(string FilePath, Drone drone)
        {
            List<Route> Assignedroutes = new List<Route>();
            Assignedroutes = _RouteRepository.ReadFile(FilePath, drone);
            return Assignedroutes;
        }
    }
}
