using System;
using System.Collections.Generic;

namespace ProjectP.Core.DTO
{
    public class Thing : Base
    {
        public List<Property> Properties { get; set; } = new List<Property>();
        public List<Link> Links { get; set; } = new List<Link>();
        public List<Group> PropertyGroups { get; set; } = new List<Group>();
        public List<Group> LinkGroups { get; set; } = new List<Group>();
    }
}
