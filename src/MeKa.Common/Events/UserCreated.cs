namespace MeKa.Common.Events
{
    public class UserCreated : IEvent
    {
        public string Email { get; }
        public string Name { get; }

        /// <summary>
        /// Prevent serialization issues 
        /// </summary>
        protected UserCreated()
        {
        }

        public UserCreated(string email, string name)
        {
            Email = email;
            Name = name;
        }
    }
}