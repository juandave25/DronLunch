using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DronLunch.Model;
using DronLunch.Repository;
using DronLunch.Repository.Interface;
using System.IO;

namespace DronLunchTest
{
    public class RouteRepositoryTest
    {
        List<Route> AssignedRoutes = new List<Route>();
        private IRouteRepository _RouteRepository;
        string InputFileName = @"D:\in01.txt";

        public RouteRepositoryTest()
        {
        }

        [Fact]
        public void GetAssignedRoutes()
        {
            Drone drone = new Drone { Id = 1, Capacity = 3 };
            _RouteRepository = new RouteRepository();
            AssignedRoutes = _RouteRepository.ReadFile(InputFileName,drone);
            Assert.NotNull(AssignedRoutes);
        }
    }
}
