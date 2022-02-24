using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Simple_API.Domain.Classes;
using Simple_API.Domain.Enums;
using Simple_API.Domain.SimpleAPIAggregate;
using Simple_API.Infrastructure.DTOs;
using TrafficLights = Simple_API.Infrastructure.DTOs.TrafficLights;
using Camera = Simple_API.Infrastructure.DTOs.Camera;

namespace Simple_API.Infrastructure.Mock
{
    public static class FillTheJsonFile
    {
        private static Random rnd = new Random();

        public static void FillData()
        {
            try
            {
                var trafficLightsPath = "trafficLights.json";
                var camerasPath = "cameras.json";

                List<TrafficLights> trafficLights = new List<TrafficLights>();
                List<Camera> cameras = new List<Camera>();

                for (int i = 0; i < 10; i++)
                {
                    trafficLights.Add(new TrafficLights($"London tLamp_{rnd.Next(1,1000)}",$"111.60.86.{rnd.Next(0,255)}",ReachabilityTypes.IP));
                }
            
                for (int i = 0; i < 10; i++)
                {
                    cameras.Add(new Camera($"London cam_{rnd.Next(1,1000)}",$"111.60.86.{rnd.Next(0,255)}",ReachabilityTypes.API));
                }
            

                File.WriteAllText(trafficLightsPath, JsonConvert.SerializeObject(trafficLights));
                File.WriteAllText(camerasPath, JsonConvert.SerializeObject(cameras));

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}

