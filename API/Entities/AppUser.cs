namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        
        public byte[] PassworHash { get; set; }
        public byte[] PassworSalt { get; set; }
    }
}