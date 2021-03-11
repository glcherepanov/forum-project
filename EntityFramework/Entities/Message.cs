using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.EntityFramework.Entities
{
    public class Message : IEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }
        
        public virtual Image Image { get; set; }
        //kek
    }
}
