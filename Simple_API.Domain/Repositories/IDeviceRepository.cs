using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Simple_API.Domain.Enums;
using Simple_API.Domain.SimpleAPIAggregate;

namespace Simple_API.Domain.Respositories
{
    public interface IDeviceRepository<T>
    {
        Task Add(T device);
        Task Update(T device);
        Task Delete(Guid deviceId);
        Task<T> Get(Guid deviceId);
        Task<List<T>> GetDevicesByType(ReachabilityTypes reachabilityType);
        Task<List<T>> GetAll();


    }
}