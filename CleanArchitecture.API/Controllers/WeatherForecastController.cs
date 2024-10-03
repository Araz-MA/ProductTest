using CleanArchitecture.API.Hub;
using CleanArchitecture.Application.Common.Interfaces.IAuthentication;
using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.Dapper;
using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.MongoDb.IRepositories;
using CleanArchitecture.Domain.Entities.AppEntities;
using CleanArchitecture.Domain.Entities.IdentityEntities;
using CleanArchitecture.WebCommon.ApiResult;
using CleanArchitecture.WebCommon.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace CleanArchitecture.API.Controllers
{

    [ApiResultFilter]
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {   
        private IHubContext<MessageHub, IMessageHubClient> messageHub;
       
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        IUnitOfWork _unitOfWork;
        private readonly IMongoUnitOfWork _mongoUnitOfWork;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IUnitOfWork unitOfWork,  
            IMongoUnitOfWork mongoUnitOfWork, IHubContext<MessageHub, IMessageHubClient> messageHub)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
           
            _mongoUnitOfWork = mongoUnitOfWork;
            this.messageHub = messageHub;          
        }
         
        [HttpGet(Name = "GetWeatherForecast")]
        [Authorize]
        public async Task<IEnumerable<WeatherForecast>> GetAsync()
        {
 
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

        }
    }
}