using System;
using Xunit;
using DronLunch.Model;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DronLunchTest
{
    public class RouteSchedulingTest
    {
        List<Route> AssignedRoutes = new List<Route>();
        Drone Drone1 = new Drone();
        List<string> Routes = new List<string>();
        Route AssignedRoute1 = new Route { Drone = new Drone { Id = 1 }, AssignedRoutes = new List<string>() };
        string InputFileName = @"D:\in01.txt";
        string OutputFileName = @"D:\out01.txt";

        public RouteSchedulingTest()
        {

        }

        [Fact]
        public void AddAssignedRoutes()
        {
            Routes.Add("AAAAIAA");
            Routes.Add("DDDAIAD");
            Routes.Add("AAIADAD");
            AssignedRoute1.AssignedRoutes = Routes;
            AssignedRoutes.Add(AssignedRoute1);
            Assert.NotEmpty(AssignedRoutes);
        }

        [Fact]
        public void CreateFileRoutesDrone()
        {
            if (File.Exists(InputFileName))
            {
                File.Delete(InputFileName);
            }

            using (FileStream fs = File.Create(InputFileName))
            { 
                byte[] route1 = new UTF8Encoding(true).GetBytes("AAAAIAA \n");
                fs.Write(route1, 0, route1.Length);
                byte[] route2 = new UTF8Encoding(true).GetBytes("DDDAIAD \n");
                fs.Write(route2, 0, route2.Length);
                byte[] route3 = new UTF8Encoding(true).GetBytes("DDDAIAD");
                fs.Write(route3, 0, route3.Length);

                Assert.IsType<FileStream>(fs);
            }

            
        }

        [Fact]
        public void GenerateDeliveryReport()
        {
            if (File.Exists(OutputFileName))
            {
                File.Delete(OutputFileName);
            }

            using (FileStream fs = File.Create(OutputFileName))
            {
                byte[] title = new UTF8Encoding(true).GetBytes("== Reporte de entregas == \n");
                fs.Write(title, 0, title.Length);
                byte[] route1 = new UTF8Encoding(true).GetBytes("(-2, 4) dirección Norte \n");
                fs.Write(route1, 0, route1.Length);
                byte[] route2 = new UTF8Encoding(true).GetBytes("(-3, 3) dirección Sur \n");
                fs.Write(route2, 0, route2.Length);
                byte[] route3 = new UTF8Encoding(true).GetBytes("(-4, 2) dirección Oriente");
                fs.Write(route3, 0, route3.Length);

                Assert.IsType<FileStream>(fs);
            }


        }
    }
}
