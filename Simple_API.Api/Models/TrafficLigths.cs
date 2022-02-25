using Simple_API.Domain.Enums;

namespace Simple_API.Api.Models
{
    public class TrafficLigths
    { 
        public string DeviceName { get; set; }
        public string Url { get; set; }
        public ReachabilityTypes ReachabilityType { get; set; }
        
    }
}