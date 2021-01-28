using System;
using System.Collections.Generic;
using System.IO;
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

        public void CreateFile(string FilePath, List<string> textReport)
        {
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }

            using (FileStream fs = File.Create(FilePath))
            {
                byte[] title = new UTF8Encoding(true).GetBytes("== Delivery Report == \n");
                fs.Write(title, 0, title.Length);
                foreach (string text in textReport)
                {
                    byte[] textValue = new UTF8Encoding(true).GetBytes($"{text} \n");
                    fs.Write(textValue, 0, textValue.Length);
                } 
            }
        }
    }
}
