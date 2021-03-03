using System.Collections.Generic;

namespace Forum.EntityFramework.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Thread> Threads { get; set; }
    }
}
