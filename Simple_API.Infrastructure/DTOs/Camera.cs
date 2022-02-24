using System;
using System.Threading.Tasks;
using Simple_API.Domain.Classes;
using Simple_API.Domain.Enums;
using Simple_API.Domain.SimpleAPIAggregate;
namespace Simple_API.Infrastructure.DTOs
{
    public class Camera : AggregateCamera
    {
        public Camera(string deviceName, string url, ReachabilityTypes reachabilityType) : base(deviceName, url, reachabilityType)
        {
        }

        public override Task<object> ReadData()
        {
            var result = new { Data = "Test verisi" };
            return Task.FromResult((object)result);        }
    }
}