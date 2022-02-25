using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Simple_API.Domain.Classes;
using Simple_API.Domain.Enums;
using Simple_API.Domain.Respositories;
using Simple_API.Infrastructure.DTOs;
using Simple_API.Infrastructure.Exceptions;
using Simple_API.Infrastructure.Mock;

namespace Simple_API.Infrastructure.ORM.JsonFile.Repositories
{
    public class TrafficLampsRepository : IDeviceRepository<TrafficLights>
    {
        private readonly string trafficJsonPath ="trafficLights.json" ;
        private readonly string cameraJsonPath ="cameras.json" ;
        public async Task Add(TrafficLights device)
        {
            try
            {
                var table = await this.GetAll();
                table.Add(device);
                File.WriteAllText(trafficJsonPath, JsonConvert.SerializeObject(table));
            }
            catch (Exception e)
            {
                throw new FileWriteError("Error happened when writing file.",500);
            }
        }

        public async Task Update(TrafficLights device)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(Guid deviceId)
        {
            throw new NotImplementedException();
        }

        public async Task<TrafficLights> Get(Guid deviceId)
        {
            try
            {
                var lines = File.ReadAllText(trafficJsonPath);
                var trafficLightsList = JsonConvert.DeserializeObject<List<TrafficLights>>(lines);
                return trafficLightsList?.FirstOrDefault(tl=> tl.Id == deviceId);
            }
            catch (Exception e)
            {
                throw new FileReadException("There was an error while reading file",500);
            }        
        }

        public async Task<List<TrafficLights>> GetDevicesByType(ReachabilityTypes reachabilityType)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TrafficLights>> GetAll()
        {
            try
            {
                var lines = File.ReadAllText(trafficJsonPath);
                var trafficLightsList = JsonConvert.DeserializeObject<List<TrafficLights>>(lines);
                return trafficLightsList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}