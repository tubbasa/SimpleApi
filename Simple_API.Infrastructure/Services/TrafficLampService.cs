using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simple_API.Domain.SimpleAPIAggregate;
using Simple_API.Infrastructure.DTOs;
using Simple_API.Infrastructure.ORM.JsonFile.Repositories;

namespace Simple_API.Infrastructure.Services
{
    public class TrafficLampService
    {
        private DeviceRepository _deviceRepository;

        public DeviceBusinessLogicService()
        {
            _deviceRepository = new DeviceRepository();
        }

        public async Task<IDevice> GetTrafficLight(Guid guid)
        {
            var deviceResponse = await _deviceRepository.Get<IDevice>(guid);
            return deviceResponse;
        }
        
        public async Task<List<IDevice>> GetTrafficLight()
        {
            var deviceResponse = await _deviceRepository.p0oo0GetAll<IDevice>();
            return deviceResponse.ToList();
        }
    }
    
}