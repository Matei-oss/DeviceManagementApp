using System.ComponentModel.DataAnnotations;

namespace DeviceManagerBackend.Entities
{
    public class Space
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Room> Rooms { get; set; } = new List<Room>();
        public User? User { get; set; }
    }
}
