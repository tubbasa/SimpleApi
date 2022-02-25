using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Simple_API.Api.CustomAttributes;
using Simple_API.Domain.Enums;
using Simple_API.Domain.SimpleAPIAggregate;
using Simple_API.Infrastructure.DTOs;
using Simple_API.Infrastructure.ORM.JsonFile.Repositories;
using Simple_API.Infrastructure.Services;
using TrafficLightsUserModel = Simple_API.Api.Models.TrafficLigths;

namespace Simple_API.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class TrafficLightsController : ControllerBase
    {
        //private readonly ILogger<WeatherForecastController> _logger;
        private readonly TrafficLampService _trafficLampsService;
        public TrafficLightsController()
        {
            _trafficLampsService = new TrafficLampService();
        }

        [HttpGet]
        public async Task<List<TrafficLights>> Get() //This IDevice type will be changed with service model.
        {
           var result = await _trafficLampsService.GetTrafficLight();
           return result;
        }

        [HttpGet("{guid}/getdata")]
        public async Task<object> GetDataFromTrafficLights(Guid guid)
        {
            var readData = await _trafficLampsService.GetDataFromTrafficLight(guid);
            return readData;
        }
        
        [HttpPost]
        public async Task<bool> Post(TrafficLightsUserModel trafficLight) //This IDevice type will be changed with service model.
        {
            var result = await _trafficLampsService.AddTrafficLight( new TrafficLights(trafficLight.DeviceName,trafficLight.Url,trafficLight.ReachabilityType));
            return result;
        }
    }
}