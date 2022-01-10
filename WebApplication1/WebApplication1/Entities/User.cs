using DeviceManagerBackend.Constants;

namespace DeviceManagerBackend.Entities
{
    public class User
    {
    
        public int Id { get; set; }

        public string FirstName { get; set; }
   
        public string LastName { get; set; }
        
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public Roles? Role { get; set; }
        public List<Space> Spaces { get; set; } = new List<Space>();

    }
}
