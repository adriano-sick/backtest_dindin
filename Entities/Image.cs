using System.ComponentModel.DataAnnotations.Schema;

namespace Cafeine_DinDin_Backend.Entities
{
    public class Image
    {
        public int ID {get; set;}
        public byte[] ImageByte { get; set; }

        [NotMapped]
        public string Image64 { get; set; }
    }
}
