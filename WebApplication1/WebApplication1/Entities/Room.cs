using DeviceManagerBackend.Models;
using System.ComponentModel.DataAnnotations;

namespace DeviceManagerBackend.Entities
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public Space? Space { get; set; }
        public List<Device> Devices { get; set; } = new List<Device>();
    }
}
