using System;
using DronLunch.Model;
using DronLunch.Repository.Interface;
using DronLunch.Domain.Interfaces;
using System.Collections.Generic;
using DronLunch.Domain;
using DronLunch.Repository;

namespace DronLunch
{
    class Program
    {
        static string InputFileName = @"D:\in01.txt";
        private static IPositionDomain _positionDomain;
        private static IRouteDomain _routeDomain;
        private static IRouteRepository _routeRepository;

        static void Main(string[] args)
        {
            List<Route> routes = new List<Route>();
            Drone drone = new Drone { Id = 1, Capacity = 3 };
            _routeRepository = new RouteRepository();
            _routeDomain = new RouteDomain(_routeRepository);
            _positionDomain = new PositionDomain();
            routes = _routeDomain.ReadFile(InputFileName, drone);

            routes.ForEach((route) =>
            {
                int cont = 0;
                Position Position = new Position();
                route.AssignedRoutes.ForEach((assignedRoute) =>
                {
                    if (cont == 0)
                    {
                        Position.Direction = "NORTH";
                        Position.Xposition = 0;
                        Position.Yposition = 0;
                    };
                    for (int index=0; index < assignedRoute.Split("").Length; index++)
                    {
                        
                        switch (assignedRoute[index].ToString())
                        {
                            case "A":
                               Position= _positionDomain.MoveForward(Position);
                                break;
                            case "D":
                                Position = _positionDomain.TurnRight(Position);
                                break;
                            case "I":
                                Position = _positionDomain.TurnLeft(Position);
                                break;
                            default:
                                break;
                        } 
                    }

                    cont += 1;

                });



            });

            Console.WriteLine("Hello World!");
        }

    }
}
