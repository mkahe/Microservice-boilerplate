using System;

namespace MeKa.Common.Events
{
    public interface IAuthenticatedEvent : IEvent
    {
        Guid UserId { get; set; }
    }
}