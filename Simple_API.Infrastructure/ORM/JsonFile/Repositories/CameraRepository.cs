using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Simple_API.Domain.Enums;
using Simple_API.Domain.Respositories;
using Simple_API.Infrastructure.DTOs;
using Camera = Simple_API.Domain.Classes.Camera;

namespace Simple_API.Infrastructure.ORM.JsonFile.Repositories
{
    public class CameraRepository : ICameraRepository
    {
        public Task Add(Camera device)
        {
            throw new NotImplementedException();
        }

        public Task Update(Camera device)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid deviceId)
        {
            throw new NotImplementedException();
        }

        public Task<Camera> Get(Guid deviceId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Camera>> GetDevicesByType(ReachabilityTypes reachabilityType)
        {
            throw new NotImplementedException();
        }

        public Task<List<Camera>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}