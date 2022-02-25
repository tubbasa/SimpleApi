using System;
using System.Threading.Tasks;
using Simple_API.Domain.Enums;
using Simple_API.Domain.SimpleAPIAggregate;

namespace Simple_API.Domain.Classes
{
    public abstract class AggregateTrafficLights : IDevice, ILight, IReachableWithIp
    {
        public Guid Id { get; set; }
        public string DeviceName { get; set; }
        public string Url { get; set; }
        public ReachabilityTypes ReachabilityType { get; set; }

        public  abstract Task<object> ReadData();

       // protected AggregateTrafficLights(string id, string deviceName, string url, ReachabilityTypes reachabilityType)
        //{
         //   Id = id;
          //  DeviceName = deviceName;
          //  Url = url;
          //  ReachabilityType = reachabilityType;
        //}
        
        protected AggregateTrafficLights(string deviceName, string url, ReachabilityTypes reachabilityType)
        {
            DeviceName = deviceName;
            Url = url;
            ReachabilityType = reachabilityType;
            Id = Guid.NewGuid();
        }

        public AggregateTrafficLights()
        {
            
        }

    }
}