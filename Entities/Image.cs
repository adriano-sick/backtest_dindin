using System.ComponentModel.DataAnnotations.Schema;

namespace Cafeine_DinDin_Backend.Entities
{
    public class Image
    {
        public int ID {get; set;}
        public byte[] image { get; set; }

        [NotMapped]
        public string image64 { get; set; }
    }
}
