using System;
using System.Threading.Tasks;
using MeKa.Common.Commands;
using MeKa.Common.Events;
using RawRabbit;

namespace MeKa.Services.Activities.Handlers
{
    public class CreateActivityHandler : ICommandHandler<CreateActivity>
    {
        private readonly IBusClient _busClient;

        public CreateActivityHandler(IBusClient busClient)
        {
            _busClient = busClient;
        }

        public async Task HandleAsync(CreateActivity command)
        {
            Console.WriteLine($"Creating activity: {command.Name}");
            _busClient.PublishAsync(new ActivityCreated(command.UserId, command.Id, command.Category, command.Name,
                command.Description, command.CreatedAt));
        }
    }
}