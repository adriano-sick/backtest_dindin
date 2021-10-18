
namespace Cafeine_DinDin_Backend.Entities
{
    public class Lesson
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public string Link { get; set; }
        public string  UrlImage { get; set; }
       public string Description { get; set; }

        public Lesson(int order, string link, string urlImage, string description)
        {
            this.Order = order;
            Link = link;
            UrlImage = urlImage;
            Description = description;
        }
    }
}
