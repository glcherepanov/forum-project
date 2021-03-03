namespace Forum.EntityFramework.Entities
{
    public class Image : IEntity
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public Image Type { get; set; }
    }
}
