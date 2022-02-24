using System;
using System.Threading.Tasks;
using Simple_API.Domain.Enums;
using Simple_API.Domain.SimpleAPIAggregate;

namespace Simple_API.Domain.Classes
{
    public abstract class AggregateCamera: IDevice, IReachableWithIp, IVideoRecordable
    {
        public Guid Id { get; }
        public string DeviceName { get; set; }
        public string Url { get; }
        public ReachabilityTypes ReachabilityType { get; set; }

        protected AggregateCamera(string deviceName, string url, ReachabilityTypes reachabilityType)
        {
            Id = Guid.NewGuid();
            DeviceName = deviceName;
            Url = url;
            ReachabilityType = reachabilityType;
        }

        protected AggregateCamera(Guid id, string deviceName, string url, ReachabilityTypes reachabilityType)
        {
            Id = id;
            DeviceName = deviceName;
            Url = url;
            ReachabilityType = reachabilityType;
        }

        public abstract Task<object> ReadData();
    }
}