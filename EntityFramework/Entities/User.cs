using System.Collections.Generic;

namespace Forum.EntityFramework.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual Image Image { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
