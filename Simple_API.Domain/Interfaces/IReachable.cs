using System.Threading.Tasks;
using Simple_API.Domain.Enums;

namespace Simple_API.Domain.SimpleAPIAggregate
{
    public interface IReachable
    {
        public string Url { get; }
        public ReachabilityTypes ReachabilityType { get; set; }

        Task<object> ReadData();
    }
}