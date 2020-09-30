using System;
using System.Collections.Generic;

namespace ProjectP.Core.DTO
{
    public class Group : Base
    {
        public List<Group> Groups { get; set; } = new List<Group>();
        public List<Link> Links { get; set; } = new List<Link>();
        public List<Thing> Things { get; set; } = new List<Thing>();
    }
}
