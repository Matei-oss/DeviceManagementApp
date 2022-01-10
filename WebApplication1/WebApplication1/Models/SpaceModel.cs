using DeviceManagerBackend.Entities;
using System.ComponentModel.DataAnnotations;

namespace DeviceManagerBackend.Models
{
    public class SpaceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Room> Rooms { get; set; } = new List<Room>();
    }
}
