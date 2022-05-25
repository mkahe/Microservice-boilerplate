using System;

namespace MeKa.Common.Events
{
    public interface IAuthenticatedEvent
    {
        Guid UserId { get; set; }
    }
}