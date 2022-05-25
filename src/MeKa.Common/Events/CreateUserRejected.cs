namespace MeKa.Common.Events
{
    public class CreateUserRejected : IRejectedEvent
    {
        public string Email { get; }
        public string Reason { get; }
        public string Code { get; }

        /// <summary>
        /// Prevent serialization issues 
        /// </summary>
        protected CreateUserRejected()
        {
        }

        public CreateUserRejected(string email, string reason, string code)
        {
            Email = email;
            Reason = reason;
            Code = code;
        }
    }
}