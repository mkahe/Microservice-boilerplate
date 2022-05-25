namespace MeKa.Common.Events
{
    public class UserAuthenticated : IEvent
    {
        public string Email { get; }

        /// <summary>
        /// Prevent serialization issues 
        /// </summary>
        protected UserAuthenticated()
        {
        }
        
        public UserAuthenticated(string email)
        {
            Email = email;
        }
    }
}