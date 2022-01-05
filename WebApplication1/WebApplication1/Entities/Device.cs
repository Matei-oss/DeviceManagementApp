using System.ComponentModel.DataAnnotations;

namespace DeviceManagerBackend.Entities
{
    public class Device
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string MacAddress { get; set; }
        public string FirmwareVersion{ get; set; }
        public Room? Room { get; set; }
    }
}
