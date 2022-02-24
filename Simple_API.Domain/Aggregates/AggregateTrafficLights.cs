using System;
using System.Threading.Tasks;
using Simple_API.Domain.Enums;
using Simple_API.Domain.SimpleAPIAggregate;

namespace Simple_API.Domain.Classes
{
    public abstract class TrafficLights : IDevice, ILight, IReachableWithIp
    {
        public Guid Id { get; }
        public string DeviceName { get; set; }
        public string Url { get; }
        public ReachabilityTypes ReachabilityType { get; set; }

        public  abstract Task<object> ReadData();

        protected TrafficLights(Guid id, string deviceName, string url, ReachabilityTypes reachabilityType)
        {
            Id = id;
            DeviceName = deviceName;
            Url = url;
            ReachabilityType = reachabilityType;
        }
        protected TrafficLights(string deviceName, string url, ReachabilityTypes reachabilityType)
        {
            DeviceName = deviceName;
            Url = url;
            ReachabilityType = reachabilityType;
            Id = Guid.NewGuid();
        }

    }
}