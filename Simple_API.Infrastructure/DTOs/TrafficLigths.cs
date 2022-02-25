using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Simple_API.Domain.Classes;
using Simple_API.Domain.Enums;
using Simple_API.Domain.SimpleAPIAggregate;

namespace Simple_API.Infrastructure.DTOs
{
    public class TrafficLights:AggregateTrafficLights
    {
        public TrafficLights(string deviceName, string url, ReachabilityTypes reachabilityType) : base(deviceName, url, reachabilityType)
        {
        }
        
        
      //  public TrafficLights(string guid,string deviceName, string url, ReachabilityTypes reachabilityType): base(guid,deviceName, url, reachabilityType)
       // {
        //}

        public TrafficLights()
        {
            
        }
        
        public override Task<object> ReadData()
        {
            var result = new { Data = $"It's a data from {this.DeviceName}." };
            return Task.FromResult((object)result);
        }


    }
}