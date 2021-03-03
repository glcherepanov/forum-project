using System.Collections.Generic;

namespace Forum.EntityFramework.Entities
{
    public class Thread : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual User Creator { get; set; }
        public virtual Message LastMessage { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
