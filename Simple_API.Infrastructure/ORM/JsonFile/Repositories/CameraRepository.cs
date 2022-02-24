using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Simple_API.Domain.Classes;
using Simple_API.Domain.Enums;
using Simple_API.Domain.Respositories;
using Simple_API.Infrastructure.DTOs;

namespace Simple_API.Infrastructure.ORM.JsonFile.Repositories
{
    public class CameraRepository : IDeviceRepository<AggregateCamera>
    {
        public Task Add(AggregateCamera device)
        {
            throw new NotImplementedException();
        }

        public Task Update(AggregateCamera device)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid deviceId)
        {
            throw new NotImplementedException();
        }

        public Task<AggregateCamera> Get(Guid deviceId)
        {
            throw new NotImplementedException();
        }

        public Task<List<AggregateCamera>> GetDevicesByType(ReachabilityTypes reachabilityType)
        {
            throw new NotImplementedException();
        }

        public Task<List<AggregateCamera>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}