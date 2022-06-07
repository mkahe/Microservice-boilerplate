using System;
using System.Threading.Tasks;
using MeKa.Common.Commands;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;

namespace MeKa.Api.Controllers
{    
    [Route("[controller]")]
    public class ActivitiesController : Controller
    {
        private readonly IBusClient _busClient;
        public ActivitiesController(IBusClient busClient)
        {
            _busClient = busClient;
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody] CreateActivity command)
        {
            command.Id = Guid.NewGuid();
            command.CreatedAt = DateTime.UtcNow;
            
            await _busClient.PublishAsync(command);

            return Accepted($"activities/{command.Id}");
        } 
    }
}