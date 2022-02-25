using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Simple_API.Domain.Enums;
using Simple_API.Domain.SimpleAPIAggregate;
using Simple_API.Infrastructure.DTOs;
using Simple_API.Infrastructure.Exceptions;
using Simple_API.Infrastructure.ORM.JsonFile.Repositories;

namespace Simple_API.Infrastructure.Services
{
    public class TrafficLampService
    {
        private TrafficLampsRepository _trafficLampsRepository;

        public TrafficLampService()
        {
            _trafficLampsRepository = new TrafficLampsRepository();
        }

        public async Task<IDevice> GetTrafficLight(Guid guid)
        {
            var deviceResponse = await _trafficLampsRepository.Get(guid);
            return deviceResponse;
        }
        
        public async Task<List<TrafficLights>> GetTrafficLight()
        {
            var deviceResponse = await _trafficLampsRepository.GetAll();
            return deviceResponse.Select(tl => new TrafficLights(tl.DeviceName,tl.Url,tl.ReachabilityType)).ToList();
            
        }
        
        public async Task<bool> AddTrafficLight(TrafficLights trafficLight)
        {
            await _trafficLampsRepository.Add(trafficLight);
            return true;
        }

        public async Task<object> GetDataFromTrafficLight(Guid guid)
        {
           var lamp =  await _trafficLampsRepository.Get(guid);
           return lamp?.ReadData();
        }
            
    }

}