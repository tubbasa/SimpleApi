using System;
using System.Threading.Tasks;
using Simple_API.Domain.Enums;
using Simple_API.Domain.SimpleAPIAggregate;

namespace Simple_API.Domain.Respositories
{
    public interface IDeviceRepository
    {
        Task Add(IDevice device);
        Task Update(IDevice device);
        Task Delete(Guid deviceId);
        Task Get(Guid deviceId);
        Task GetDevicesByType(ReachabilityTypes reachabilityType);
        Task GetAll();


    }
}